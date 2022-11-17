namespace DocumentModel.Wordprocessing;

public interface ITableStyleConditionalFormattingTableProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public ITableJustification? TableJustification { get ; set; }

  public ITableCellSpacing? TableCellSpacing { get ; set; }

  public ITableIndentation? TableIndentation { get ; set; }

  public ITableBorders? TableBorders { get ; set; }

  public IShading? Shading { get ; set; }

  public ITableCellMarginDefault? TableCellMarginDefault { get ; set; }

}
