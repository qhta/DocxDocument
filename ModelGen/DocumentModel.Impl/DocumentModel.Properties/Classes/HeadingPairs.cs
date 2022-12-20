namespace DocumentModel.Properties;

/// <summary>
/// Heading Pairs.
/// </summary>
public partial class HeadingPairsImpl: DocumentModel.Properties.VectorVariantTypeImpl, HeadingPairs
{
  [XmlIgnore]
  public new DocumentFormat.OpenXml.ExtendedProperties.HeadingPairs? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.ExtendedProperties.HeadingPairs?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public HeadingPairsImpl(): base() {}
  
  public HeadingPairsImpl(DocumentFormat.OpenXml.ExtendedProperties.HeadingPairs openXmlElement): base(openXmlElement)
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
