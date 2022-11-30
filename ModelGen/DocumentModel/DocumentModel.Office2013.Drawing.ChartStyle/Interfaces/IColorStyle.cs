namespace DocumentModel.Office2013.Drawing.ChartStyle;

/// <summary>
/// Defines the ColorStyle Class.
/// </summary>
public interface IColorStyle // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// meth, this property is only available in Office 2013 and later.
  /// </summary>
  public System.String? Method { get ; set; }
  
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  public System.UInt32? Id { get ; set; }
  
  public DocumentModel.Drawing.IRgbColorModelPercentage? RgbColorModelPercentage { get ; set; }
  
  public DocumentModel.Drawing.IRgbColorModelHex? RgbColorModelHex { get ; set; }
  
  public DocumentModel.Drawing.IHslColor? HslColor { get ; set; }
  
  public DocumentModel.Drawing.ISystemColor? SystemColor { get ; set; }
  
  public DocumentModel.Drawing.ISchemeColor? SchemeColor { get ; set; }
  
  public DocumentModel.Drawing.IPresetColor? PresetColor { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Office2013.Drawing.ChartStyle.IColorStyleVariation>? ColorStyleVariations { get ; set; }
  
  public DocumentModel.Office2013.Drawing.ChartStyle.IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
