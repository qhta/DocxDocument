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
  
  public ColorTypeImpl(): base() {}
  
  public ColorTypeImpl(DocumentFormat.OpenXml.Drawing.ColorType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// RGB Color Model - Percentage Variant.
  /// </summary>
  public virtual DocumentModel.Drawings.RgbColorModelPercentage? RgbColorModelPercentage
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// RGB Color Model - Hex Variant.
  /// </summary>
  public virtual DocumentModel.Drawings.RgbColorModelHex? RgbColorModelHex
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Hue, Saturation, Luminance Color Model.
  /// </summary>
  public virtual DocumentModel.Drawings.HslColor? HslColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// System Color.
  /// </summary>
  public virtual DocumentModel.Drawings.SystemColor? SystemColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Scheme Color.
  /// </summary>
  public virtual DocumentModel.Drawings.SchemeColor? SchemeColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Preset Color.
  /// </summary>
  public virtual DocumentModel.Drawings.PresetColor? PresetColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
