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
  - Crear los frontend | `Nextjs` ✅
  - Crear el backend | `ASP.NET Core` ✅
  - Setear los proyectos ✅
  - Inicar el monorepositorio `pnpm workspaces` ✅
  - Crear los scripts de ejecucion
    - Ambos ✅
      - `dev` entorno de development
      - `build` buildear el Proyecto
      - `start` iniciar el Proyecto
    - Frontend ✅
      - `lint` para verificar el codigo
      - `format` para formatear el codigo
    - Backend ✅
      - `migrate` nos crear las migraciones de ef core
      - `reset:db` reiniciar la base de datos
  - CI/CD
  - Deployment

- Route Map backend

  - Crear el entidad relacion con eraser.io
  - Crear las entidades, La capa de Dominio
  - Crear las infrastructura, Ef core, Postgresql
    - Crear un seed data, ingresar datos de prueba cuando se levanta el proyecto
      (opcional)
  - Crear la capa de aplicacion, Crear un usuario, Eliminar un usuario
  - Crear los endpoints los controladores de mi API
  - Test Unitario

- Route Map Frontend

  - Web scrapping de la pagina de imdb (opcional) | Puedo usar una ia para
    generar datos | mete tus datos
  - Crear las Cards iniciales, MovieCard
  - Crear la pagina de movie
  - Home Page, principal,
  - ActorCard, ActorPage
  - Nav bar, search bar
