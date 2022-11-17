namespace DocumentModel.Drawing;

public interface ITableCellTextStyle // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public BooleanStyle? Bold { get ; set; }

  public BooleanStyle? Italic { get ; set; }

}
