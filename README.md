# Prosa webinar - ASP.NET MVC

> Michell Cronberg (michell@cronberg.dk) - ult. september 2021

## Hent værktøj

- [Visual Studio Community](https://visualstudio.microsoft.com/vs/community/)
- [Visual Studio Code](https://code.visualstudio.com/)
  - [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)

## Hent repo

Kode, link, billeder mv kan finde i repo

```
https://github.com/devcronberg/prosamvc
```

Du kan evt enten hente repository som en zip ved at klikke på den store grønne Code-knap, eller clone det fra

```
https://github.com/devcronberg/prosamvc.git
```

Det kræver at du benytter en Git-klient (eksempelvis VSCode, Visual Studio, [Git for Windows](https://gitforwindows.org/).

## MVC skabelon

Du kan afprøve skabelon i Visual Studio (åbn \prosamvc\src\Prosa.MvcTemplate\Prosa.MvcTemplate.sln) eller gennem en konsol (kræver .NET SDK). Åbn en konsol i \prosamvc\src\Prosa.MvcTemplate\Prosa.MvcTemplate og skriv

```
dotnet run
```

For at arbejde under https skal der [udstedes](https://www.hanselman.com/blog/developing-locally-with-aspnet-core-under-https-ssl-and-selfsigned-certs) et certifikat.

## Demo App

- Server / Klient
  - Server baseret app
    - Web server
      - IIS
    - MVC, RubyOnRails, PHP, Spring...
  - Klient baseret app
    - statisk
    - frameworks
      - Angular, React, Vue
- HTTPs
  - chrome dev tool / fiddler
