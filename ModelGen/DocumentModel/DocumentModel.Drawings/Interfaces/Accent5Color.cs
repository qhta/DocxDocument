namespace DocumentModel.Drawings;

/// <summary>
/// Accent 5.
/// </summary>
public interface Accent5Color
{
  public DocumentModel.Drawings.RgbColorModelPercentage? RgbColorModelPercentage { get ; set; }
  
  public DocumentModel.Drawings.RgbColorModelHex? RgbColorModelHex { get ; set; }
  
  public DocumentModel.Drawings.HslColor? HslColor { get ; set; }
  
  public DocumentModel.Drawings.SystemColor? SystemColor { get ; set; }
  
  public DocumentModel.Drawings.PresetColor? PresetColor { get ; set; }
  
}
