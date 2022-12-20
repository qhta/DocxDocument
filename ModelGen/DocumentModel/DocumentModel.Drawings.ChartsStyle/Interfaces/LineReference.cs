namespace DocumentModel.Drawings.ChartsStyle;

/// <summary>
/// Defines the LineReference Class.
/// </summary>
public partial interface LineReference
{
  public DocumentModel.Drawings.RgbColorModelPercentage? RgbColorModelPercentage { get; set; }
  
  public DocumentModel.Drawings.RgbColorModelHex? RgbColorModelHex { get; set; }
  
  public DocumentModel.Drawings.HslColor? HslColor { get; set; }
  
  public DocumentModel.Drawings.SystemColor? SystemColor { get; set; }
  
  public DocumentModel.Drawings.SchemeColor? SchemeColor { get; set; }
  
  public DocumentModel.Drawings.PresetColor? PresetColor { get; set; }
  
  public DocumentModel.Drawings.ChartsStyle.StyleColor? StyleColor { get; set; }
  
}
