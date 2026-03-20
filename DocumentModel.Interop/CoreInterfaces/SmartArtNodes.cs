using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SmartArtNodes` interface.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartnodes?view=office-pia
/// </remarks>
public partial interface SmartArtNodes: InteropDictionary<string, SmartArtNode>
{
}
