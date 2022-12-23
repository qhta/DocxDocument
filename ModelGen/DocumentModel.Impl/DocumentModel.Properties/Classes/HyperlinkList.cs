namespace DocumentModel.Properties;

/// <summary>
/// Hyperlink List.
/// </summary>
public partial class HyperlinkListImpl : DocumentModel.Properties.VectorVariantTypeImpl, HyperlinkList
{
  [XmlIgnore]
  public new DocumentFormat.OpenXml.ExtendedProperties.HyperlinkList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.ExtendedProperties.HyperlinkList?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }

  public HyperlinkListImpl() : base() { }

  public HyperlinkListImpl(DocumentFormat.OpenXml.ExtendedProperties.HyperlinkList openXmlElement) : base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }

  public new DocumentModel.VectorVariant? VTVector
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.VariantTypes.VTVector>();
        if (item != null)
          return new VTVectorImpl(item).GetValue();
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
          var vtVector = new VTVectorImpl { Value = value }.OpenXmlElement;
          if (vtVector != null)
            OpenXmlElement.AddChild(vtVector);
        }
      }
    }
  }

}
