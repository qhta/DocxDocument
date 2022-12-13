namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the MinColorSolidColorFillProperties Class.
/// </summary>
public interface MinColorSolidColorFillProperties
{
  public DocumentModel.Drawings.RgbColorModelPercentage? RgbColorModelPercentage { get ; set; }
  
  public DocumentModel.Drawings.RgbColorModelHex? RgbColorModelHex { get ; set; }
  
  public DocumentModel.Drawings.HslColor? HslColor { get ; set; }
  
  public DocumentModel.Drawings.SystemColor? SystemColor { get ; set; }
  
  public DocumentModel.Drawings.SchemeColor? SchemeColor { get ; set; }
  
  public DocumentModel.Drawings.PresetColor? PresetColor { get ; set; }
  
}
