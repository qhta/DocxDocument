namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the location of the bounding box of an object. Effects on an object are not included in this bounding box.
/// </summary>
public partial class Offset: ModelElement<DXD.Offset>
{
  public Offset(): base(){ }
  
  public Offset(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Offset(DXD.Offset openXmlElement): base(openXmlElement) { }
  
}
