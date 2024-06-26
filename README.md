# IMPLEMENTACIÓN DE UN SISTEMA DE BIBLIOTECA

![Library-Management-System-513656000](https://github.com/jd-becerra/Proyecto-ProgramacionParaWeb/assets/112126654/f6365c33-f6d5-45f3-bff7-4c7b1084d68e)

El caso que yo he elegido implementar involucra crear un sistema para llevar un control de los préstamos de los libros en una biblioteca. 

Con esto, sabemos que tenemos que registrar los libros que se encuentren disponibles (diferenciándolos con una ID única), registrando aspectos como su título, género, código ISBN, etc.
Después, necesitaremos registrar a los clientes que realizarán el préstamo de los libros. He decidido registrar su ID, dirección, nombre, teléfono y correo electrónico.
Ya creadas las tablas Cliente y Libro, nos disponemos a relacionarlas mediante una tabla para Préstamos, que tomarán la ID de un cliente y la ID de un libro para correlacionarlas junto con una fecha de inicio del préstamo, fecha de entrega, duración del préstamo en días y su estado de completado.
Además, añadiremos una tabla para registrar las posibles multas que un préstamo pueda tener si el libro no se regresó a tiempo.

El diagrama de la base de datos del sistema en su totalidad es el siguiente:


![image](https://github.com/jd-becerra/Proyecto-ProgramacionParaWeb/assets/112126654/9b8e752b-ab44-4bdd-b324-c010980c1a50)
