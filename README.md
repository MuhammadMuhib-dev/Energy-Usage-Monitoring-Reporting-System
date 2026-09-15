# Energy Usage Monitoring & Reporting System

Turning a messy pile of spreadsheets into a real, reliable reporting system.

<!--[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](LICENSE)
[![Status](https://img.shields.io/badge/status-active-brightgreen.svg)]()-->

---

## Overview

An entire energy resource department was running its operations on dozens of Excel spreadsheets. Data was entered manually every day, with the same values copied and re-copied across files. There was no single source of truth, no reliable way to spot trends, and no confidence in the numbers.

This project replaces that spreadsheet-based workflow with a desktop application designed around a proper relational database — built for accuracy, consistency, and reporting at scale.

---

## Problem Statement

- Data entry was manual, repetitive, and error-prone.
- The same records were duplicated across multiple spreadsheets.
- There was no centralized, trustworthy data source.
- Identifying trends or generating reports required significant manual effort.

---

## Solution

The system was built in four stages:

1. **Data analysis** — Studied how raw energy data flowed and repeated across existing spreadsheets before writing any code.
2. **Deduplication** — Identified and removed redundant entries at the source rather than carrying them forward.
3. **Normalization** — Restructured the data into a clean, consistent, logical schema.
4. **Database design** — Built a scalable, server-friendly schema suited for real reporting, not just storage.

The result is a system that handles data validation and consolidation automatically, producing reports that are accurate and trustworthy by default.

---

## Features

| Feature | Status |
|---|---|
| Automated import from legacy spreadsheets | Complete |
| Duplicate detection and cleanup | Complete |
| Normalized relational database schema | Complete |
| Report generation (daily / weekly / monthly) | In progress |
| Analytics dashboard | Planned |
| Export to PDF / Excel | Planned |

---

## Tech Stack

| Layer | Technology |
|---|---|
| Language | *e.g. Python / C# / Java* |
| Database | *e.g. SQLite / PostgreSQL / SQL Server* |
| UI Framework | *e.g. WinForms / Tkinter / Electron* |
| Other Libraries | *ORM, parsers, etc.* |

---

<!--
## Installation

```bash
git clone https://github.com/yourusername/your-repo.git
cd your-repo
pip install -r requirements.txt
```
-->

<!--
## Usage

```bash
python main.py
```

---
-->

## Roadmap

- [ ] Report export (PDF / Excel)
- [ ] Web-based analytics dashboard
- [ ] Multi-user access control


---

## Developer comments

One of the biggest challenges I faced early on was understanding the existing data itself. The Excel workbook wasn't just a single sheet. It had multiple sheets that were all linked together, where data in one sheet depended on values in another. On top of that, a lot of columns had missing or null values, which made it hard to tell what was actually missing versus what was just entered inconsistently.

It took a good amount of time just to trace how the data moved between these sheets and understand the real relationships behind what looked like a simple spreadsheet at first. Looking back, this step was actually the most important part of the whole project. If I had skipped it and jumped straight into building the database, I would have carried all those same inconsistencies and gaps into the new system.

This experience taught me that when you're working with real world data, understanding it properly takes patience, and that patience pays off later when the actual development becomes much smoother.
## License

Licensed under the [MIT License](LICENSE).

## Contributing

Contributions are welcome. Please open an issue to discuss proposed changes before submitting a pull request.


## Author

**[Muhammad Muhib]**
[LinkedIn](#) · [Portfolio](#) · [Email](#)
