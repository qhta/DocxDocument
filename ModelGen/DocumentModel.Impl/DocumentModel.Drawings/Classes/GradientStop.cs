namespace DocumentModel.Drawings;

/// <summary>
/// Gradient stops.
/// </summary>
public class GradientStopImpl: ModelElementImpl, GradientStop
{
  public DocumentFormat.OpenXml.Drawing.GradientStop? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.GradientStop?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Position
  /// </summary>
  public Int32? Position
  {
    get;
    set;
  }
  
  /// <summary>
  /// RGB Color Model - Percentage Variant.
  /// </summary>
  public RgbColorModelPercentage? RgbColorModelPercentage
  {
    get;
    set;
  }
  
  /// <summary>
  /// RGB Color Model - Hex Variant.
  /// </summary>
  public RgbColorModelHex? RgbColorModelHex
  {
    get;
    set;
  }
  
  /// <summary>
  /// Hue, Saturation, Luminance Color Model.
  /// </summary>
  public HslColor? HslColor
  {
    get;
    set;
  }
  
  /// <summary>
  /// System Color.
  /// </summary>
  public SystemColor? SystemColor
  {
    get;
    set;
  }
  
  /// <summary>
  /// Scheme Color.
  /// </summary>
  public SchemeColor? SchemeColor
  {
    get;
    set;
  }
  
  /// <summary>
  /// Preset Color.
  /// </summary>
  public PresetColor? PresetColor
  {
    get;
    set;
  }
  
}
