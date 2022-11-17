namespace DocumentModel.Wordprocessing;

public interface ITableCellLeftMargin // : DocumentFormat.OpenXml.Wordprocessing.TableWidthDxaNilType
{
  public short? Width { get ; set; }
  
  public TableWidth? Type { get ; set; }
  
}
