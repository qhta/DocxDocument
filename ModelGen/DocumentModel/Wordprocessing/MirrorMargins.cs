namespace DocumentModel.Wordprocessing;


/// <summary>
///   Mirror Page Margins.
/// </summary>
public partial class MirrorMargins: ModelElement<DXW.MirrorMargins>
{
  public MirrorMargins(): base(){ }
  
  public MirrorMargins(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MirrorMargins(DXW.MirrorMargins openXmlElement): base(openXmlElement) { }
  
}
