namespace DocumentModel.Wordprocessing;


/// <summary>
///   Data Source Table Name.
/// </summary>
public partial class DataSourceTableName: ModelElement<DXW.DataSourceTableName>
{
  public DataSourceTableName(): base(){ }
  
  public DataSourceTableName(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DataSourceTableName(DXW.DataSourceTableName openXmlElement): base(openXmlElement) { }
  
}
