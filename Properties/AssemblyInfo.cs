﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#if EXILED
using RolePlay_Tools;
#else
using RolePlay_Tools_NW;
#endif

// Ogólne informacje o zestawie są kontrolowane poprzez następujący 
// zestaw atrybutów. Zmień wartości tych atrybutów, aby zmodyfikować informacje
// powiązane z zestawem.
#if EXILED
[assembly: AssemblyTitle("KomendyNarracyjne")]
#else
[assembly: AssemblyTitle("RolePlay-Tools-NW")]
#endif
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("!CBX")]
[assembly: AssemblyProduct("KomendyNarracyjne")]
[assembly: AssemblyCopyright("Copyright 2020")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Ustawienie elementu ComVisible na wartość false sprawia, że typy w tym zestawie są niewidoczne
// dla składników COM. Jeśli potrzebny jest dostęp do typu w tym zestawie z
// COM, ustaw wartość true dla atrybutu ComVisible tego typu.
[assembly: ComVisible(false)]

// Następujący identyfikator GUID jest identyfikatorem biblioteki typów w przypadku udostępnienia tego projektu w modelu COM
[assembly: Guid("37ec684f-ec88-438d-8abd-d77986dd3033")]

// Informacje o wersji zestawu zawierają następujące cztery wartości:
//
//      Wersja główna
//      Wersja pomocnicza
//      Numer kompilacji
//      Poprawka
//
// Możesz określić wszystkie wartości lub użyć domyślnych numerów kompilacji i poprawki
// przy użyciu symbolu „*”, tak jak pokazano poniżej:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion(Plugin.PluginVersion)]
[assembly: AssemblyFileVersion(Plugin.PluginVersion)]
