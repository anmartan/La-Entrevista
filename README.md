# Descripción

La Entrevista es un juego serio basado en una aventura gráfica que relata la historia de una mujer que se presenta a una entrevista de trabajo, para un puesto de desarrollador junior. En el camino, encontrará situaciones sexistas, que la harán reaccionar de diferentes maneras.

La condición de mujer no se revelará hasta el final del juego, para reforzar el mensaje que se quiere enviar: el sexismo en el entorno laboral pasa muchas veces desapercibido, pero existe. Hasta ese momento, se emplea un lenguaje neutro, para no desvelar el género de la protagonista.
El juego está completamente desarrollado mediante [uAdventure](https://github.com/e-ucm/uAdventure/releases), una herramienta implementada en Unity para mejorar el desarrollo de juegos narrativos. 

# Jugabilidad
## Mecánicas
* Click izquierdo del ratón: sirve para interactuar con el mundo. Esto incluye:
* Hablar con personas.
* Interactuar con objetos.
* Moverse entre escenas.

## Dinámicas

### Objetivo principal
Como jugador, el objetivo principal del juego es llegar a la entrevista de trabajo. En el camino, encontrará situaciones en las que se denigra a la protagonista de diversas maneras.
Posteriormente, se lanzan una serie de preguntas al jugador, para que evalúe los comportamientos sexistas que ha vivido, y los identifique como tal.

### Ganar/Perder
No existe un concepto de ganar o perder en este juego. Lo que se intenta desde el principio es exponer al jugador a una situación de sexismo, que vivirá en primera persona, y con una completa indefensión.

Por tanto, la partida está pensada para que el jugador pueda llegar hasta el final, independientemente de sus elecciones.

De igual manera, en las preguntas que se hacen después del juego, no hay puntuación ni se penaliza que se escoja una respuesta equivocada. 
### Estética
Se usan elementos 2D que representen lo mejor posible la realidad.

## Contenido

### Protagonista
Es controlada por el jugador. Es una recién graduada en el grado de Desarrollo de Videojuegos, y está animada por una entrevista de trabajo en una empresa importante. A medida que pasa el día, su irritación crece, en la misma proporción que su ilusión desaparece.

### Personajes “activos”

Nos referimos en esta parte a todos los personajes que el jugador verá, y con los que puede mantener una conversación directa. Las respuestas del jugador a los comentarios de estos personajes afectan al flujo de la conversación.

* Portero

		Aparece en el hall del edificio. Cuando el jugador le pregunta por las entrevistas de trabajo, confunde a la protagonista por una candidata para un puesto de secretaria. 

* Hombre 1 (Luis)

		Aparece en la sala de espera. Cuando el jugador llega a la sala de espera por primera vez, confunde a la protagonista con la mujer del CEO de la empresa.

* Hombre 2 (Antonio)

		Aparece en la sala de espera. Explica al jugador que no le gusta pasar tiempo en casa porque no sabe hacer tareas domésticas, y prefiere dejar esa responsabilidad a su pareja.

* Hombre 3 (Jaime) 

		Aparece en la sala de espera. Se enfada con el jugador cuando se entera de que también se va a presentar a la entrevista de trabajo. Piensa que van a contratar al jugador por el mero hecho de ser mujer.

* Recursos Humanos (Andrés)

		Aparece en la sala de entrevistas. Aunque se muestra cordial, a lo largo de la entrevista hace preguntas inapropiadas, y las intenta argumentar para que no parezcan inadecuadas.

* Recursos Humanos (Luisa)

		Aparece en la sala de entrevistas. Cuando intenta hacer preguntas al jugador, Andrés le toma el relevo y le impide hablar. Es la encargada de tomar todas las notas relevantes durante la entrevista. 

### Personajes “pasivos”

Nos referimos en esta parte a todos los personajes que el jugador verá, pero con los que no puede hablar directamente. Al intentar interactuar con ellos, el jugador puede escuchar la conversación que mantienen entre ellos. 

Hacemos referencia a ellos por los grupos en los que interactúan.

* Grupo 1 (Hombre - Hombre)

		Aparece en la sala de café. Hablan de las pocas mujeres que hay en las oficinas, y de que muy pocas se han presentado a la entrevista. Entre bromas, insinúan que las mujeres no se presentan a estos puestos porque no tienen los conocimientos necesarios y que, si lo hicieran, solo ralentizarían el ritmo de trabajo por distraer a los compañeros.

* Grupo 2 (Hombre - Mujer - Hombre)

		Aparece en la sala de café. Al principio son solo uno de los hombres y la mujer. El hombre está exponiendo un problema que tiene en el trabajo, y cuando la mujer le da consejo, él lo rechaza. En ese momento aparece el otro hombre, y le propone la misma solución. Esta vez, el consejo es aceptado.

## Desarrollo de la partida

El juego comienza con una escena que pone en contexto al jugador. El jugador busca ofertas de trabajo, de acuerdo a su perfil. Cuando encuentra una oferta que le convence, se dirige a la entrada del edificio donde se harán las entrevistas.

Ahí, puede pedir indicaciones al portero. Cuando ha hablado con él, puede ir a la sala de espera.

En la sala de espera, le aborda uno de los hombres, y le habla, confundiendo al jugador con la pareja del CEO de la empresa. Después, el jugador puede hablar con cada uno de los personajes que hay en la sala de espera, o moverse a la sala de café en cualquier momento.

Allí, puede escuchar las conversaciones de ambos grupos, y volver a la sala de espera. Puede repetir estos movimientos siempre que quiera.

Una vez ha visitado ambos escenarios, puede entrar en la sala de entrevistas para empezar el proceso. Al principio, la entrevista es amena, pero poco a poco, las preguntas se vuelven más retorcidas, y el ambiente, más tenso.

# Diálogos

El pilar central del juego son sus diálogos. Todos están recogidos en [este documento](https://drive.google.com/file/d/1nto5wUZqxVPlPrgt6VTULZZMo-6Teof-/view?usp=sharing).

También se incluyen, en ese mismo documento, las preguntas que se hacen después de haber terminado el juego, y la explicación que se da al jugador posteriormente.
