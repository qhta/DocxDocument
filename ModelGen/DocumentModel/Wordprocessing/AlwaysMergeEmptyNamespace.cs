namespace DocumentModel.Wordprocessing;


/// <summary>
///   Do Not Mark Custom XML Elements With No Namespace As Invalid.
/// </summary>
public partial class AlwaysMergeEmptyNamespace: ModelElement<DXW.AlwaysMergeEmptyNamespace>
{
  public AlwaysMergeEmptyNamespace(): base(){ }
  
  public AlwaysMergeEmptyNamespace(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AlwaysMergeEmptyNamespace(DXW.AlwaysMergeEmptyNamespace openXmlElement): base(openXmlElement) { }
  
}
