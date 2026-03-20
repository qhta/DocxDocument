using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `ThemeColorScheme` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themecolorscheme?view=office-pia` for Office interop details.
/// </remarks>
public partial interface ThemeColorScheme: InteropCollection<ThemeColor>
{
}
