namespace DocumentModel.Drawings;

/// <summary>
/// Linear Gradient Fill.
/// </summary>
public class LinearGradientFillImpl: ModelElementImpl, LinearGradientFill
{
  public DocumentFormat.OpenXml.Drawing.LinearGradientFill? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.LinearGradientFill?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Angle
  /// </summary>
  public Int32? Angle
  {
    get => (Int32?)OpenXmlElement?.Angle?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Angle = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Scaled
  /// </summary>
  public Boolean? Scaled
  {
    get => (Boolean?)OpenXmlElement?.Scaled?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Scaled = (System.Boolean?)value;
    }
  }
  
}
