namespace DocumentModel.Drawings;

/// <summary>
/// Preset Shadow.
/// </summary>
public class PresetShadowImpl: ModelElementImpl, PresetShadow
{
  public DocumentFormat.OpenXml.Drawing.PresetShadow? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.PresetShadow?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PresetShadowImpl(): base() {}
  
  public PresetShadowImpl(DocumentFormat.OpenXml.Drawing.PresetShadow openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Preset Shadow
  /// </summary>
  public PresetShadowKind? Preset
  {
    get => (PresetShadowKind?)OpenXmlElement?.Preset?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Preset = (DocumentFormat.OpenXml.Drawing.PresetShadowValues?)value;
    }
  }
  
  /// <summary>
  /// Distance
  /// </summary>
  public Int64? Distance
  {
    get => (Int64?)OpenXmlElement?.Distance?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Distance = (System.Int64?)value;
    }
  }
  
  /// <summary>
  /// Direction
  /// </summary>
  public Int32? Direction
  {
    get => (Int32?)OpenXmlElement?.Direction?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Direction = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// RGB Color Model - Percentage Variant.
  /// </summary>
  public RgbColorModelPercentage? RgbColorModelPercentage
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// RGB Color Model - Hex Variant.
  /// </summary>
  public RgbColorModelHex? RgbColorModelHex
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Hue, Saturation, Luminance Color Model.
  /// </summary>
  public HslColor? HslColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// System Color.
  /// </summary>
  public SystemColor? SystemColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Scheme Color.
  /// </summary>
  public SchemeColor? SchemeColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Preset Color.
  /// </summary>
  public PresetColor? PresetColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
