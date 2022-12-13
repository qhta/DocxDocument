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
  public DocumentModel.Drawings.PresetShadowKind? Preset
  {
    get => (DocumentModel.Drawings.PresetShadowKind?)OpenXmlElement?.Preset?.Value;
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
    get => (System.Int64?)OpenXmlElement?.Distance?.Value;
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
    get => (System.Int32?)OpenXmlElement?.Direction?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Direction = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// RGB Color Model - Percentage Variant.
  /// </summary>
  public DocumentModel.Drawings.RgbColorModelPercentage? RgbColorModelPercentage
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// RGB Color Model - Hex Variant.
  /// </summary>
  public DocumentModel.Drawings.RgbColorModelHex? RgbColorModelHex
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Hue, Saturation, Luminance Color Model.
  /// </summary>
  public DocumentModel.Drawings.HslColor? HslColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// System Color.
  /// </summary>
  public DocumentModel.Drawings.SystemColor? SystemColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Scheme Color.
  /// </summary>
  public DocumentModel.Drawings.SchemeColor? SchemeColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Preset Color.
  /// </summary>
  public DocumentModel.Drawings.PresetColor? PresetColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
