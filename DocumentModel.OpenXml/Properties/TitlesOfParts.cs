namespace DocumentModel.OpenXml.Properties;

/// <summary>
/// Part Titles.
/// </summary>
public partial class TitlesOfParts: ModelElementImpl
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.ExtendedProperties.TitlesOfParts? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.ExtendedProperties.TitlesOfParts?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public TitlesOfParts(): base() {}
  
  public TitlesOfParts(DocumentFormat.OpenXml.ExtendedProperties.TitlesOfParts openXmlElement): base(openXmlElement)
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
          return VTVectorConverter.GetValue(item);
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
          var vtVector = VTVectorConverter.CreateOpenXmlElement(value);
          if (vtVector != null)
            OpenXmlElement.AddChild(vtVector);
        }
      }
    }
  }
  
}
