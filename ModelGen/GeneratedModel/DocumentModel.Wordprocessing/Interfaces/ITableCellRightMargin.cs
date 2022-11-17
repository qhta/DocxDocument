namespace DocumentModel.Wordprocessing;

public interface ITableCellRightMargin // : DocumentFormat.OpenXml.Wordprocessing.TableWidthDxaNilType
{
  public short? Width { get ; set; }
  
  public TableWidth? Type { get ; set; }
  
}
