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
    get;
    set;
  }
  
  /// <summary>
  /// Scaled
  /// </summary>
  public Boolean? Scaled
  {
    get;
    set;
  }
  
}
