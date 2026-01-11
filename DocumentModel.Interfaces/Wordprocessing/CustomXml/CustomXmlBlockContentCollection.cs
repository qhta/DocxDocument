namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a collection of custom XML block content elements in a WordprocessingML document.
/// This interface provides access to and management of <see cref="CustomXmlBlockContent"/> objects, enabling advanced organization, annotation, and schema-based processing of custom XML data within block-level document content.
/// </summary>
public interface CustomXmlBlockContentCollection : ElementCollection<CustomXmlBlockContent>
{
  
}