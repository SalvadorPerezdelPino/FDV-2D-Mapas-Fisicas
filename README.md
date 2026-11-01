# Introducción a Unity 2D - Físicas y Tilemaps
## Actividades a realizar
> Partiendo de la escena implementada para la tarea de Sprites  construiremos un mapa de juego, que delimitará la zona en la que tendrá lugar la acción. Utiliza los recursos en el paquete generado para la práctica. Debes crear una paleta con los Tiles que consideres. Ajusta el tamaño de los Tiles al tamaño de celda del grid y subdivide aquellos Tiles que ocupen un grupo de celdas. Generar un mapa convencional que represente el entorno y límites de juego.

Primero, se ha importado el tilesheet ofrecido en el campus, aplicando las opciones correspondientes para evitar la compresión de las imágenes.

Tras esto, se ha observado que el slice automático no separa bien los tiles.

![Automatic Slice](./Media/automatic_slice.png)

Por lo que, se ha optado por la opción de dividir por número de píxeles. En este caso, coincide que son tiles de 64x64 píxeles. El PPU también se ha configurado a 64 para que cada tile ocupe una unidad del mundo.

![Grid Slice](./Media/grid_slice.png)

Para generar el mapa, me he centrado en los elementos que podrían formar un fondo simple: el suelo con hierba, piedras, tierra, etc. Estos sprites los he colocado en la paleta para convertirlos a tiles y de esta manera quedan separados de otros tiles que podrían tener otra funcionalidad.

![Tile Palette](./Media/tile_palette.png)

Con las herramientas de pintura de tiles en el mundo, se ha creado un tilemap Background para dibujar el mapa y se ha generado el contorno donde se moverá el jugador. Junto con el tilemap, se ha creado automáticamente un Grid.

![Map](./Media/map.png)