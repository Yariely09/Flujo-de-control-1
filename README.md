# 💰 Calculadora de ISR - República Dominicana

## 📌 Descripción del Proyecto
Este programa tiene como objetivo leer el sueldo de un empleado, calcular el ISR (Impuesto Sobre la Renta) y mostrar en pantalla el resultado correspondiente según la escala salarial vigente publicada por la Dirección General de Impuestos Internos (DGII) para la República Dominicana en el presente año.

El sistema determina automáticamente si el empleado debe pagar ISR o si no aplica impuesto, mostrando **N/A** cuando corresponda.

---

## 🎯 Objetivo
Desarrollar un programa que:

- Lea el sueldo de un empleado.
- Calcule el ISR según las escalas salariales oficiales de la DGII.
- Muestre en pantalla:
  - Sueldo ingresado.
  - Monto a pagar por ISR.
  - Si no aplica impuesto, mostrar **N/A**.

---

## 🛠️ Tecnologías Utilizadas
- Lenguaje de programación: **C#**
- Entorno de desarrollo: **Visual Studio**
- Control de versiones: **Git**
- Repositorio: **GitHub**

---

## 📊 Escala Salarial (ISR - República Dominicana)

El cálculo del ISR se realiza según los tramos salariales establecidos por la DGII.

| Rango Salarial Anual | ISR Aplicable |
|----------------------|---------------|
| Hasta RD$416,220.00 | Exento |
| RD$416,220.01 - RD$624,329.00 | 15% del excedente |
| RD$624,329.01 - RD$867,123.00 | 20% del excedente |
| Más de RD$867,123.00 | 25% del excedente |

> ⚠️ Los valores fueron investigados según la escala vigente publicada por la DGII para este año.

---

## ⚙️ Funcionamiento del Programa

1. El usuario introduce el sueldo del empleado.
2. El programa evalúa el rango salarial correspondiente.
3. Se calcula automáticamente el ISR.
4. Se muestra en pantalla:
   - Sueldo ingresado.
   - ISR calculado o **N/A** si está exento.

---

## ▶️ Ejecución del Programa

Ejemplo de salida en consola:
escenario 1 excento del ISR
<img width="985" height="439" alt="image" src="https://github.com/user-attachments/assets/2aa51ce4-5c88-47d6-9604-dd0a994cd520" />

escenario con impuesto :

<img width="974" height="360" alt="image" src="https://github.com/user-attachments/assets/fd279ff2-2edc-4c9c-8c80-d19ea8c56ca7" />

### Datos del autor:
Yariely Severino Baez
Matricula: 2025-0747


