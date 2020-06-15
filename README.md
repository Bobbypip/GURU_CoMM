# GURU_CoMM
Evaluación para proceso de selección

## Requisitos:
- Visual Studio 2019
- ASP.NET Core 3.0 o superior
- IIS Express
- SQL Server
- Postman

## Guía de instalación rápida:
### Descargar el proyecto.
Descague el archivo .zip de la liga proporcionada de Google Drive y descomprímalo en su ordenador.  
En la carpeta resultante encontrará dos carpetas, GURU_CoMM y GURU_CoMM_UnitaryTests, abra Visual Studio y de click sobre **Open a project or solution** o **Abrir un projecto o una solución**, vaya a la capeta GURU_CoMM y haga doble click en el archivo GURU_CoMM.sln. Una vez hecho esto verá como aparece la ventana de Visual Studio y podrá comenzar a interactuar con el software.  

Vaya a:

**Vista/Explorador de soluciones/GURU_CoMM/Dependencias/Startup.cs**  
**View/Solution Explorer/GURU_CoMM/Dependencies/Startup.cs**

## Dependencias:  
Asegurarse de que las siguientes dependedecias esten disponibles:  
- AutoMapper.Extensions.Microsoft.DependencyInjection
- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools
- Swashbuckle.AspNetCore

Para esto basta con ir a:

**Vista/Explorador de soluciones/GURU_CoMM/Dependencias/Paquetes**  
**View/Solution Explorer/GURU_CoMM/Dependencies/Packages**

En caso de faltar alguna necesita ejecutar el comando en consola de administrador de paquetes para descargarla, esto se hace de la siguiente manera:

Ir a **Herramientas/Administrador de Paquetes NuGet/Consola de Administrador de paquetes.**  
Ir a **Tools/NuGet Package Manager/Packege Manager Console.** 

Una vez que la consola aparezca solo tiene que escribir el comando correspondiente para descargar una depencencia con ```install-packege```

Si la dependencia **Swashbuckle.AspNetCore** faltara solo tendría que ejecutar el siguiente comando ```install-packege <Dependencia>```  
ejemplo:

```install-packege Swashbuckle.AspNetCore```

## Creación de la base de datos:
La base de datos necesita ser creada antes de que pueda interactuar con la API, para esto necesita ejecutar el comando ```update-database``` en la consola de administrador de paquetes, este comando creará la base de datos como una instancia local de Sql Server junto con 3 registros listos para ser consultados.

## Correr el proyecto:
Para correr la API en local host solo tiene que ir a:

**Depurar/Comenzar sin Depurar**  
**Debug/Start Without Debugging**

o presionar Ctrl+F5. Enseguida se abrirá una ventana de su navegador predeterminado con la documentación de la API, desarrollada con Swagger.

### Swagger
My WEB API GURU_COMM

#### Pets  
En esta sección se encuentran las diferentes peticiones que podremos realizar, para probrar una basta con hacer click sobre ella, inmediatamente sobre el lado superior derecho entontrara un botón *Try it out*, al presionarlo se habilitará el botón *Execute* y podrá hacer uso de la petición seleccionada para probarla.

#### Schemas
Esta sección muestra los ViewModels utilizados para la API asi como sus propiedades de cada uno.

### Postman
Para usar esta API con ejemplos mas claros en la app de Postman, puede usar este [Link](https://documenter.getpostman.com/view/10295654/SzzhdySk?version=latest) y lo dirigirá a documentación de Postman para hacer uso de la API de forma local, en la parte superior derecha de la página encontrara el botón *Run in Postman* que le permitirá hacer uso de estos ejemplos en forma local, al presionalo le preguntará como desea abrir Postam, una vez seleccionado deberá de dar permiso en la ventana emergente superior y presionar *Open Postman*.

## Lint
El linter utilizado para el desarrollo del código C# fue [SonarLint](https://www.sonarlint.org/visualstudio/), puede ser descargado y utilizado como una extensión del IDE Visual Studio.

## Pruebas unitarias:  

### Agregar proyecto  
Para correr las pruebas unitarias es necesario agregar el proyecto que las contiene a nuestra solución, para hacer esto vamos al explorador de soluciones y damos click derecho sobre **Solution 'GURU-CoMM'** o **Solución 'GURU-CoMM'**, en la ventana que aparece seleccionamos Add o Agregar y después Existing Project... o Proyecto Existente..., vamos a la carpeta GURU_CoMM_UnitaryTests y dentro de ella abrimos el archivo GURU_CoMM_UnitaryTests.csproj.

Se nos agregará el proyecto de pruebas unitarias a nuestra solución.

### Dependencias  
Asegurarse de que las siguientes dependedecias esten disponibles en el prpyecto que acaba de agregar:  
- AutoMapper.Extensions.Microsoft.DependencyInjection
- Microsoft.EntityFrameworkCore.InMemory
- Microsoft.NET.Test.Sdk
- Moq
- MSTest.TestAdapter
- MSTest.TestFramework

En caso de no contar con alguna, vaya a la consola de administrador de paquetes y seleccione primero el proyeto actual (GURU_CoMM_UnitaryTests) en **Default Project** en la parte superior de la consola tiene que elegir GURU_CoMM_UnitaryTests antes de teclear algún comando, esto para que los comandos se apliquen al proyecto de pruebas unitarias.

### Agregar referecia    
Para correrlas primero es necesario agregar una referecia al proyecto de pruebas unitarias del proyecto original, los pasos para hacer esto son los siguientes:

1. Click derecho sobre GURU_CoMM_UnitaryTests.
2. Add o Agregar.
3. Project Reference o Referencia de Projecto.
4. En la ventana que acaba de aparecer del lado izquierdo seleccionar Projects o Proyectos y enseguida Solution o Solución.
5. Notará que solo existe un proyecto, este debe ser GURU_CoMM, del lado izquierdo seleccionelo al colocar la paloma en el cuadro de selección
6. Una vez hecho esto, presione OK y la ventana se cerrará.

### Correr pruebas
Por último para realizar la pruebas, en la parte superior haga click sobre Test o Pruebas y después en Explorador de Pruebas o Test Explorer.

En la ventana que se acaba de abrir notará las pruebas que pueden realizarse, para ello solo de click sobre el primer ícono de izquierda a derecha de Play(2 triángulos verdes, Correr todas las pruebas) y eso sera todo, las pruebas se ejecutarán.
