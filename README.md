# RootBrain

## Equipo i35 

Integrantes

* <https://github.com/rhofp>
* [Pablo Lobato Ceballos UNAM](https://github.com/alpercon)
* [Emanuel Flores Martínez UNAM](https://github.com/emanuelFI)
* [Martín Maceda Nazario UNAM](https://github.com/martino2197)

* [H. Galileo Cabrera Garibaldi UNAM](https://github.com/galigaribaldi)
* [Andrea García Ruíz UNAM](https://github.com/andreaagr)

## Git Workflow (flujo de trabajo de git)

ANTES DE CLONAR ÉSTE REPOSITORIO Y EMPEZAR A CONTRIBUIR EN ÉL FAVOR DE LEER LA ESTRUCTURA DE TRABAJO COLABORATIVO QUE SE PLANEA. La estructura planeada en  [workflow.md](./planeacion/workflow.md) nos ayudará a evitar conflictos entre las versiones de nuestro proyecto. 

La estructura de trabajo propuesta fue inspirada en manera de trabajar de [Wunnar Wolf](https://github.com/gwolf) y del estándar de trabajo generado por desarrolladores de todo el mundo en donde se tienen 4 ramas principales, las cuales se detallan en el documento mencionado previamente.

## Roles de los integrantes y calendarización

Es **IMPORTANTE**  revisen semanalmente ( o quizá en un periodo menor) el [calendario](./planeacion/README.md) de actividades ya que en este se pondrían fechas de entregables así como los responsables dicho entregables.

<!--### Minutas-->

<!--Otra parte esencial para el proyecto es informar a los que no pudieron asistir a las juntas lo que se dijo. Para ello se escribirán minutas los más corto posible con los acuerdos a los que se llego ese día en particular.-->

<!--La secuencia para hacer minutas será `Rodrigo, Emanuel, Pablo, Martín.` -->

### Juntas PRESENCIALES

Nos reuniremos TODOS los viernes a las 11:30. Salvo que alguien tenga alguna mejor sugierencia, si es el caso haganmelo saber.

## Tema Salud

Tema específico: Neurociencias

## Objetivos

Promover e interesar a los usuarios de nuestra aplicación sobre temas de corte científico relacionados principalmente con la salud, particularmente abordaremos el tema de las *neurociencias*.

## Descripción general

La aplicación busca que los usuarios se interesen por las neurociencias y por la salud en general. Nuestra aplicación difunde el gusto por las neurociencias desde tres puntos de vista.	

* Información interesante sobre enfermedades, conceptos y demás sobre las neurociencias.
  * Datos curiosos sobre algún tipo de información relacionada con las neurociencias.
* Recomendaciones para que el usuario cuide su salud de mejor manera.
  * Dichas recomendaciones serán enviadas a través de notificaciones.
* Retos que permitan estimular y ejercitar sus habilidades cognitivas.
  * Dichos retos irán a corde a la función o habilidad que alguna parte del cerebro se encargue. Por ejemplo, el lóbulo frontal es el encargado de la memoria, entonces podemos poner un juego en donde el usuario ejericite su memoria (algo así como un memorama o cosas por el estilo).
  * A medida que vaya ganando los retos se irán desbloqueando nuevos retos.

En la vista principal de nuestra aplicación se muestra el cerebro el 3D, algo similar a la imagen de abajo.

![animacion tomada de wikipedia](./img/brain_anim.gif)

### Modos de la aplicación

* Modo informativo
* Modo reto

### Funcionamiento de la aplicación

Cada parte del cebrero debe responder a un evento al hacer click sobre él. El disparo del evento depende del modo en que estemos. 

* Si estamos en el *modo reto* y hacemos click en el lóbulo frontal se nos mandará a un reto (o juego) que nos ayude a ejercitar dicha parte del cerebro.
* Si estamos en *modo informativo* se nos mostrará información sobre alguna parte del cerebro, enfermedades relacionadas con él, etc. 

Además, se enviarán notificaciones al usuario con recomendaciones para mantenerse saludable.

## Plataforma

*RootBrain* esta siendo desarrollado actualmente con **React native**, un framework que permite el desarrollo multiplataforma. La aplicación se podrá ejecutar en 

* Android
* iOS

## Tecnologías

A la fecha (*abril de 2019*) este proyecto se realiza con 

* react-native 0.59
* blender 2.76

## Arquitecturas del software

¿Algunas propuesta sobre el tipo de arquitectura de software o patrón de diseño a implementar?

## Licencia

Por definir.