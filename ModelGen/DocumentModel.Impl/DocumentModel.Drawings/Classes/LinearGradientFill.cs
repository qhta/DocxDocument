namespace DocumentModel.Drawings;

/// <summary>
/// Linear Gradient Fill.
/// </summary>
public partial class LinearGradientFillImpl: ModelElementImpl, LinearGradientFill
{
  public DocumentFormat.OpenXml.Drawing.LinearGradientFill? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.LinearGradientFill?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public LinearGradientFillImpl(): base() {}
  
  public LinearGradientFillImpl(DocumentFormat.OpenXml.Drawing.LinearGradientFill openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Angle
  /// </summary>
  public Int32? Angle
  {
    get => (System.Int32?)OpenXmlElement?.Angle?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.Scaled?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Scaled = (System.Boolean?)value;
    }
  }
  
}
