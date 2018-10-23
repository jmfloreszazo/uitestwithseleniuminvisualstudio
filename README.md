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

En el caso que tenas dos soluciones, deberás lanzar la app web y volver a la solucione de UI Test.

Ya tenemos la web corriendo. Ahora es el mommento de instalar "Katalon Recorder (Selenium IDE for Chrome)"

Una vez instalado, verá que tienes un nuevo icono en tu barra de Chrome:






# Integración con Docker
