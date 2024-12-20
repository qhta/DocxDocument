namespace DocumentModel.Drawings;

/// <summary>
/// Hue Saturation Luminance Effect.
/// </summary>
public partial class HslImpl: ModelElementImpl, Hsl
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Hsl? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Hsl?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public HslImpl(): base() {}
  
  public HslImpl(DocumentFormat.OpenXml.Drawing.Hsl openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Hue
  /// </summary>
  public Int32? Hue
  {
    get => (System.Int32?)OpenXmlElement?.Hue?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Hue = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Saturation
  /// </summary>
  public Int32? Saturation
  {
    get => (System.Int32?)OpenXmlElement?.Saturation?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Saturation = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Luminance
  /// </summary>
  public Int32? Luminance
  {
    get => (System.Int32?)OpenXmlElement?.Luminance?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Luminance = (System.Int32?)value;
    }
  }
  
}
