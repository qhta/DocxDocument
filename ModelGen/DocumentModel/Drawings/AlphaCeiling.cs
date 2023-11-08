namespace DocumentModel.Drawings;


/// <summary>
///   This element represents an alpha ceiling effect.
/// </summary>
public partial class AlphaCeiling: ModelElement<DXD.AlphaCeiling>
{
  public AlphaCeiling(): base(){ }
  
  public AlphaCeiling(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AlphaCeiling(DXD.AlphaCeiling openXmlElement): base(openXmlElement) { }
  
}
