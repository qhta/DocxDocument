namespace DocumentModel.Wordprocessing;

public interface IPreviousTableProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Wordprocessing.ITableStyle? TableStyle { get ; set; }
  
  public ITablePositionProperties? TablePositionProperties { get ; set; }
  
  public ITableOverlap? TableOverlap { get ; set; }
  
  public IBiDiVisual? BiDiVisual { get ; set; }
  
  public ITableWidth? TableWidth { get ; set; }
  
  public ITableJustification? TableJustification { get ; set; }
  
  public ITableCellSpacing? TableCellSpacing { get ; set; }
  
  public ITableIndentation? TableIndentation { get ; set; }
  
  public ITableBorders? TableBorders { get ; set; }
  
  public IShading? Shading { get ; set; }
  
  public ITableLayout? TableLayout { get ; set; }
  
  public ITableCellMarginDefault? TableCellMarginDefault { get ; set; }
  
  public ITableLook? TableLook { get ; set; }
  
  public ITableCaption? TableCaption { get ; set; }
  
  public ITableDescription? TableDescription { get ; set; }
  
}
