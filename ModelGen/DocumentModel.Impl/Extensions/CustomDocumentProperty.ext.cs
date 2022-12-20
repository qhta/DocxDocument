using DocumentFormat.OpenXml;

namespace DocumentModel.Properties;

public partial class CustomDocumentPropertyImpl
{
  public object? Value
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.FirstChild;
        if (item == null)
          return null;
        var variantImpl = VariantImpl.CreateVariant(item);
        return variantImpl.Value;
      }
      return null;
    }
    //set
    //{
    //  if (OpenXmlElement != null)
    //  {
    //    var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTVector>();
    //    if (item != null)
    //      item.Remove();
    //    if (value != null)
    //    {
    //      var newItem = (value as DocumentModel.VariantTypes.VTVectorImpl)?.OpenXmlElement;
    //      if (newItem != null)
    //        OpenXmlElement.AddChild(newItem);
    //    }
    //  }
    //}
  }

  public override string ToString()
  {
    var str = $"{Name} = {Value}";
    if (FormatId != null && FormatId.Length > 0)
      str += $", FormatId={FormatId}";
    if (LinkTarget != null && LinkTarget.Length > 0)
      str += $", LinkTarget={LinkTarget}";
    return str;
  }
}