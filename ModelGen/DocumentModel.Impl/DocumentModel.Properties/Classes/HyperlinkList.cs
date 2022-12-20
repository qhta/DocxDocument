namespace DocumentModel.Properties;

/// <summary>
/// Hyperlink List.
/// </summary>
public partial class HyperlinkListImpl: DocumentModel.Properties.VectorVariantTypeImpl, HyperlinkList
{
  public new DocumentFormat.OpenXml.ExtendedProperties.HyperlinkList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.ExtendedProperties.HyperlinkList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public HyperlinkListImpl(): base() {}
  
  public HyperlinkListImpl(DocumentFormat.OpenXml.ExtendedProperties.HyperlinkList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new DocumentModel.VariantTypes.VTVector? VTVector
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTVector>();
        if (item != null)
          return new DocumentModel.VariantTypes.VTVectorImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTVector>();
        if (item != null)
          item.Remove();
        if (value != null)
        {
          var newItem = (value as DocumentModel.VariantTypes.VTVectorImpl)?.OpenXmlElement;
          if (newItem != null)
            OpenXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
}
