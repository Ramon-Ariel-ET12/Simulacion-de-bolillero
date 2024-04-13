# Simulacion-de-bolillero
Tarea para el profesor luis duran


``` mermaid

classDiagram
direction lr

class Aleatorio{
    +Aleatoinator(Bolillero bolillero) int
}

class Bolillero{
    +List~int~ Bolillas
    +List~int~ BolillasSacadas
    +IAzar Azar

    -GenerarBolillas(int cantidad) List~int~
    +Jugar(List~int~ jugada) bool
    +JugarNVeces(int cantidad, List~int~ jugada) int
    +SacarBolilla() int
    +ReIngresar()
}

class FluentAleatorio{
    +Aleatoinator(Bolillero bolillero) int
}

class IAzar{
    ~~Interface~~
    Aleatoinator(Bolillero bolillero) int
}

class IClonable{
    ~~Interface~~
    ClonarBolillas(Bolillero bolillero) List~int~
    ClonarBolillasSacadas(Bolillero bolillero) List~int~
}

class Primero{
    +Aleatoinator(Bolillero bolillero) int
}

class Simulacion{
    List~int~ ClonBolillas
    +List~int~ ClonBolillasSacadas
    +IAzar Azar

    +ClonarBolillas(Bolillero bolillero) List~int~
    +ClonarBolillasSacadas(Bolillero bolillero) List~int~
    +simularSinHilos() long
    +simularConHilos() long
}

Bolillero --> IAzar : Asociación
Aleatorio ..|> IAzar : Realización
Primero ..|> IAzar : Realización
FluentAleatorio ..|> IAzar : Realización
Bolillero --> IClonable : Asociación
Bolillero --|> Simulacion : Herencia

```