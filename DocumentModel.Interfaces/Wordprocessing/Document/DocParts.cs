namespace DocumentModel.Wordprocessing;

  /// <summary>
  /// Represents a list of glossary document entries (DocParts) in a WordprocessingML document.
  /// This interface provides access to and management of <see cref="DocPart"/> objects, enabling advanced organization, reuse, and referencing of building blocks, autotext, and other reusable document content.
  /// </summary>
  public interface DocParts : ElementCollection<DocPart>
  {
    
  }