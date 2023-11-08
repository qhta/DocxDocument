namespace DocumentModel.Wordprocessing;


/// <summary>
///   First Row of Data Source Contains Column Names.
/// </summary>
public partial class FirstRowHeader: ModelElement<DXW.FirstRowHeader>
{
  public FirstRowHeader(): base(){ }
  
  public FirstRowHeader(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FirstRowHeader(DXW.FirstRowHeader openXmlElement): base(openXmlElement) { }
  
}
