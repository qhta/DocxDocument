namespace DocumentModel.Wordprocessing;

public interface IPreviousTableCellProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IConditionalFormatStyle? ConditionalFormatStyle { get ; set; }
  
  public ITableCellWidth? TableCellWidth { get ; set; }
  
  public IGridSpan? GridSpan { get ; set; }
  
  public IHorizontalMerge? HorizontalMerge { get ; set; }
  
  public IVerticalMerge? VerticalMerge { get ; set; }
  
  public DocumentModel.Wordprocessing.ITableCellBorders? TableCellBorders { get ; set; }
  
  public IShading? Shading { get ; set; }
  
  public INoWrap? NoWrap { get ; set; }
  
  public ITableCellMargin? TableCellMargin { get ; set; }
  
  public ITextDirection? TextDirection { get ; set; }
  
  public ITableCellFitText? TableCellFitText { get ; set; }
  
  public ITableCellVerticalAlignment? TableCellVerticalAlignment { get ; set; }
  
  public IHideMark? HideMark { get ; set; }
  
}
