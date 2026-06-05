Para desabilitar la detección horizontal, en el objeto "XR" Origen, en el componente "AR Plane Manager" ajuste el "Direction Mode" a solo vertical

Primero he duplicado el último boton en el scroll de objetos.
He generado un prefab simple de un cubo 3d. He Añadido mi prefab "CuboDiego" al ObjectSpawner de XR Origen
He creado un scrip(Assets>MobileArTemplateAssets>Scripts) Object_controller que se encarga de destruir al objeto al pasar 5 segundos.

Se ha añadido al scrip un movimiento perpetuo hacia la derecha en el eje del cubo

Se ha añadido un nuevo boton a la interfaz gui
Se le ha añadido una etiqueta única al prefab("CuboDiego")
Se ha modificado el scrip de ejemplo de los materiales del ejercicio anterior para que el color se escoja de forma aleatoria y que se aplique a todos los objetos con las etiqueta("CuboDiego")