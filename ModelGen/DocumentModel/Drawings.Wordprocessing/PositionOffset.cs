namespace DocumentModel.Drawings.Wordprocessing;


/// <summary>
///   Defines the PositionOffset Class.
/// </summary>
public partial class PositionOffset: ModelElement<DXDW.PositionOffset>
{
  public PositionOffset(): base(){ }
  
  public PositionOffset(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PositionOffset(DXDW.PositionOffset openXmlElement): base(openXmlElement) { }
  
}
