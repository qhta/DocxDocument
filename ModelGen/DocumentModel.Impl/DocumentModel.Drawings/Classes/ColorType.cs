namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ColorType Class.
/// </summary>
public class ColorTypeImpl: ModelElementImpl, ColorType
{
  public DocumentFormat.OpenXml.Drawing.ColorType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ColorType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// RGB Color Model - Percentage Variant.
  /// </summary>
  public virtual RgbColorModelPercentage? RgbColorModelPercentage
  {
    get;
    set;
  }
  
  /// <summary>
  /// RGB Color Model - Hex Variant.
  /// </summary>
  public virtual RgbColorModelHex? RgbColorModelHex
  {
    get;
    set;
  }
  
  /// <summary>
  /// Hue, Saturation, Luminance Color Model.
  /// </summary>
  public virtual HslColor? HslColor
  {
    get;
    set;
  }
  
  /// <summary>
  /// System Color.
  /// </summary>
  public virtual SystemColor? SystemColor
  {
    get;
    set;
  }
  
  /// <summary>
  /// Scheme Color.
  /// </summary>
  public virtual SchemeColor? SchemeColor
  {
    get;
    set;
  }
  
  /// <summary>
  /// Preset Color.
  /// </summary>
  public virtual PresetColor? PresetColor
  {
    get;
    set;
  }
  
}
