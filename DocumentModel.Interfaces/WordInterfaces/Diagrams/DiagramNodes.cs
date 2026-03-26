namespace DocumentModel.Wordprocessing;

/// <summary>
/// A collection of DiagramNode objects that represent all the nodes in a diagram. The DiagramNodes collection contains all the diagram nodes in a specified diagram.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.diagramnodes?view=word-pia"/>
public partial interface DiagramNodes : InteropObject, InteropCollection<DiagramNode>
{
}
