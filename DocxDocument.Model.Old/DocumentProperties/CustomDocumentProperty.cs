
using DocumentFormat.OpenXml.Bibliography;

using Newtonsoft.Json.Linq;

namespace DocxDocument.Model;

public class CustomDocumentProperty : DocxBasedElement<CP.CustomDocumentProperty>, ICustomDocumentProperty
{
  public CustomDocumentProperty() : base(new CP.CustomDocumentProperty())
  {
  }

  public CustomDocumentProperty(CP.CustomDocumentProperty element) : base(element)
  {
  }

  public string Name
  {
    get => DocxElement.Name?.Value ?? string.Empty;
    set => DocxElement.Name = value;
  }

  public DM.PropertyType Type
  {
    get;
    set;
  }

  public object? Value
  {
    get => DocxRead.ReadVariant(DocxElement.Elements().FirstOrDefault());
    set
    {
      if (value is Variant variant)
      {
        DocxElement.RemoveAllChildren();
        var variantElement = DocxWrite.CreateVariant(variant);
        if (variantElement != null) 
          DocxElement.AddChild(variantElement);
      }
    }
  }

  /// <summary>
  /// Predefined format ID.
  /// </summary>
  public Guid? FormatId
  {
    get => DocxRead.ReadGuid(DocxElement.FormatId);
    set => DocxElement.FormatId = (value != null) ? ((Guid)value).ToString("B") : new Guid("{D5CDD505-2E9C-101B-9397-08002B2CF9AE}").ToString();
  }

  /// <summary>
  /// OLE Property ID. Must be at least 2.
  /// </summary>
  public int? PropertyId
  {
    get => DocxElement.PropertyId?.Value;
    set
    {
      if (value != null)
        DocxElement.PropertyId = (int)value;
      else
      {
        var allProperties = DocxElement.Parent?.Elements<CP.CustomDocumentProperty>().ToList();
        if (allProperties?.Count > 0)
        {
          var max = allProperties.Max(item=>item.PropertyId?.Value ?? 1);
          DocxElement.PropertyId = max + 1;
        }
        else
          DocxElement.PropertyId = 2;
      }
    }
  }

  /// <summary>
  /// Bookmark name. Specified when Value is extracted from a Bookmark.
  /// </summary>
  public string? LinkTarget
  {
    get => DocxElement.LinkTarget?.Value; 
    set => DocxElement.LinkTarget = value;
  }

  public override string ToString()
  {
    var list = new List<string>();
    list.Add(Name);
    if (Value != null)
      list.Add(Value.ToString());
    if (FormatId != null)
      list.Add(FormatId.ToString());
    if (PropertyId != null)
      list.Add(PropertyId.ToString());
    if (LinkTarget != null)
      list.Add(LinkTarget.ToString());
    return $"({String.Join(", ", list)})";
  }
}