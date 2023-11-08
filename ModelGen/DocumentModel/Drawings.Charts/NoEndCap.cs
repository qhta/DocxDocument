namespace DocumentModel.Drawings.Charts;


/// <summary>
///   No End Cap.
/// </summary>
public partial class NoEndCap: ModelElement<DXDC.NoEndCap>
{
  public NoEndCap(): base(){ }
  
  public NoEndCap(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NoEndCap(DXDC.NoEndCap openXmlElement): base(openXmlElement) { }
  
}
