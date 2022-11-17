namespace DocumentModel.Wordprocessing;

public interface ITableStyleConditionalFormattingTableCellProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Wordprocessing.ITableCellBorders? TableCellBorders { get ; set; }
  
  public IShading? Shading { get ; set; }
  
  public INoWrap? NoWrap { get ; set; }
  
  public ITableCellMargin? TableCellMargin { get ; set; }
  
  public ITableCellVerticalAlignment? TableCellVerticalAlignment { get ; set; }
  
}
