namespace DocumentModel.Properties;

/// <summary>
/// Part Titles.
/// </summary>
public partial class TitlesOfPartsImpl: ModelElementImpl, TitlesOfParts
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.ExtendedProperties.TitlesOfParts? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.ExtendedProperties.TitlesOfParts?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public TitlesOfPartsImpl(): base() {}
  
  public TitlesOfPartsImpl(DocumentFormat.OpenXml.ExtendedProperties.TitlesOfParts openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Vector.
  /// </summary>
  public DocumentModel.VectorVariant? VTVector
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
