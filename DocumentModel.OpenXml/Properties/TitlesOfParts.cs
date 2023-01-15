namespace DocumentModel.OpenXml.Properties;

/// <summary>
///   Part Titles.
/// </summary>
public class TitlesOfParts : ModelElementImpl
{
  public TitlesOfParts()
  {
  }

  public TitlesOfParts(DocumentFormat.OpenXml.ExtendedProperties.TitlesOfParts openXmlElement) : base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }

  [XmlIgnore]
  public DocumentFormat.OpenXml.ExtendedProperties.TitlesOfParts? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.ExtendedProperties.TitlesOfParts?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }

  /// <summary>
  ///   Vector.
  /// </summary>
  public VectorVariant? VTVector
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<VTVector>();
        if (item != null)
          return VTVectorConverter.CreateModelElement(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<VTVector>();
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