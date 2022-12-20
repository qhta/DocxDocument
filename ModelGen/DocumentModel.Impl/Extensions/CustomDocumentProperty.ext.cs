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
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.Variant>();
        if (item == null)
          return null;
        var variantImpl = new VariantImpl(item);
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

}