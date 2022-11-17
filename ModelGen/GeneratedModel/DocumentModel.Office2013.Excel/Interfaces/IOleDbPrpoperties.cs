namespace DocumentModel.Office2013.Excel;

public interface IOleDbPrpoperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public string? Connection { get ; set; }

  public IDbTables? DbTables { get ; set; }

  public IDbCommand? DbCommand { get ; set; }

}
