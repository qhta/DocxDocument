namespace DocumentModel.Drawings.ChartsStyle;

/// <summary>
/// Defines the FontReference Class.
/// </summary>
public interface FontReference
{
  /// <summary>
  /// idx, this property is only available in Office 2013 and later.
  /// </summary>
  public DocumentModel.Drawings.FontCollectionIndexKind? Index { get ; set; }
  
  /// <summary>
  /// mods, this property is only available in Office 2013 and later.
  /// </summary>
  public DocumentModel.ListOf<System.String>? Modifiers { get ; set; }
  
  public DocumentModel.Drawings.RgbColorModelPercentage? RgbColorModelPercentage { get ; set; }
  
  public DocumentModel.Drawings.RgbColorModelHex? RgbColorModelHex { get ; set; }
  
  public DocumentModel.Drawings.HslColor? HslColor { get ; set; }
  
  public DocumentModel.Drawings.SystemColor? SystemColor { get ; set; }
  
  public DocumentModel.Drawings.SchemeColor? SchemeColor { get ; set; }
  
  public DocumentModel.Drawings.PresetColor? PresetColor { get ; set; }
  
  public DocumentModel.Drawings.ChartsStyle.StyleColor? StyleColor { get ; set; }
  
}
