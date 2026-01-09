[![Build (Windows)](https://github.com/SAM-BIM/SAM_Mollier/actions/workflows/build.yml/badge.svg?branch=master)](https://github.com/SAM-BIM/SAM_Mollier/actions/workflows/build.yml)
[![Installer (latest)](https://img.shields.io/github/v/release/SAM-BIM/SAM_Deploy?label=installer)](https://github.com/SAM-BIM/SAM_Deploy/releases/latest)

# SAM_Mollier

<a href="https://github.com/SAM-BIM/SAM">
  <img src="https://github.com/SAM-BIM/SAM_Mollier/blob/master/Grasshopper/SAM.Analytical.Grasshopper.Mollier/Resources/SAM_Mollier.png"
       align="left" hspace="10" vspace="6">
</a>

**SAM_Mollier** is part of the **SAM (Sustainable Analytical Model) Toolkit** —  
an open-source collection of tools designed to help engineers create, manage,
and process analytical building models for energy and environmental analysis.

This repository provides **psychrometric (Mollier) chart utilities**
used to evaluate and visualise moist air thermodynamic behaviour.
It supports the creation of psychrometric points and the simulation of
common air-conditioning processes such as heating, cooling,
adiabatic humidification, and isothermal humidification.

A key characteristic of this module is the use of **Grasshopper as a visual user interface**,
enabling interactive, parametric exploration of psychrometric processes
and offering an intuitive workflow for both professional practice and education.

Welcome — and let’s keep the open-source journey going. 🤝

---

## Features

- Generation and visualisation of Mollier (psychrometric) charts
- Creation and manipulation of psychrometric state points
- Simulation of common HVAC air processes:
  - heating and cooling
  - adiabatic humidification
  - isothermal humidification
- Interactive Grasshopper-based workflow
- Integration with SAM analytical models

---

## Resources
- 📘 **SAM Mollier Wiki:** https://github.com/SAM-BIM/SAM_Mollier/wiki  
- 📘 **SAM Wiki:** https://github.com/SAM-BIM/SAM/wiki  
- 🧠 **SAM Core:** https://github.com/SAM-BIM/SAM  
- 🧰 **Installers:** https://github.com/SAM-BIM/SAM_Deploy  

---

## Installing

To install **SAM** using the Windows installer, download and run the  
[latest installer](https://github.com/SAM-BIM/SAM_Deploy/releases/latest).

Alternatively, you can build the toolkit from source using Visual Studio.  
See the main repository for details:  
👉 https://github.com/SAM-BIM/SAM

---

## Development notes

- Target framework: **.NET / C#**
- Psychrometric calculations follow SAM-BIM analytical modelling conventions
- Grasshopper components provide the primary user interface
- New or modified `.cs` files must include the SPDX header from `COPYRIGHT_HEADER.txt`

---

## Licence

This repository is free software licensed under the  
**GNU Lesser General Public License v3.0 or later (LGPL-3.0-or-later)**.

Each contributor retains copyright to their respective contributions.  
The project history (Git) records authorship and provenance of all changes.

See:
- `LICENSE`
- `NOTICE`
- `COPYRIGHT_HEADER.txt`
