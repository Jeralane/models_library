models_library
=============

A simple C# - MySQL ORM

This class library aims to facilitate C# (WPF) projects that uses MySQL database.

Highlights:
* A DatabaseController class that execute SQL commands
  - Configurable database settings (password is encrypted)
* An AbstractModel that is a superclass of all model classes
  - Contains virtual Create, Read Update and Delete (CRUD) methods
* A ModelCreator class that auto-generate model class based on an existing MySQL table
  - Facilitates class creation which properties are defined based on target table's columns
