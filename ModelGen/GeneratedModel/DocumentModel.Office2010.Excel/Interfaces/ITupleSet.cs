namespace DocumentModel.Office2010.Excel;

public interface ITupleSet // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public uint? RowCount { get ; set; }

  public uint? ColumnCount { get ; set; }

  public ITupleSetHeaders? TupleSetHeaders { get ; set; }

  public ITupleSetRows? TupleSetRows { get ; set; }

}
