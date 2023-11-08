namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies whether the paragraph indents should be interpreted as mirrored indents. When this element is present, the start indent shall become the inside indent (the one closest to the binding) and the end indent shall become the outside indent (the one furthest from the binding).
/// </summary>
public partial class MirrorIndents: ModelElement<DXW.MirrorIndents>
{
  public MirrorIndents(): base(){ }
  
  public MirrorIndents(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MirrorIndents(DXW.MirrorIndents openXmlElement): base(openXmlElement) { }
  
}
