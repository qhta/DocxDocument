
namespace DocumentModel.Interop.Core;

public partial interface OfficeDataSourceObject
{
  public string ConnectString { get; set; }
  public string Table { get; set; }
  public string DataSource { get; set; }
  public object Columns { get; }
  public int RowCount { get; }
  public object Filters { get; }
}
