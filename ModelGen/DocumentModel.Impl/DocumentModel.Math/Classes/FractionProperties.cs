namespace DocumentModel.Math;

/// <summary>
/// Fraction Properties.
/// </summary>
public partial class FractionPropertiesImpl: ModelElementImpl, FractionProperties
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Math.FractionProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.FractionProperties?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public FractionPropertiesImpl(): base() {}
  
  public FractionPropertiesImpl(DocumentFormat.OpenXml.Math.FractionProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Fraction type.
  /// </summary>
  public DocumentModel.Math.FractionKind? FractionType
  {
    get => (DocumentModel.Math.FractionKind?)OpenXmlElement?.FractionType?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.FractionType != null)
        {
          if (value is not null)
            OpenXmlElement.FractionType.Val = (DocumentFormat.OpenXml.Math.FractionTypeValues?)value;
          else
            OpenXmlElement.FractionType = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.FractionType = new DocumentFormat.OpenXml.Math.FractionType{ Val = (DocumentFormat.OpenXml.Math.FractionTypeValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public DocumentModel.Math.ControlProperties? ControlProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.ControlProperties>();
        if (item != null)
          return new DocumentModel.Math.ControlPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.ControlProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Math.ControlPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
