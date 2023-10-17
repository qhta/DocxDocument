namespace DocumentModel.Drawings;


/// <summary>
///   Color Specified.
/// </summary>
public partial class BulletColor
{
  public DocumentModel.Drawings.RgbColorModelPercentage? RgbColorModelPercentage { get; set; }
  
  public DocumentModel.Drawings.RgbColorModelHex? RgbColorModelHex { get; set; }
  
  public DocumentModel.Drawings.HslColor? HslColor { get; set; }
  
  public DocumentModel.Drawings.SystemColor? SystemColor { get; set; }
  
  public DocumentModel.Drawings.SchemeColorKind? SchemeColor { get; set; }
  
  public DocumentModel.Drawings.PresetColorKind? PresetColor { get; set; }
  
}
