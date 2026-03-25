namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of XMLNode objects that represents the nodes in the tree view of the XML Structure task pane,
/// which indicates the elements that a user has applied to a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnodes?view=word-pia"/>
public partial interface XMLNodes : InteropObject, InteropCollection<XMLNode>
{
}
