namespace DocumentModel.Drawings.ChartsStyle;


/// <summary>
///   Defines the FillReference Class.
/// </summary>
public partial class FillReference
{
  public DocumentModel.Drawings.RgbColorModelPercentage? RgbColorModelPercentage { get; set; }
  
  public DocumentModel.Drawings.RgbColorModelHex? RgbColorModelHex { get; set; }
  
  public DocumentModel.Drawings.HslColor? HslColor { get; set; }
  
  public DocumentModel.Drawings.SystemColor? SystemColor { get; set; }
  
  public DocumentModel.Drawings.SchemeColorKind? SchemeColor { get; set; }
  
  public DocumentModel.Drawings.PresetColorKind? PresetColor { get; set; }
  
  public String? StyleColor { get; set; }
  
}
