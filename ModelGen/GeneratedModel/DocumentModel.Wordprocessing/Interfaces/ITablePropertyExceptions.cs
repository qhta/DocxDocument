namespace DocumentModel.Wordprocessing;

public interface ITablePropertyExceptions // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public ITableWidth? TableWidth { get ; set; }

  public ITableJustification? TableJustification { get ; set; }

  public ITableCellSpacing? TableCellSpacing { get ; set; }

  public ITableIndentation? TableIndentation { get ; set; }

  public ITableBorders? TableBorders { get ; set; }

  public IShading? Shading { get ; set; }

  public ITableLayout? TableLayout { get ; set; }

  public ITableCellMarginDefault? TableCellMarginDefault { get ; set; }

  public ITableLook? TableLook { get ; set; }

  public ITablePropertyExceptionsChange? TablePropertyExceptionsChange { get ; set; }

}
