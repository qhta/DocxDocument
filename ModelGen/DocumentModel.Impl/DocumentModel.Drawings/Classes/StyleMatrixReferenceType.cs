namespace DocumentModel.Drawings;

/// <summary>
/// Defines the StyleMatrixReferenceType Class.
/// </summary>
public class StyleMatrixReferenceTypeImpl: ModelElementImpl, StyleMatrixReferenceType
{
  public DocumentFormat.OpenXml.Drawing.StyleMatrixReferenceType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.StyleMatrixReferenceType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Style Matrix Index
  /// </summary>
  public UInt32? Index
  {
    get;
    set;
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
