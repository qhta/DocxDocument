namespace DocumentModel.Drawings.ChartsStyle;

/// <summary>
/// Defines the ColorStyle Class.
/// </summary>
public interface ColorStyle
{
  /// <summary>
  /// meth, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Method { get ; set; }
  
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  public UInt32? Id { get ; set; }
  
  public DocumentModel.Drawings.RgbColorModelPercentage? RgbColorModelPercentage { get ; set; }
  
  public DocumentModel.Drawings.RgbColorModelHex? RgbColorModelHex { get ; set; }
  
  public DocumentModel.Drawings.HslColor? HslColor { get ; set; }
  
  public DocumentModel.Drawings.SystemColor? SystemColor { get ; set; }
  
  public DocumentModel.Drawings.SchemeColor? SchemeColor { get ; set; }
  
  public DocumentModel.Drawings.PresetColor? PresetColor { get ; set; }
  
  public Collection<DocumentModel.Drawings.ChartsStyle.ColorStyleVariation>? ColorStyleVariations { get ; set; }
  
  public DocumentModel.Drawings.ChartsStyle.OfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
