namespace DocumentModel.Wordprocessing;

  /// <summary>
  /// Specifies the contents of the body of the document, which serves as the main document editing surface in a WordprocessingML document.
  /// The document body contains block-level markup, allowing elements such as paragraphs, tables, and other block content to exist as siblings within the document structure.
  /// </summary>
  public interface Body : BodyType
  {
  }