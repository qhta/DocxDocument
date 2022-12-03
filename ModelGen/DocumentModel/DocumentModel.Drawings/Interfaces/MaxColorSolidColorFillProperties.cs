namespace DocumentModel.Drawings;

/// <summary>
/// Defines the MaxColorSolidColorFillProperties Class.
/// </summary>
public interface MaxColorSolidColorFillProperties // : DocumentModel.Drawings.OpenXmlSolidColorFillPropertiesElement
{
  public RgbColorModelPercentage? RgbColorModelPercentage { get ; set; }
  
  public RgbColorModelHex? RgbColorModelHex { get ; set; }
  
  public HslColor? HslColor { get ; set; }
  
  public SystemColor? SystemColor { get ; set; }
  
  public SchemeColor? SchemeColor { get ; set; }
  
  public PresetColor? PresetColor { get ; set; }
  
}
