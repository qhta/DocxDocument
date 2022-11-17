namespace DocumentModel.Wordprocessing;

public interface ITableIndentation // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public int? Width { get ; set; }
  
  public TableWidthUnit? Type { get ; set; }
  
}
