namespace DocumentModel.Wordprocessing;


/// <summary>
///   Query For Data Source Records To Merge.
/// </summary>
public partial class Query: ModelElement<DXW.Query>
{
  public Query(): base(){ }
  
  public Query(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Query(DXW.Query openXmlElement): base(openXmlElement) { }
  
}
