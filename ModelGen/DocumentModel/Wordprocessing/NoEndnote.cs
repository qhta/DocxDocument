namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the NoEndnote Class.
/// </summary>
public partial class NoEndnote: ModelElement<DXW.NoEndnote>
{
  public NoEndnote(): base(){ }
  
  public NoEndnote(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NoEndnote(DXW.NoEndnote openXmlElement): base(openXmlElement) { }
  
}
