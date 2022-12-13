namespace DocumentModel.Drawings;

/// <summary>
/// Luminance.
/// </summary>
public class LuminanceEffectImpl: ModelElementImpl, LuminanceEffect
{
  public DocumentFormat.OpenXml.Drawing.LuminanceEffect? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.LuminanceEffect?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public LuminanceEffectImpl(): base() {}
  
  public LuminanceEffectImpl(DocumentFormat.OpenXml.Drawing.LuminanceEffect openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Brightness
  /// </summary>
  public Int32? Brightness
  {
    get => (System.Int32?)OpenXmlElement?.Brightness?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Brightness = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Contrast
  /// </summary>
  public Int32? Contrast
  {
    get => (System.Int32?)OpenXmlElement?.Contrast?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Contrast = (System.Int32?)value;
    }
  }
  
}
