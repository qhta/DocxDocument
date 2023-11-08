namespace DocumentModel.Drawings.Wordprocessing;


/// <summary>
///   Relative Vertical Alignment.
/// </summary>
public partial class VerticalAlignment: ModelElement<DXDW.VerticalAlignment>
{
  public VerticalAlignment(): base(){ }
  
  public VerticalAlignment(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public VerticalAlignment(DXDW.VerticalAlignment openXmlElement): base(openXmlElement) { }
  
}
