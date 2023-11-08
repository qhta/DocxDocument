namespace DocumentModel.Wordprocessing;


/// <summary>
///   Data Source File Path.
/// </summary>
public partial class DataSourceReference: ModelElement<DXW.DataSourceReference>
{
  public DataSourceReference(): base(){ }
  
  public DataSourceReference(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DataSourceReference(DXW.DataSourceReference openXmlElement): base(openXmlElement) { }
  
}
