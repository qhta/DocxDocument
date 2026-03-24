using System.Collections;

namespace DocumentModel.Interfaces;

/// <summary>
/// Represents the `SmartArtLayouts` interface.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartlayouts?view=office-pia"/>
public partial interface SmartArtLayouts: InteropCollection<SmartArtLayout>
{
}

