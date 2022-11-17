namespace DocumentModel.Drawing;

public interface IGradientFill // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public TileFlip? Flip { get ; set; }

  public bool? RotateWithShape { get ; set; }

  public DocumentModel.Drawing.IGradientStopList? GradientStopList { get ; set; }

}
