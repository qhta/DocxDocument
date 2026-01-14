namespace DocumentModel.Wordprocessing;

  /// <summary>
  /// Represents the content for a single footer for use within one or more sections of a WordprocessingML document.
  /// This interface extends <see cref="HeaderFooter"/> and contains block-level markup similar to the document body, enabling advanced management and formatting of footer content for different sections and page types.
  /// </summary>
  public interface Footer : HeaderFooter
  {
  }