# C# Uninitialized Property Bug

This repository demonstrates a common, yet subtle, bug in C# related to uninitialized properties.  When you access a class property before it has been assigned a value, it will not necessarily throw an exception, but instead return the default value of the property's type. This can lead to hard-to-debug issues.

## The Problem

The `bug.cs` file showcases the issue. The `MyProperty` is an integer which is not initialized in the constructor.  When `MyMethod` tries to print the value of `MyProperty`, it prints 0 (the default value for an integer) rather than throwing an exception.

## The Solution

The `bugSolution.cs` file demonstrates the solution. It explicitly initializes `MyProperty` in the constructor, preventing the unexpected behavior.  Alternatively, the property could be assigned a value before access within the `MyMethod` function itself.