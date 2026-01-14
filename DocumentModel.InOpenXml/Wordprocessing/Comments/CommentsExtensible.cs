namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the root element of the CommentsExtensible part of a WordprocessingML document.
/// This interface provides access to and management of extensible comment items, enabling advanced tracking, organization, and extensibility of comment metadata and behaviors throughout the document.
/// </summary>
public interface CommentsExtensible: IElementCollection<CollectionItem>
{
}