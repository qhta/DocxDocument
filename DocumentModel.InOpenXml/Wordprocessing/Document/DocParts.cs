namespace DocumentModel.Wordprocessing;

  /// <summary>
  /// Represents a list of glossary document entries (DocParts) in a WordprocessingML document.
  /// This class provides access to and management of <see cref="DocPart"/> objects, enabling advanced organization, reuse, and referencing of building blocks, autotext, and other reusable document content.
  /// </summary>
  public class DocParts: ModelElementCollection<DocPart, DXW.DocParts, DXW.DocPart>
  {
    
  }