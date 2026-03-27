using System.Collections;

namespace DocumentModel.Drawings.SmartArt;

/// <summary>
/// Represents the `SmartArtLayouts` interface.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartlayouts?view=office-pia"/>
public partial interface SmartArtLayouts: InteropCollection<SmartArtLayout>
{
}

