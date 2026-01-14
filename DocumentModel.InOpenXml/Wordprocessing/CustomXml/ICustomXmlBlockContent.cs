namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a content item within a custom XML block in a WordprocessingML document.
/// This interface extends <see cref="CollectionItem"/> and is used to encapsulate block-level content that is associated with custom XML markup, enabling advanced schema-based processing, annotation, and integration of custom data within document structures.
/// </summary>
public interface ICustomXmlBlockContent: ICollectionItem
{
  
}