
namespace DocxDocument.Model;

public class CustomDocumentProperty: DocumentProperty, ICustomDocumentProperty
{

  /// <summary>
  /// Predefined format ID.
  /// </summary>
  public Guid? FormatId { get; set; }

  /// <summary>
  /// OLE Property ID. Must be at least 2.
  /// </summary>
  public int? PropertyId { get; set; }

  /// <summary>
  /// Bookmark name. Specified when Value is extracted from a Bookmark.
  /// </summary>
  public string? LinkTarget { get; set; }
}