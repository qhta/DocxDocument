namespace DocumentModel.Office2016.Drawing.ChartDrawing;

public interface IValueColorPositions // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public int? Count { get ; set; }
  
  public IMinValueColorEndPosition? MinValueColorEndPosition { get ; set; }
  
  public IValueColorMiddlePosition? ValueColorMiddlePosition { get ; set; }
  
  public IMaxValueColorEndPosition? MaxValueColorEndPosition { get ; set; }
  
}
