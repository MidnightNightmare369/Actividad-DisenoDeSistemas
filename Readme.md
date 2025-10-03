# Actividad diseño de sistemas 2025-2

### Enunciado
Realizar un proceso de diseño de un prototipo mediante una IA generativa, en cual se genere la Historia de usuario, con la definición de requerimientos, con requisitos funcionales y no funcionales.
Generar con la IA diagramas que considere para este proposito en UML y genere tambien el codigo. En lo posible que el prototipo diseñado pueda correr en un IDE.
El tema del diseño es a libre elección (Ej: gestor de inventario, Entrada - salida; Sistema de presupuesto de servicio; un sistema de adopción de mascotas etc.


## Desarrollo

Para el desarrollo de la actividad se uso Chat-GPT en su versión actual. 
(Las respuestas completas de la IA dado que algunas son muy largas,  estas estarán completas en el archivo respuestas.txt)

#### Prompt #1
Actua como un ingeniero en sistemas experto en diseños de sistemas y software. Mi profesor de diseño de sistemas de informacion me dejo la siguiente tarea [Realizar un proceso de diseño de un prototipo mediante una IA generativa, en cual se genere la Historia de usuario, con la definición de requerimientos, con requisitos funcionales y no funcionales. Generar con la IA diagramas que considere para este proposito en UML y genere tambien el codigo. En lo posible que el prototipo diseñado pueda correr en un IDE. El tema del diseño es a libre elección (Ej: gestor de inventario, Entrada - salida; Sistema de presupuesto de servicio; un sistema de adopción de mascotas etc.]. Ten en cuenta esta tarea e indicaciones para los prompts que vienen a continuación. Indicaciones: Mantenlo simple.
**Respuesta**: 

---
Pensó durante 5s

Perfecto — ya lo guardé y lo tendré en cuenta para todos los prompts que sigas enviando sobre esta tarea. ✅

Resumen rápido de lo que guardé (para que sepas exactamente lo que recordaré):

-   Objetivo: diseñar un prototipo mediante IA generativa.
    
-   Entregables: historia(s) de usuario; definición de requerimientos; requisitos funcionales y no funcionales; diagramas UML relevantes; y código (preferiblemente ejecutable en un IDE).
    
-   Restricción de estilo: mantenerlo simple y sencillo.
    
-   Tema: libre elección (ej.: gestor de inventario, control entrada/salida, sistema de presupuesto de servicio, sistema de adopción de mascotas, etc.).
    

Dime cómo quieres continuar:

-   ¿Quieres que elija un tema y empiece a generar todo el prototipo completo ahora (historia de usuario, requisitos, UML y código ejecutable)?
    
-   ¿O prefieres que empecemos paso a paso (por ejemplo primero la historia de usuario y requisitos, luego los diagramas, luego el código)?
    

Elijo un tema por defecto si no dices nada: ¿te parece bien un **gestor de inventario básico**? (es simple, enseña bien los conceptos y el código puede correr fácilmente en un IDE).

---

#### Prompt #2
Genera una historia de usuario para un sistema de registro de vehículos, correspondiente a una empresa dedicada al alquiler de vehículos.

**Respuesta**: 

---
Aquí tienes una historia de usuario simple y clara para un sistema de registro de vehículos de una empresa de alquiler de vehículos:

Historia de Usuario

Título: Registro de nuevos vehículos en el sistema

Como administrador de la empresa de alquiler de vehículos
Quiero registrar nuevos vehículos en el sistema con sus datos principales (marca, modelo, año, placa, estado y tipo de vehículo)
Para mantener actualizado el inventario de la flota y poder gestionarlos en los procesos de alquiler y devolución.

Criterios de Aceptación

El sistema debe permitir ingresar datos obligatorios del vehículo: placa, marca, modelo, año, estado (disponible, en mantenimiento, alquilado) y tipo (automóvil, camioneta, motocicleta, etc.).

El sistema debe validar que la placa no esté repetida dentro de la base de datos.

Al completar el registro, el vehículo debe quedar disponible en la lista de flota activa.

El sistema debe permitir consultar y editar posteriormente la información registrada del vehículo.

¿Quieres que te siga generando los requerimientos funcionales y no funcionales para este mismo sistema de registro de vehículos?

---

#### Prompt #3
A partir de la historia de la historia de usuario generada en la respuesta anterior genera un diagrama de clases UML. En formato .png o .jpg. Piensa demás si es necesario.

**Respuesta**: 

---
Analizado
[....]
Aquí tienes el diagrama de clases UML en formato .png para el sistema de registro de vehículos:
📂 Descargar diagrama de clases UML - Registro de Vehículos (.png)

¿Quieres que además lo exporte también en .jpg para que tengas ambas versiones?

---
**Imagen entregada:**

<img width="255" height="636" alt="uml_registro_vehiculos" src="https://github.com/user-attachments/assets/e1edd298-6a1e-44a0-8dcb-7362b178b692" />

---
