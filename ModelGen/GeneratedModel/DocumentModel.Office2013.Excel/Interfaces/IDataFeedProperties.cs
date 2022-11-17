namespace DocumentModel.Office2013.Excel;

public interface IDataFeedProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public string? Connection { get ; set; }

  public IDbTables? DbTables { get ; set; }

}
