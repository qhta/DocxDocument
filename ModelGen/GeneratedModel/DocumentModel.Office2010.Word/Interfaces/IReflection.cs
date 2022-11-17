namespace DocumentModel.Office2010.Word;

public interface IReflection // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public long? BlurRadius { get ; set; }
  
  public int? StartingOpacity { get ; set; }
  
  public int? StartPosition { get ; set; }
  
  public int? EndingOpacity { get ; set; }
  
  public int? EndPosition { get ; set; }
  
  public long? DistanceFromText { get ; set; }
  
  public int? DirectionAngle { get ; set; }
  
  public int? FadeDirection { get ; set; }
  
  public int? HorizontalScalingFactor { get ; set; }
  
  public int? VerticalScalingFactor { get ; set; }
  
  public int? HorizontalSkewAngle { get ; set; }
  
  public int? VerticalSkewAngle { get ; set; }
  
  public DocumentModel.Office2010.Word.RectangleAlignment? Alignment { get ; set; }
  
}
