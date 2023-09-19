namespace DocumentModel.Drawings;


/// <summary>
///   Defines the Highlight Class.
/// </summary>
public partial class Highlight
{
  public DocumentModel.Drawings.RgbColorModelPercentage? RgbColorModelPercentage { get; set; }
  
  public DocumentModel.Drawings.RgbColorModelHex? RgbColorModelHex { get; set; }
  
  public DocumentModel.Drawings.HslColor? HslColor { get; set; }
  
  public DocumentModel.Drawings.SystemColor? SystemColor { get; set; }
  
  public DocumentModel.Drawings.SchemeColorValues? SchemeColor { get; set; }
  
  public DocumentModel.Drawings.PresetColorValues? PresetColor { get; set; }
  
}
