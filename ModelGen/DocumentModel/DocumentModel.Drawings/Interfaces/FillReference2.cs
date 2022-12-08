namespace DocumentModel.Drawings;

/// <summary>
/// Defines the FillReference Class.
/// </summary>
public interface FillReference2
{
  public RgbColorModelPercentage? RgbColorModelPercentage { get ; set; }
  
  public RgbColorModelHex? RgbColorModelHex { get ; set; }
  
  public HslColor? HslColor { get ; set; }
  
  public SystemColor? SystemColor { get ; set; }
  
  public SchemeColor? SchemeColor { get ; set; }
  
  public PresetColor? PresetColor { get ; set; }
  
  public StyleColor? StyleColor { get ; set; }
  
}
