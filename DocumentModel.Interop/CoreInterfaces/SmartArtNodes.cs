using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SmartArtNodes` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartnodes?view=office-pia` for Office interop details.
/// </remarks>
public partial interface SmartArtNodes: InteropDictionary<string, SmartArtNode>
{
}
