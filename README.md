# Test - Manuel Morales

- Tools

  - Docker Desktop
  - Httpie
  - Browser
  - Node.js
  - Pnpm instalado `curl -fsSL https://get.pnpm.io/install.sh | sh -`
  - Dotnet SDK 8.0
  - Editor de codigo
  - Eraser.io

- Route Map Proyecto

  - Iniciar el Proyecto - Git ✅
  - Seteo de docker con base de datos - visualizador - pull de dos contenedores
    ✅
  - Inicar el monorepositorio `pnpm workspaces`
  - Crear los frontend y backend | `Nextjs` | `ASP.NET Core`
  - Setar los proyectos
  - Crear los scripts de ejecucion
    - Ambos
      - `dev` entorno de development
      - `build` buildear el Proyecto
      - `start` iniciar el Proyecto
    - Frontend
      - `lint` para verificar el codigo
    - Backend
      - `migrate` nos crear las migraciones de ef core
      - `reset:db` reiniciar la base de datos
  - Crear el entidad relacion con eraser.io
  - CI/CD

- Route Map backend

  - Crear las entidades, La capa de Dominio
  - Crear las infrastructura, Ef core, Postgresql
    - Crear un seed data, ingresar datos de prueba cuando se levanta el proyecto
      (opcional)
  - Crear la capa de aplicacion, Crear un usuario, Eliminar un usuario
  - Crear los endpoints los controladores de mi API

- Route Map Frontend

  - Web scrapping de la pagina de imdb (opcional) | Puedo usar una ia para
    generar datos | mete tus datos
  - Crear las Cards iniciales, MovieCard
  - Crear la pagina de movie
  - Home Page, principal,
  - ActorCard, ActorPage
  - Nav bar, search bar

- Test unitraios
