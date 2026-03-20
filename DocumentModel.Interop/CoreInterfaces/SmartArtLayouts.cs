using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SmartArtLayouts` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartlayouts?view=office-pia` for Office interop details.
/// </remarks>
public partial interface SmartArtLayouts: InteropDictionary<string, SmartArtLayout>
{
}
