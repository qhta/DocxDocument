namespace DocumentModel.Office2010.Word;

public interface IShadow // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public long? BlurRadius { get ; set; }
  
  public long? DistanceFromText { get ; set; }
  
  public int? DirectionAngle { get ; set; }
  
  public int? HorizontalScalingFactor { get ; set; }
  
  public int? VerticalScalingFactor { get ; set; }
  
  public int? HorizontalSkewAngle { get ; set; }
  
  public int? VerticalSkewAngle { get ; set; }
  
  public DocumentModel.Office2010.Word.RectangleAlignment? Alignment { get ; set; }
  
  public DocumentModel.Office2010.Word.IRgbColorModelHex? RgbColorModelHex { get ; set; }
  
  public DocumentModel.Office2010.Word.ISchemeColor? SchemeColor { get ; set; }
  
}
