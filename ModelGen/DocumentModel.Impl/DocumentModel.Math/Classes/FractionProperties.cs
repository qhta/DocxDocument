namespace DocumentModel.Math;

/// <summary>
/// Fraction Properties.
/// </summary>
public class FractionPropertiesImpl: ModelElementImpl, FractionProperties
{
  public DocumentFormat.OpenXml.Math.FractionProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.FractionProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
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
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
