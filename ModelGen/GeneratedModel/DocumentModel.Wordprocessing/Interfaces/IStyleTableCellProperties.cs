namespace DocumentModel.Wordprocessing;

public interface IStyleTableCellProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IShading? Shading { get ; set; }
  
  public INoWrap? NoWrap { get ; set; }
  
  public ITableCellMargin? TableCellMargin { get ; set; }
  
  public ITableCellVerticalAlignment? TableCellVerticalAlignment { get ; set; }
  
}
