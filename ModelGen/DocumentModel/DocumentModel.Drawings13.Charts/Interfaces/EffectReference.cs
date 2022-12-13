namespace DocumentModel.Drawings13.Charts;

/// <summary>
/// Defines the EffectReference Class.
/// </summary>
public interface EffectReference
{
  public DocumentModel.Drawings.RgbColorModelPercentage? RgbColorModelPercentage { get ; set; }
  
  public DocumentModel.Drawings.RgbColorModelHex? RgbColorModelHex { get ; set; }
  
  public DocumentModel.Drawings.HslColor? HslColor { get ; set; }
  
  public DocumentModel.Drawings.SystemColor? SystemColor { get ; set; }
  
  public DocumentModel.Drawings.SchemeColor? SchemeColor { get ; set; }
  
  public DocumentModel.Drawings.PresetColor? PresetColor { get ; set; }
  
  public DocumentModel.Drawings13.Charts.StyleColor? StyleColor { get ; set; }
  
}
