namespace DocumentModel.Office2010.Drawing.ChartDrawing;

public interface ITransform2D // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public int? Rotation { get ; set; }
  
  public bool? HorizontalFlip { get ; set; }
  
  public bool? VerticalFlip { get ; set; }
  
  public IOffset? Offset { get ; set; }
  
  public IExtents? Extents { get ; set; }
  
}
