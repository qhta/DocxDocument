namespace DocumentModel.Wordprocessing;


/// <summary>
///   Break.
/// </summary>
public partial class Break: ModelElement<DXW.Break>
{
  public Break(): base(){ }
  
  public Break(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Break(DXW.Break openXmlElement): base(openXmlElement) { }
  
}
