namespace DocumentModel.Wordprocessing;

  /// <summary>
  /// Represents a custom XML element surrounding one or more inline-level structures (such as runs, images, fields, etc.) within a paragraph in a WordprocessingML document.
  /// This interface extends <see cref="CustomXmlRun"/> and <see cref="RubyContent"/>, enabling advanced schema-based processing, annotation, and integration of custom XML data within ruby text and other inline content. The attributes specify the name and namespace URI of the custom XML element.
  /// </summary>
  public interface CustomXmlRuby : CustomXmlRun, RubyContent
  {
  }