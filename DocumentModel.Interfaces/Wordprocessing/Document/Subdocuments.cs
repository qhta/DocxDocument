namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a collection of subdocument references in a WordprocessingML document.
/// This interface provides access to and management of <see cref="SubDocumentReference"/> objects, enabling advanced linking, embedding, and organization of external or modular document content within the main document structure.
/// </summary>
public interface Subdocuments : ElementCollection<SubDocumentReference>
{
  
}