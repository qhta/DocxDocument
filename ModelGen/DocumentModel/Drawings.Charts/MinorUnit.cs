namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the MinorUnit Class.
/// </summary>
public partial class MinorUnit: ModelElement<DXDC.MinorUnit>
{
  public MinorUnit(): base(){ }
  
  public MinorUnit(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MinorUnit(DXDC.MinorUnit openXmlElement): base(openXmlElement) { }
  
}
