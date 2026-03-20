using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SmartArtQuickStyles` interface.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartquickstyles?view=office-pia
/// </remarks>
public partial interface SmartArtQuickStyles: InteropDictionary<string, SmartArtQuickStyle>
{
}
