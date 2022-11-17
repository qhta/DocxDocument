namespace DocumentModel.Office2016.Drawing.ChartDrawing;

public interface IValueColors // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IMinColorSolidColorFillProperties? MinColorSolidColorFillProperties { get ; set; }
  
  public IMidColorSolidColorFillProperties? MidColorSolidColorFillProperties { get ; set; }
  
  public IMaxColorSolidColorFillProperties? MaxColorSolidColorFillProperties { get ; set; }
  
}
