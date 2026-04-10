namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the root element of the CommentsExtensible part of a WordprocessingML document.
/// This class provides access to and management of extensible comment items, enabling advanced tracking, organization, and extensibility of comment metadata and behaviors throughout the document.
/// </summary>
[OpenXmlType(typeof(CommentExtensible))]
[XmlRoot("CommentsExtensible", Namespace = "DocumentModel.Wordprocessing")]
public class CommentsExtensible : ModelElementCollection<CommentExtensible, DXO21WCE.CommentsExtensible, DXO21WCE.CommentExtensible> //IElementCollection<CollectionItem>
{
}