namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the MajorUnit Class.
/// </summary>
public partial class MajorUnit: ModelElement<DXDC.MajorUnit>
{
  public MajorUnit(): base(){ }
  
  public MajorUnit(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MajorUnit(DXDC.MajorUnit openXmlElement): base(openXmlElement) { }
  
}
