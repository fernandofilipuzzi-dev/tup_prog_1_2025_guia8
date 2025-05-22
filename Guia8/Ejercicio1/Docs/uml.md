```mermaid
graph TD
    A[Procesar Números]
    
    A --> A1[Iniciar contador y acumulador]
    A --> A2[Solicitar Cantidad de ingresos]
    A --> A3[Iterar Ingresos *]
    A --> A4[Verificar si hay números]
    A --> A5[Mostrar máximo, mínimo, promedio]

    A3 --> B1[Verificar continuar si hay ingreso]
    A3 --> B2[Solicitar Valor]
    A3 --> B3[Acumular valor]
    A3 --> B4[Verificar valor es máximo o primer ingreso]
    A3 --> B5[Verificar valor es mínimo o primer ingreso]
    A3 --> B6[Contar ingreso]

    B4 --> C1[Actualizar máximo con valor ingresado  o]
    B4 --> C2[o]
    B5 --> D1[Actualizar mínimo con valor ingresado o]
    B5 --> D2[o]

    A4 --> E1[Calcular promedio]
    A5 --> E2[/\ Mostrar valores /]
```