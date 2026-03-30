using System.Collections;

namespace DocumentModel.Drawings.SmartArt;

/// <summary>
/// Represents the `SmartArtNodes` interface.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartnodes?view=office-pia"/>
public partial interface SmartArtNodes: IModelCollection<SmartArtNode>
{
}

