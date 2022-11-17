namespace DocumentModel.Office2016.Excel;

public interface IRowColVisualOps // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public RowColVisualOp? Action { get ; set; }

  public bool? IsRow { get ; set; }

  public uint? Size { get ; set; }

  public bool? UserSized { get ; set; }

}
