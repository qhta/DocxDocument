namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the background color of a Pattern fill.
/// </summary>
public partial class BackgroundColor
{
  public DocumentModel.Drawings.RgbColorModelPercentage? RgbColorModelPercentage { get; set; }
  
  public DocumentModel.Drawings.RgbColorModelHex? RgbColorModelHex { get; set; }
  
  public DocumentModel.Drawings.HslColor? HslColor { get; set; }
  
  public DocumentModel.Drawings.SystemColor? SystemColor { get; set; }
  
  public DocumentModel.Drawings.SchemeColorKind? SchemeColor { get; set; }
  
  public DocumentModel.Drawings.PresetColorKind? PresetColor { get; set; }
  
}
