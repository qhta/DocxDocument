namespace DocumentModel.Drawings.Wordprocessing;


/// <summary>
///   No Text Wrapping.
/// </summary>
public partial class WrapNone: ModelElement<DXDW.WrapNone>
{
  public WrapNone(): base(){ }
  
  public WrapNone(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public WrapNone(DXDW.WrapNone openXmlElement): base(openXmlElement) { }
  
}
