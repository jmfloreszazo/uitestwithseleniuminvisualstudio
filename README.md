# UI test con Selenium en Visual Studio

A continuación voy a mostrar como utilizar Visual Studio 2017 para realizar test de UI con Selenium.

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

Es posible quedebas configurar las opciones de aqruitectura del procesador:

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step7.png)

Una vez modificadas, vamos a lanzar de nuevo nuestros Test:

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step8.gif)

Como podrás haber observado en la anterior animación, estamos lanzando una sesión de Chrome a la url https://www.google.com/ donde localizamos la caja de busqueda e introducimos "Hello World! Sample" y ejecutamos el botón para que nos muestre la busqueda que hemos pedido. Por tanto nuestro test debe terminar con éxito:

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step9.png)

# Integrar los test en nuestra app web

Teneis varias opciones para crear el proyecto "webapp", en mi caso os he dejado todo en una sola solución debido a que yo lo estoy publicando en servidor IIS. Si no quires tenerlo de esta forma, puedes crear una nueva solución y añadir el proyecto, así se ejecutará en IIS Express los test y la web app de forma independiente.

Comentado ese punto, vamos a crear la webapp dentro de la solución:

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step10.png)

Del tipo ASP.Net Core:

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step11.png)

Y con el font-end en React.JS, podeir ver mi libro de React en https://github.com/jmfloreszazo/ebook:

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step12.png)

Vamos a probar que funciona correctamente. Establecemos el proyecto para que se inicie: 

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step13.png)

Ahora en mi caso realizo la publicación para tener on-line mi servidor de test con la aplicación web:

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step14.png)

En el caso que tengas dos soluciones, deberás lanzar la app web y volver a la solucione de UI Test.

Ya tenemos la web corriendo y publicada.

Ahora es el mommento de instalar "Katalon Recorder (Selenium IDE for Chrome)".

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step15.png)

Una vez instalado, verá que tienes un nuevo icono en tu barra de Chrome:

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step16.png)

El IDE de Katalon, es muy sencillo, principalmente guarda los pasos que vamos realizando cuando interactuamos con la web app.

Como podrás observar, tiene la opción de "Start", "Stop", "Play",...  familiarizate con el. Una vez que lo tengas visto, continua con el tutorial.

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step17.png)

Como habrás podido averiguar, podemos exportar el contenido del test en diversos formatos, incluido MTest para C#. Aunque es buena opción para lo novatos o para aquellos entornos que no hemos programado nosotros y queremos conocer los Ids de los controles de forma rápida, pero si la web app es nuestra, lo mejor es que uno mismo escriba los test. 

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step18.png)

Pues vamos a escribir un test para la Web App.

Lo primero será modificar el ejemplo para que podamos hacer algun tipo de validación propiamente dicha de un test:

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step19.png)

Y designamos a lo controles que deseamos testear con un Id.

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step20.png)

Al designarlos con un Id es más sencillo localizarlos cuando usamos el WebDriver de Selenium, es un ejemplo de toma de contacto, como podrás ver en la documentación del WebDriver, podemos hacer incluso búsquedas para traernos colecciones de objetos (ver documentación de Selenium https://www.seleniumhq.org/docs/)

En nuestro caso vamos a testear si puedo hacer click en el botón y si al realizar varios click el incremento tiene el valor que deseamos.

Lo primero que vamos a realizar es añadir una nueva clase de Test:

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step21.png)

Al igual que en el ejemplo de Hello World, vamos a renombrar la clase y añadir el siguiente código:

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step22.png)

Ahora podrás ejecutar los test, como pequeño nota, si nunca has lanzado test anteriormente, puedes incluso realizar un debugg sobre ellos:

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step23.png)

Como ves es muy simple ejecutar test de UI usando Selenium y el driver de Chrome.

# Integración con Docker

Ahora vamos a ir un paso más allá y vamos a intentar usar Docker para testear una DevBox con nuestra WebApp y así el departamento de QA pueda trabajar de una forma más estandarizada.

Este punto está en edición. En breve podrás leerlo.
