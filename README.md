# 🎬 Proyecto Cine

¡Bienvenido a **Proyecto Cine**!  
Esta es una aplicación web desarrollada en **ASP.NET Core Blazor Server** con **MudBlazor** para ofrecer una experiencia interactiva, moderna y fluida en la gestión de una cartelera de cine.

---

## 🚀 Características principales

- 🎞️ **Catálogo interactivo de películas** con carteles, descripciones y valoración por estrellas.
- 🔍 **Filtrado y búsqueda dinámica** por título.
- 🕒 **Visualización del horario por sala y día**.
- 🛒 **Compra de entradas** con selección de consumibles y asientos.
- 🪑 **Selector visual de butacas** por sala y sesión.
- 📋 **Panel de administración** accesible solo para usuarios con rol de administrador.

---

## 🔐 Autenticación y gestión de sesión

La aplicación incluye un sistema completo de gestión de usuarios, desarrollado con buenas prácticas de estado en Blazor Server:

- ✅ Inicio de sesión persistente con `ProtectedSessionStorage`.
- 👋 Muestra personalizada de bienvenida: “Bienvenido, [nombre del usuario]”.
- 🔄 Renderizado dinámico del menú: los botones **“Iniciar sesión”** y **“Registrarse”** desaparecen automáticamente cuando el usuario está autenticado.
- 🚪 Confirmación elegante al cerrar sesión: se utiliza `MudBlazor.ShowMessageBox()` para mostrar un diálogo modal que pregunta al usuario si realmente desea cerrar sesión.
- 🧠 El estado del usuario se gestiona globalmente a través de un servicio `UserState` inyectado en toda la aplicación.

---

## 🖼️ Vista previa

<p align="center">
  <img src="Demo/wwwroot/images/spiderman.jpg" alt="Spiderman" width="300"/>
  <img src="Demo/wwwroot/images/matrix.jpg" alt="Matrix" width="300"/>
  <img src="Demo/wwwroot/images/joker.jpg" alt="Joker" width="300"/>
</p>

<p align="center">
  <img src="Demo/wwwroot/images/sala.jpg" alt="Sala de cine" width="600"/>
</p>

---

## 🛠️ Requisitos técnicos

- [.NET 9 SDK](https://dotnet.microsoft.com/)
- Servidor MySQL para la base de datos

---

## 🧪 Ejecución rápida

1. Restaura las dependencias y compila el proyecto:
   ```bash
   dotnet build
   ```
2. Ejecuta la aplicación:
   ```bash
   dotnet run --project Demo/Demo.csproj
   ```
3. Abre tu navegador en `https://localhost:5001` o la dirección que indique la consola.

## Estructura del repositorio

- `Demo/` &mdash; Proyecto principal de la aplicación.
- `Demo/Data` &mdash; Modelos de Entity Framework Core y contexto de base de datos.
- `Demo/Pages` &mdash; Componentes de la interfaz construidos con Razor y MudBlazor.
- `Demo/wwwroot/images` &mdash; Recursos gráficos utilizados en la web.

## Licencia

Este proyecto está bajo la licencia MIT. Consulta [LICENSE.txt](LICENSE.txt) para más información.

¡Esperamos que disfrutes del proyecto y que la experiencia te deje con ganas de visitar la cartelera una y otra vez!
