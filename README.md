# Parcial-2-Practico
# Solución de Capas y Autenticación 


---

## 🛠️ Tecnologías y Versiones
* **Lenguaje:** C# (.NET 10.0)
* **Plataforma:** Windows Forms (WinForms)
* **Base de Datos:** MySQL / MySQL Workbench
* **Librería de Conexión:** MySql.Data (NuGet)
* **Seguridad de Contraseñas:** SHA-512 con procedimiento almacenado (`sp_ValidarLoginHash`)

---

## 🎛️ Controles Utilizados
* `Form` (Formularios de autenticación y principal MDI)
* `Panel` (Diseño de menú lateral responsivo)
* `Label` (Visualización de datos de sesión, ID de usuario y textos estáticos)
* `TextBox` (Campos de entrada para usuario y contraseña con enmascaramiento)
* `Button` (Acciones de inicio de sesión y navegación)
* `Timer` (Actualización en tiempo real del reloj del sistema)

---

## 📂 Arquitectura del Proyecto (Arquitectura en Capas)
El proyecto está estructurado de manera modular siguiendo las buenas prácticas de separación de responsabilidades:
1. **Presentación (`Presentacion`):** Interfaz gráfica de usuario en Windows Forms (`Form1` para Login y `FrmPrincipal`).
2. **Lógica de Negocio (`Negocio`):** Contratos de servicio (`IHashService`, `IVerificarHashService`) y reglas de negocio.
3. **Acceso a Datos (`Datos`):** Conexión a la base de datos MySQL y ejecución de procedimientos almacenados.
4. **Entidades (`Entidades`):** Clases y modelos de transferencia de datos (ej. `E_Usuario`).

---

## 🚀 Proceso de Instalación y Configuración

1. **Base de Datos:**
   * Importar el archivo `backup.sql` proporcionado en el laboratorio dentro de tu servidor MySQL o phpMyAdmin.
   * Verificar que el procedimiento almacenado `sp_ValidarLoginHash` exista en la base de datos `db_sistema_login` o equivalente.

2. **Cadena de Conexión:**
   * Configurar los parámetros de conexión (servidor, usuario, contraseña) en la clase `D_Conexion.cs` dentro de la capa de Datos.

3. **Ejecución:**
   * Abrir la solución en Visual Studio.
   * Establecer el proyecto `Presentacion` como proyecto de inicio.
   * Compilar y ejecutar la aplicación (`F5`).

---

## 🖼️ Imágenes de Resultados

### 1. Pantalla de Inicio de Sesión (Login)
*(Aquí puedes adjuntar una captura de tu pantalla de login validando credenciales)*

### 2. Formulario Principal (MDI) y Menú Lateral
*(Aquí puedes adjuntar una captura del `FrmPrincipal` con el menú lateral negro, la hora en tiempo real y el usuario logueado en la esquina inferior)*

### 3. Validaciones de Errores
*(Aquí puedes adjuntar una captura del mensaje de error cuando los datos de acceso son incorrectos)*

---

## 📌 Detalle del Autor y Fecha
* **Autor:** Neo
* **Universidad:** Universidad Tecnológica de Panamá (UTP)
* **Facultad:** Facultad de Ingeniería en Sistemas Computacionales
* **Asignatura:** Herramientas de la Programación Aplicada III (.NET)
* **Fecha:** 9 Noviembre de 2026
