namespace DocumentModel.Drawings.Wordprocessing;


/// <summary>
///   Relative Horizontal Alignment.
/// </summary>
public partial class HorizontalAlignment: ModelElement<DXDW.HorizontalAlignment>
{
  public HorizontalAlignment(): base(){ }
  
  public HorizontalAlignment(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public HorizontalAlignment(DXDW.HorizontalAlignment openXmlElement): base(openXmlElement) { }
  
}
