namespace DocumentModel.Math;

/// <summary>
/// Fraction Properties.
/// </summary>
public class FractionPropertiesImpl: ModelElement<DocumentFormat.OpenXml.Math.FractionProperties>, FractionProperties
{
  /// <summary>
  /// Fraction type.
  /// </summary>
  public FractionKind? FractionType
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.FractionType>();
        return (FractionKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.FractionType>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Math.FractionTypeValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Math.FractionType{ Val = (DocumentFormat.OpenXml.Math.FractionTypeValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public ControlProperties? ControlProperties
  {
    get;
    set;
  }
  
}
