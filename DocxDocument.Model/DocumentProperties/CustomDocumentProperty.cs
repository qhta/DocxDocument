
using DocumentFormat.OpenXml.Bibliography;

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

  public override string ToString()
  {
    var list = new List<string>();
    list.Add(Name);
    if (Value != null)
      list.Add(Value.ToString());
    if (FormatId!=null)
      list.Add(FormatId.ToString());
    if (PropertyId != null)
      list.Add(PropertyId.ToString());
    if (LinkTarget != null)
      list.Add(LinkTarget.ToString());
    return $"({String.Join(", ",list)})";
  }
}