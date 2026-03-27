using System.Collections;
using System.Reflection;

namespace DocumentModel.Application;

/// <summary>
/// Represents the `ThemeFonts` interface.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themefonts?view=office-pia"/>
public partial interface ThemeFonts: InteropCollection<ThemeFont>
{
}

