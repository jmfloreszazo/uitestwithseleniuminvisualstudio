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

![](https://github.com/jmfloreszazo/uitestwithseleniuminvisualstudio/blob/master/readmeimages/Step62.png)


# Integrar los test en nuestra app web

# Integración con Docker
