namespace DocumentModel.Drawing;

public interface IOuterShadow // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public long? BlurRadius { get ; set; }
  
  public long? Distance { get ; set; }
  
  public int? Direction { get ; set; }
  
  public int? HorizontalRatio { get ; set; }
  
  public int? VerticalRatio { get ; set; }
  
  public int? HorizontalSkew { get ; set; }
  
  public int? VerticalSkew { get ; set; }
  
  public DocumentModel.Drawing.RectangleAlignment? Alignment { get ; set; }
  
  public bool? RotateWithShape { get ; set; }
  
  public IRgbColorModelPercentage? RgbColorModelPercentage { get ; set; }
  
  public DocumentModel.Drawing.IRgbColorModelHex? RgbColorModelHex { get ; set; }
  
  public DocumentModel.Drawing.IHslColor? HslColor { get ; set; }
  
  public ISystemColor? SystemColor { get ; set; }
  
  public DocumentModel.Drawing.ISchemeColor? SchemeColor { get ; set; }
  
  public IPresetColor? PresetColor { get ; set; }
  
}
