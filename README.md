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

Una vez que la consola aparezca solo tiene que escribir el comando correspondiente para descargar una depencencia con ```Install-packege```

Si la dependencia **Swashbuckle.AspNetCore** faltara solo tendría que ejecutar el siguiente comando ```Install-packege <Dependencia>```  
ejemplo:

```Install-packege Swashbuckle.AspNetCore```

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
Para usar esta API con ejemplos mas claros en la app de Postman, puede usar este [Link](https://documenter.getpostman.com/view/10295654/SzzhdySk?version=latest) y lo dirigirá a documentacion de Postman para hacer uso de la API de forma local, en la parte superior derecha de la página encontrara el botón *Run in Postman* que le permitirá hacer uso de estos ejemplos en forma local, al presionalo le preguntara como desea abrir Postam, una vez seleccionado deberá de dar permiso en la ventana emergente superior y presionar *Open Postman*.

## Lint
El linter utilizado para el desarrollo del código C# fue [SonarLint](https://www.sonarlint.org/visualstudio/), puede ser descargado y utilizado como una extensión del IDE Visual Studio.

## Pruebas unitarias
