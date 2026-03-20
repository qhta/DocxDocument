using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `ThemeFonts` interface.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themefonts?view=office-pia
/// </remarks>
public partial interface ThemeFonts: InteropCollection<ThemeFont>
{
}
