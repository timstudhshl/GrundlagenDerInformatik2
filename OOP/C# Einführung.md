# Einführung und Grundaufbau C\#

## Inhaltsverzeichnis

- [Variablen](#variablen)
- [Methoden](#methoden)

## Variablen

### Aufbau

```c#
sichbarkeit datentyp variablenname = wert; 
```

### Beispiel

```c#
private string name = "Hans Müller";
```

## Methoden

### Aufbau

```c#
sichbarkeit rückgabeparameter Methodenname(datentyp eingabeparameter) 
{
    // Methodenkörper, eigentlich logik der Methode
}
```

### Beispiel

```c#
public void BeispielMethode(string name) 
{
    Console.WriteLine($"Hallo {name}");
}
```
