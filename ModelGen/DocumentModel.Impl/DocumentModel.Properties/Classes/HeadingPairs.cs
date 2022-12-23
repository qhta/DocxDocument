using DocumentFormat.OpenXml.VariantTypes;
using DocumentFormat.OpenXml;

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
