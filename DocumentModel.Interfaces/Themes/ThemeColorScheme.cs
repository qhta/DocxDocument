using System.Collections;
using System.Reflection;

namespace DocumentModel.Themes;

/// <summary>
/// Represents the `ThemeColorScheme` interface.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themecolorscheme?view=office-pia"/>
public partial interface ThemeColorScheme: IModelCollection<ThemeColor>
{
}

