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

Ahora descargamos la imagen de `microsoft/dotnet`:

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step25.png)

Arrancamos y vemos que en el bash podemos ejecutar algun comando:

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step26.png)

Salimos y paramos la máquina:

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step27.png)

Creamos un fichero `Dockerfile` en el proyecto de "webapp" con el siguiente contenido:

```
FROM microsoft/dotnet AS build

FALTA ....

```

Y lo ejecutamos en PowerShell:

Solo te queda entrar en el navegador local y verás que ....

En el fichero `Dockerfile`

Este punto está en edición. En breve podrás leerlo.
