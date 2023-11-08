namespace DocumentModel.Wordprocessing;


/// <summary>
///   Query Contains Link to External Query File.
/// </summary>
public partial class LinkToQuery: ModelElement<DXW.LinkToQuery>
{
  public LinkToQuery(): base(){ }
  
  public LinkToQuery(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LinkToQuery(DXW.LinkToQuery openXmlElement): base(openXmlElement) { }
  
}
