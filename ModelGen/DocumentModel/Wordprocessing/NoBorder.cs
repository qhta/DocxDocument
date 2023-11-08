namespace DocumentModel.Wordprocessing;


/// <summary>
///   Do Not Display Frameset Splitters.
/// </summary>
public partial class NoBorder: ModelElement<DXW.NoBorder>
{
  public NoBorder(): base(){ }
  
  public NoBorder(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NoBorder(DXW.NoBorder openXmlElement): base(openXmlElement) { }
  
}
