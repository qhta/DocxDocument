namespace DocumentModel.Drawing;

public interface IReflection // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public long? BlurRadius { get ; set; }

  public int? StartOpacity { get ; set; }

  public int? StartPosition { get ; set; }

  public int? EndAlpha { get ; set; }

  public int? EndPosition { get ; set; }

  public long? Distance { get ; set; }

  public int? Direction { get ; set; }

  public int? FadeDirection { get ; set; }

  public int? HorizontalRatio { get ; set; }

  public int? VerticalRatio { get ; set; }

  public int? HorizontalSkew { get ; set; }

  public int? VerticalSkew { get ; set; }

  public DocumentModel.Drawing.RectangleAlignment? Alignment { get ; set; }

  public bool? RotateWithShape { get ; set; }

}
