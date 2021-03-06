# UI test con Selenium en Visual Studio

A continuación, voy a mostrar cómo utilizar Visual Studio 2017 para realizar test de UI con Selenium.

# Nuestro primer Test: Hello World!

Vamos a crear un proyecto de Visual Studio en C# de Test. Ponemos un nombre al proyecto y seleccionamos .Net Framework (en el momento de escribir este tutorial no estaban disponibles los paquetes NuGet necesarios para .Net Core). Y para finalizar, creamos el proyecto.

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step1.png)

Tras crear el proyecto, vamos a modificar el nombre al fichero "UnitTest1.cs".

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step2.png)

Y ahora es cuando vamos a añadir los paquetes NuGet que nos permitirá poner en funcionamiento los Test UI con Selenium.

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step3.png)

Como habrás observado existen driver para diferentes navegadores, yo voy a decantarme por Chrome debido a que en la sección de integración con la app web vamos a utilizar un complemento para Chrome.

Tras añadir los paquetes solamente nos queda añadir el código para realizar nuestro primer Test de UI y como no podría ser de otra forma, vamos a realizar una búsqueda en Google del texto "Hello World! Sample".

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step4.png)

Si no has guardado los cambios al proyecto, es el momento para hacerlo.

Ahora vamos a lanzar los test. Si no tienes cargado "Test Explorer", podrás ponerlo visible desde la opción: Test > Windows > Test Explorer. Una vez cargado, vamos a lanzar el test:

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step5.png)

Si el test da un error:

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step61.png)

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step62.png)

Es posible quedabas configurar las opciones de arquitectura del procesador:

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step7.png)

Una vez modificadas, vamos a lanzar de nuevo nuestros Test:

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step8.gif)

Como podrás haber observado en la anterior animación, estamos lanzando una sesión de Chrome a la url https://www.google.com/ donde localizamos la caja de búsqueda e introducimos "Hello World! Sample" y ejecutamos el botón para que nos muestre la búsqueda que hemos pedido. Por tanto, nuestro test debe terminar con éxito:

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step9.png)

# Integrar los test en nuestra app web

Tenéis varias opciones para crear el proyecto "webapp", en mi caso os he dejado todo en una sola solución debido a que yo lo estoy publicando en servidor IIS. Si no quieres tenerlo de esta forma, puedes crear una nueva solución y añadir el proyecto, así se ejecutará en IIS Express los test y la web app de forma independiente.

Comentado ese punto, vamos a crear la web app dentro de la solución:

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step10.png)

Del tipo ASP.Net Core:

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step11.png)

Y con el font-end en React.JS, podéis ver mi libro de React en https://github.com/jmfloreszazo/ebook:

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step12.png)

Vamos a probar que funciona correctamente. Establecemos el proyecto para que se inicie: 

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step13.png)

Ahora en mi caso realizo la publicación para tener on-line mi servidor de test con la aplicación web:

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step14.png)

En el caso que tengas dos soluciones, deberás lanzar la app web y volver a la solucione de UI Test.

Ya tenemos la web corriendo y publicada.

Ahora es el momento de instalar "Katalon Recorder (Selenium IDE for Chrome)".

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step15.png)

Una vez instalado, verá que tienes un nuevo icono en tu barra de Chrome:

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step16.png)

El IDE de Katalon, es muy sencillo, principalmente guarda los pasos que vamos realizando cuando interactuamos con la web app.

Como podrás observar, tiene la opción de "Start", "Stop", "Play”, ...  familiarízate con él. Una vez que lo tengas visto, continua con el tutorial.

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step17.png)

Como habrás podido averiguar, podemos exportar el contenido del test en diversos formatos, incluido MTest para C#. Aunque es buena opción para los novatos o para aquellos entornos que no hemos programado nosotros y queremos conocer los Ids de los controles de forma rápida, pero si la web app es nuestra, lo mejor es que uno mismo escriba los test. 

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step18.png)

Pues vamos a escribir un test para la Web App.

Lo primero será modificar el ejemplo para que podamos hacer algún tipo de validación propiamente dicha de un test:

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step19.png)

Y designamos a lo controles que deseamos testear con un Id.

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step20.png)

Al designarlos con un Id es más sencillo localizarlos cuando usamos el WebDriver de Selenium, es un ejemplo de toma de contacto, como podrás ver en la documentación del WebDriver, podemos hacer incluso búsquedas para traernos colecciones de objetos (ver documentación de Selenium https://www.seleniumhq.org/docs/)

En nuestro caso vamos a testear si puedo hacer clic en el botón y si al realizar varios clic el incremento tiene el valor que deseamos.

Lo primero que vamos a realizar es añadir una nueva clase de Test:

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step21.png)

Al igual que en el ejemplo de Hello World, vamos a renombrar la clase y añadir el siguiente código:

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step22.png)

Ejecutar los test y comprueba el resultado. ¿Sale todo en verde?

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step23.png)

Como pequeña nota, si nunca has lanzado test anteriormente, puedes incluso realizar una depuración sobre los test. Y si no te suena que es la directiva:

```cs
Assert.AreEqual(currentCounter, stopValue.ToString());
```
Pues empezar a estudiar los test unitarios desde: https://msdn.microsoft.com/es-es/library/dd264975.aspx

Como ves es muy simple ejecutar test de UI usando Selenium y el driver de Chrome.

# Integración con Docker

Ahora vamos a ir un paso más allá y vamos a intentar usar Docker para testear una DevBox con nuestra WebApp y así el departamento de QA pueda trabajar de una forma más estandarizada.

El primer paso, es entrar en y descargar la aplicación para Windows desde https://store.docker.com

Una vez instalado vamos a verificar que esté bien instalado.

Desde un terminal de PowerShell y ejecutamos el siguiente comando: `docker version` Y `docker run hello-world` para ver que Docker puede descargar y ejecutar imágenes.

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step24.png)

Perfecto, el primer paso está dado.

Como en este tutorial no está centrado en Docker, si no, en publicar una solución en Docker para hacer test de Selenium; por tanto vamos a clonar este proyecto: 

`git clone https://github.com/jmfloreszazo/aspnetappfordockertest`

Es un proyecto ASP.NET MVC, Ejecutalo. Se trata de otra versión de un contador de clicks:

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step25.png)

Y ahora es el momento de publicar nuestra aplicación web en Docker con el siguiente comando:

`Docker run --rm -it -p 8000:80 -v [path_local_clonado]\aspnetappfordockertest:/app/ -w /app/aspnetappfordockertest microsoft/dotnet:2.1-sdk dotnet watch run`

Donde `[path_local_clonado]` es la ruta donde ejecutaste `git clone`

Tras unos instantes, Docker arrancará:

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step26.png)

Ya puedes ir a tu navegador Chorme y en `localhost:8000` podrás acceder a tu aplicación web. Hemo redirigido el  puerto 8000 a la máquina de Docker.

Es una versión build.

Si entras en la solución "aspnetappfordockertest" podrás ver una carpeta llamada "Solutions Items". Cuyo contenido es el siguiente:

* `.dockerignore`: directiva para Docker que indica que carpeta no vamos a incluir; lo puedes complicar todo lo que desees.
* `Directory.Build.props`: para personalizar nuestro proyecto (https://docs.microsoft.com/es-es/visualstudio/msbuild/customize-your-build?view=vs-2017#directorybuildprops-and-directorybuildtargets)
* `Dockerfile`: es el proceso que hemos usado para automatizar Docker.

Y si los has revisado podrás observar la siguiente instrucción en `Dockerfile`:

`RUN dotnet publish -c Release -o out`
 
Es decir una `build` en toda regla.
 
Con Docker corriendo, regresamos a la solución "uitestwithseleniuminvisualstudio" y creamos un nuevo test:

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step27.png)

Lo lanzamos y efecticamente, ya hemos probado nuestra aplicación web en build.

# Selenium Grid

Lo usaremos para ejecuttar pruebas en diferentes navegadores y sistemas operativos.

Su arquitectura es muy simple: un hub y uno o más nodos.

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step28.png)

Ejecutas los test en un hub de docker y este hub distribuye el test en diferentes navegadores del hub.

La opción que yo uso es `Docker-Compose`, una herramienta para definir y ejecutar aplicaciones Docker multi-contenedor. 

Utiliza un archivo `YAML` para configurar los servicios de la aplicación. Y con un solo comando se crean e inicial los servicios.

Mediante un editor de texto vamos a crear el archivo: `docker-compose.yml`, con el siguiente contenido.

```yamlversion: '3'
services:
  firefox:
    image: selenium/node-firefox
    depends_on:
      - hub
    environment:
     HUB_HOST: hub
  chrome:
    image: selenium/node-chrome
    depends_on:
      - hub
    environment:
      HUB_HOST: hub
  hub:
    image: selenium/hub
    ports:
      - "4444:4444"
```

Una vez guardado el fichero, ya podemos poner en pie nuesto hub. En un terminal de `PowerShell`, nos situamos en la carpeta donde hemos creado el fichero YAML y ejecutamos:

```
docker-compose up -d
```
Vamos a ver como a ver que están en funcionamiento, por ejemplo, con unas estadísticas:

```
docker stats
```

o bien, abrir el navegador:

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step29.png)

Y para parar el hub solamente tenemos que hacer:

```
docker-compose down
```

Ahora vamos a clonar: 

`git clone https://github.com/jmfloreszazo/paralleluitestwithseleniuminvisualstudio`

Este proyecto ejecutará test en paralelo contra el nodo chrome y el nodo firefox.

Para ejecutar test en paralelo debemo marcar esta opción:

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step30.png)

Vamos a la carpeta del proyecto para lanzar:

```
docker-compose up -d
```

Y ahora es cuando vamos a ejecutar nuestros test:

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step32.png)

Si observais el código, os he puesto un pequeño tip: capturas de pantallas según va ejecutando el código.

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step31.png)

Ya hemos visto como ejecutar test en paralelo y si lo has ejecutado habrá visto que terminan los test con errores. Por supuesto, ya que uno de los test está conectando contra nuestra Web App alojada en Azure.

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step33.png)

De nuevo añadimos una proyecto web app MVC. Cuando termine la testearemos en Docker, pero esta vez vamos a crear las propiedades Docker desde el propio entorno de Visual Studio 2017.

Sigue los pasos de la primera parte de la imagen:

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step34.png)

Podrás ver que hemos creado un proyecto Docker asociado a nuestra WebApp, que aun mantenemos nuestro Selenium Grid (segunda imagen) en el proyecto de Test y que en la barra de herramientas nos poner un nuevo proyecto para ejecutar (imagen 3), en este caso lanza la web app, pero podemos editar el documento `docker-compose.yml` del proyecto Docker para que lancemos la web app, selenium hub y cuando esté levantado, lanzar los test. No voy a entrar en más detalles de Docker.

En el fujo de desarrollo, imaginar que estamos implementando una nueva funcionalidad, ya la has terminado, lanzado en el Docker `microsoft/dotnet` y tienes claro que es el momento de pasar los test de UI. 

La forma en que yo realizo este proceso es publicando nuestra web app en un servidor Web de test/dev. Y si no tengo uno ya creado, suelo publicarlo en Azure:

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step35.png)

Y accedemos al sitio que hemos creado para ver que funciona todo:

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step36.png)

Una vez que ya hemos publicado, nos toca lanzar los test. Añadiendo más información a nuestra configuración, podemos decirle a la aplicación donde está nuestro servidor de test:

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step38.png)

Llegó el momento de lanzar los Test:

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step37.png)

Perfecto, ya tenemos un flujo de trabajo donde lanzamos de forma parelela los test contra Chrome y Firefox en nuestra Web App.

El siguiente paso es incluir el Docker selenium/hub para que podamos validar los test y si procede publicar la release de nuestra web app.

# Integrar los Test UI en nuestro ciclo CI/CD

Todos los conocimientos anteriores los vamos a poner en juego para que nuestras releases tengan un punto más de seguridad al obligar a pasar los test de UI.

Los tests de UI son un filtro más hacia la excelencia.

Pongamonos manos a la obra.

Falta por terminar...

# Para finalizar...

Una pequeño truco.

Yo lo uso como una ayuda a la tediosa tarea de rellenar datos en un formulario web que debo completar para poder llegar a una nueva funcionalidad que estoy programando. Esta automatización, posteriormente la transformo en un test.
