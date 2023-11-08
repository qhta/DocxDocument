namespace DocumentModel.Wordprocessing;


/// <summary>
///   Do Not Add Leading Between Lines of Text.
/// </summary>
public partial class NoLeading: ModelElement<DXW.NoLeading>
{
  public NoLeading(): base(){ }
  
  public NoLeading(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NoLeading(DXW.NoLeading openXmlElement): base(openXmlElement) { }
  
}
