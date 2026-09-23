# GHSI – Sistema de Inventario para Distribuidora de Gaseosas

Aplicación de escritorio para gestionar el inventario de una distribuidora de bebidas: productos, proveedores, compras que ingresan stock por lotes, ventas que descuentan stock, clientes y usuarios con distintos permisos según su rol.

Proyecto final desarrollado en **C# (.NET 8, Windows Forms)** con base de datos **MySQL**.

---

## Índice

1. [Funcionalidades](#funcionalidades)
2. [Roles y permisos](#roles-y-permisos)
3. [Tecnologías](#tecnologías)
4. [Requisitos](#requisitos)
5. [Instalación y puesta en marcha](#instalación-y-puesta-en-marcha)
6. [Usuarios de prueba](#usuarios-de-prueba)
7. [Base de datos](#base-de-datos)
8. [Reglas de negocio](#reglas-de-negocio)
9. [Seguridad](#seguridad)
10. [Estructura del proyecto](#estructura-del-proyecto)
11. [Problemas frecuentes](#problemas-frecuentes)
12. [Autor](#autor)

---

## Funcionalidades

### Inicio de sesión
- Primero se elige el **rol** (Administrador, Gerente o Empleado). Recién entonces se habilitan el email y la contraseña.
- Se valida el email, la contraseña y que el rol elegido coincida con el del usuario.
- Al tocar **Salir** en el menú se cierra la sesión y se vuelve al login limpio, listo para que ingrese otra persona.

### Menú principal
Muestra un saludo con el nombre y el rol del usuario, más botones para cada módulo: **Productos, Proveedores, Compras, Ventas, Clientes, Usuarios** (solo Administrador) y **Salir**.

### Productos
- Listado completo con marca, categoría, subcategoría, sabor, tamaño, envase, precio de venta, **stock actual** y stock mínimo.
- Alta y edición con listas desplegables en cascada: marca → categoría → subcategoría.
- El Administrador puede agregar nuevas marcas, categorías y subcategorías desde el mismo formulario (botones **+**).
- Baja lógica y papelera para reactivar productos eliminados (Administrador).

### Proveedores
- Alta, edición y baja lógica de proveedores (empresa, email, código de área y teléfono).
- Papelera para reactivar proveedores eliminados (Administrador).

### Compras (ingreso de mercadería)
- Registro de compras con varios renglones. Cada renglón lleva producto, proveedor, cantidad, precio de compra y **fecha de vencimiento**.
- Cada renglón genera un **lote** de inventario, y el stock del producto aumenta automáticamente.
- Listado de compras con el detalle de la compra seleccionada, más baja lógica y reactivación (Administrador).

### Ventas
Hay dos tipos de venta:

| Tipo | Para quién | Datos del comprador |
|---|---|---|
| **Venta local** | Gente que va a comprar a la distribuidora (mostrador) | Nombre opcional; si no se carga queda como *Consumidor final* |
| **Venta a cliente** | Almacenes, supermercados y otros comercios | Cliente obligatorio, elegido de la lista de clientes |

- Carrito con varios productos. El precio de venta se completa solo y se puede ajustar.
- **Control de stock:** no se puede vender más de lo disponible.
- El stock se descuenta de los lotes empezando por el de **vencimiento más próximo** (FIFO por vencimiento).
- Listado con columnas de tipo, cliente o comprador, responsable, total y estado, más un filtro *Todas / Solo locales / Solo a clientes*.
- **Anular renglón:** devuelve al stock solo ese producto y descuenta su subtotal del total.
- **Anular venta completa:** devuelve al stock **todos** los productos de la venta.
- Los renglones anulados siguen visibles en el detalle, en gris y tachados. Las ventas se marcan como *Activa*, *Con renglones anulados* o *Anulada*.

### Clientes
- Alta, edición y baja lógica de clientes (razón social, CUIT/CUIL, contacto, dirección, límite de crédito y canal/lista).
- Papelera para reactivar clientes eliminados (Administrador).

### Usuarios (solo Administrador)
- Alta de nuevos **Gerentes** y **Empleados**: nombre, email, rol y contraseña con confirmación.
- Validaciones de formato de email, email no repetido y contraseña de al menos 6 caracteres.
- Edición: si la contraseña se deja vacía, no se cambia.
- Baja lógica y reactivación. Un usuario eliminado no puede iniciar sesión.
- Los usuarios Administrador no se pueden editar ni eliminar desde esta pantalla.

---

## Roles y permisos

| Módulo | Administrador | Gerente | Empleado |
|---|:---:|:---:|:---:|
| Productos (agregar / editar / eliminar) | ✅ | ✅ | 👁️ solo ver |
| Agregar marcas, categorías y subcategorías | ✅ | ❌ | ❌ |
| Proveedores | ✅ | ✅ | 👁️ solo ver |
| Compras | ✅ | ✅ | 👁️ solo ver |
| Clientes | ✅ | ✅ | 👁️ solo ver |
| **Registrar ventas** (local y a cliente) | ✅ | ✅ | ✅ |
| Anular renglón / venta completa | ✅ | ✅ | ❌ |
| Ver eliminados y reactivar (papelera) | ✅ | ❌ | ❌ |
| Usuarios | ✅ | ❌ | ❌ |

> El **Empleado** solo puede **vender**. El resto de los módulos los puede consultar, pero no modificar.

---

## Tecnologías

| Componente | Versión |
|---|---|
| Lenguaje | C# |
| Framework | .NET 8 (`net8.0-windows`) – Windows Forms |
| Base de datos | MySQL 8 |
| Conector | `MySql.Data` 26.7.0 (NuGet) |
| Hash de contraseñas | `BCrypt.Net-Next` 4.0.3 (NuGet) |
| IDE | Visual Studio 2022 |

---

## Requisitos

- Windows 10 u 11
- [Visual Studio 2022](https://visualstudio.microsoft.com/) con la carga de trabajo **Desarrollo de escritorio de .NET**
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [MySQL Server 8](https://dev.mysql.com/downloads/mysql/) y MySQL Workbench (u otro cliente)

---

## Instalación y puesta en marcha

### 1. Clonar el repositorio

```bash
git clone https://github.com/GabrielHaurane/GHSI.git
```

O desde Visual Studio: **Git → Clonar repositorio**.

### 2. Crear la base de datos

1. Abrir **MySQL Workbench** y conectarse al servidor.
2. Abrir el script [`BaseDeDatos/sistemadeinventarioBDfinal.sql`](BaseDeDatos/sistemadeinventarioBDfinal.sql).
3. Ejecutarlo completo (botón ⚡).

El script crea la base `sistemadeinventariobdfinal` desde cero, con todas las tablas, datos de ejemplo, roles y usuarios de prueba.

> ⚠️ El script **borra y vuelve a crear** la base (`DROP DATABASE IF EXISTS`). Si ya tenés datos cargados, hacé un backup antes.

**Si ya tenías la base de una versión anterior** (sin ventas locales), no hace falta recrearla. Alcanza con ejecutar una sola vez [`cambios_bd_ventas_locales.sql`](cambios_bd_ventas_locales.sql), que agrega a la tabla `venta` las columnas `tipo_venta` y `nombre_comprador` y permite `id_cliente` nulo.

### 3. Configurar la conexión

La contraseña de MySQL **no está en el código**. Se lee de un archivo de configuración local que no se sube a GitHub.

1. En la carpeta `GHSistemaDeInventario/`, copiar `appsettings.example.json` con el nombre **`appsettings.json`**.
2. Poner el usuario y la contraseña de MySQL:

```json
{
  "MySqlConnectionString": "Server=localhost;Database=sistemadeinventariobdfinal;Uid=root;Pwd=TU_PASSWORD;"
}
```

`appsettings.json` se copia automáticamente junto al ejecutable al compilar.

### 4. Compilar y ejecutar

1. Abrir `GHSistemaDeInventario.sln` en Visual Studio 2022.
2. Los paquetes NuGet se restauran solos (si no, clic derecho en la solución → **Restaurar paquetes NuGet**).
3. Compilar con **Ctrl + Shift + B** y ejecutar con **F5**.

---

## Usuarios de prueba

| Rol | Nombre | Email | Contraseña |
|---|---|---|---|
| Administrador | Gabriel Haurane | `admin@distribuidora.com` | `123456` |
| Gerente | Franco Menendez | `franco.gerente@distribuidora.com` | `123456` |
| Empleado | Dahiana Leguizamon | `dahiana.empleado@distribuidora.com` | `123456` |

> En el script las contraseñas de prueba están en texto plano. **La primera vez que cada usuario inicia sesión, el sistema la convierte automáticamente a un hash BCrypt.** Los usuarios creados desde la pantalla *Usuarios* se guardan directamente con hash.

---

## Base de datos

Nombre: **`sistemadeinventariobdfinal`**

| Tabla | Descripción |
|---|---|
| `marca` | Marcas de bebidas |
| `categoria` | Categorías (asociadas a una marca) |
| `subcategoria` | Subcategorías (asociadas a una categoría) |
| `producto` | Productos: SKU, sabor, tamaño, envase, precio de venta, stock mínimo |
| `proveedor` | Proveedores |
| `compra` | Cabecera de cada compra (fecha, tipo de movimiento, responsable) |
| `detalle_compra` | Renglones de la compra (producto, proveedor, cantidad, precio, vencimiento) |
| `lote` | **Inventario real**: cada ingreso de mercadería con su vencimiento y cantidad actual |
| `cliente` | Clientes comerciales (almacenes, supermercados, etc.) |
| `venta` | Cabecera de la venta: tipo (`Local` / `Cliente`), cliente o comprador, total, responsable |
| `detalle_venta` | Renglones de la venta, con el lote del que salió cada producto |
| `rol` | Administrador, Empleado y Gerente |
| `usuario` | Usuarios del sistema (contraseña con hash BCrypt) |
| `pedido`, `detalle_pedido` | Pedidos y remitos, previstos para una versión futura (sin pantalla todavía) |

Vista **`vista_stock_producto`**: stock actual de cada producto (suma de `lote.cantidad_actual`).

### Circuito del stock

```
COMPRA ──► detalle_compra ──► LOTE (+cantidad)
                                │
                                ▼
VENTA  ──► detalle_venta  ──► LOTE (−cantidad, FIFO por vencimiento)
                                │
ANULACIÓN ─────────────────────► LOTE (+cantidad devuelta)
```

---

## Reglas de negocio

- **Baja lógica:** nada se borra físicamente. Cada tabla tiene la columna `borrado` (`0` = activo, `1` = eliminado). El Administrador puede ver los registros eliminados y reactivarlos.
- **Stock por lotes:** el stock de un producto es la suma de `cantidad_actual` de sus lotes activos. No se guarda un stock "suelto" que se pueda desincronizar.
- **FIFO por vencimiento:** al vender se descuenta primero del lote que vence antes. Si una cantidad no entra en un solo lote, se reparte en varios renglones de `detalle_venta`, uno por lote.
- **Transacciones:** registrar una venta y anularla se hacen dentro de una transacción. Si algo falla, no se guarda nada a medias.
- **Anulaciones:** al anular se devuelve al lote exacto de donde salió cada unidad. Si se anulan todos los renglones de una venta, la venta queda anulada.
- **Confirmaciones:** las eliminaciones, reactivaciones, anulaciones, las ventas y el cierre de sesión piden confirmación antes de ejecutarse.

---

## Seguridad

- Las contraseñas se guardan con **hash BCrypt**, nunca en texto plano.
- La cadena de conexión a MySQL está en `appsettings.json`, que está en el `.gitignore` y **no se sube** al repositorio. Se incluye `appsettings.example.json` como plantilla.
- Todas las consultas SQL usan **parámetros** (`@parametro`), así que el sistema está protegido contra inyección SQL.
- Los permisos se controlan según el rol del usuario que inició sesión.

---

## Estructura del proyecto

```
GHSI/
├── GHSistemaDeInventario.sln
├── README.md
├── .gitignore
├── cambios_bd_ventas_locales.sql      ← actualización para bases existentes
├── BaseDeDatos/
│   └── sistemadeinventarioBDfinal.sql ← script completo de la base
└── GHSistemaDeInventario/
    ├── Program.cs                     ← punto de entrada (abre el login)
    ├── Sesion.cs                      ← conexión y datos del usuario logueado
    ├── EstiloUI.cs                    ← colores y estilo de botones
    ├── ItemCombo.cs, Dialogos.cs      ← clases auxiliares
    ├── Inicio_Sesion.cs               ← login
    ├── Principal.cs                   ← menú principal
    ├── ListadoProductos.cs   / AgregarProductos.cs
    ├── ListadoProveedores.cs / AgregarProveedores.cs
    ├── ListadoCompras.cs     / AgregarCompra.cs
    ├── ListadoVentas.cs      / AgregarVenta.cs
    ├── ListadoClientes.cs    / agregarClientes.cs
    ├── ListadoUsuarios.cs    / AgregarUsuario.cs
    ├── appsettings.example.json       ← plantilla de configuración
    └── appsettings.json               ← (local, NO se sube)
```

Cada pantalla tiene su archivo `.Designer.cs` con el diseño del formulario.

---

## Problemas frecuentes

| Error | Causa y solución |
|---|---|
| *No se pudo leer la cadena de conexión desde 'appsettings.json'* | Falta el archivo. Copiá `appsettings.example.json` como `appsettings.json`, completá la contraseña y recompilá. |
| *Access denied for user 'root'@'localhost'* | Usuario o contraseña de MySQL incorrectos en `appsettings.json`. |
| *Unknown database 'sistemadeinventariobdfinal'* | No se ejecutó el script de la base de datos (paso 2). |
| *Unknown column 'v.tipo_venta'* | La base es de una versión anterior. Ejecutá `cambios_bd_ventas_locales.sql`. |
| *El rol seleccionado no corresponde a este usuario* | El rol elegido en el login no es el del usuario. Elegí el rol correcto. |

---

## Autor

**Gabriel Haurane**
Proyecto final – Instituto
