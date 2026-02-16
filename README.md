# Proyecto de Gestión de Voluntariados 

Sistema de escritorio para la gestión y vinculación de voluntarios con actividades sociales organizadas por distintas entidades, alineado con los **Objetivos de Desarrollo Sostenible (ODS)**.

## Características Principales

* **Filtrado Dinámico**: Búsqueda de actividades en tiempo real mediante selectores de fecha (Inicio y Fin).
* **Gestión N:M**: Manejo de relaciones complejas entre Voluntarios, Habilidades, Intereses y ODS.
* **Visualización Detallada**: Al seleccionar una actividad, se muestran automáticamente:
    * Datos de contacto de la Organización responsable.
    * Listado de voluntarios inscritos en dicha actividad.
* **Arquitectura Robusta**: Separación de responsabilidades mediante el patrón de capas.

## Stack Tecnológico

* **Lenguaje:** C# (.NET Framework)
* **Interfaz:** Windows Forms (WinForms)
* **Base de Datos:** Microsoft SQL Server 2022
* **ORM:** Entity Framework (Database First / EDMX)
* **Control de Versiones:** Git

## Arquitectura del Sistema

El proyecto se divide en tres capas principales:

1.  **CapaPresentacion:** Interfaz de usuario y manejo de eventos dinámicos.
2.  **CapaDatos:** Gestión del contexto de base de datos (`PROYECTOINTEREntities`) y consultas mediante LINQ.
3.  **Entidades:** Clases que representan el modelo de datos del dominio.

## Instalación y Puesta en Marcha

### 1. Base de Datos
Ejecutar el script SQL proporcionado en **SQL Server Management Studio (SSMS)**. El script incluye:
* Creación de la base de datos `PROYECTOINTER`.
* Creación de tablas con integridad referencial (Claves Foráneas).
* Inserción de datos maestros (Ciclos, ODS, Habilidades).

### 2. Configuración del Proyecto
* Clonar el repositorio.
* Asegurarse de que el archivo `.gitignore` esté presente para evitar subir archivos temporales (`bin/`, `obj/`, `.vs/`).
* Configurar la cadena de conexión en el archivo `App.config` o en la clase `Gestion` para que coincida con tu instancia local de SQL Server.


---
**Desarrollado por:** Leyre Romero y Sergio De La Fuente 
**Curso:** 2024-2025 / 2025-2026  
**Entorno de ejecución:** Windows 10/11 + SQL Server 2022
