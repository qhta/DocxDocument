namespace DocumentModel.Vml;

/// <summary>
/// Defines the Fill Class.
/// </summary>
public class FillImpl: ModelElement<DocumentFormat.OpenXml.Vml.Fill>, Fill
{
  /// <summary>
  /// Fill Type
  /// </summary>
  public FillKind? Type
  {
    get => (FillKind?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Vml.FillTypeValues?)value;
    }
  }
  
  /// <summary>
  /// Image Aspect Ratio
  /// </summary>
  public ImageAspectKind? Aspect
  {
    get => (ImageAspectKind?)OpenXmlElement?.Aspect?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Aspect = (DocumentFormat.OpenXml.Vml.ImageAspectValues?)value;
    }
  }
  
  /// <summary>
  /// Gradient Fill Method
  /// </summary>
  public FillMethodKind? Method
  {
    get => (FillMethodKind?)OpenXmlElement?.Method?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Method = (DocumentFormat.OpenXml.Vml.FillMethodValues?)value;
    }
  }
  
  /// <summary>
  /// FillExtendedProperties.
  /// </summary>
  public FillExtendedProperties? FillExtendedProperties
  {
    get;
    set;
  }
  
}
