namespace DocumentModel.Drawings;


/// <summary>
///   This element holds the properties associated with defining a bevel on the top or front face of a shape.
/// </summary>
public partial class BevelTop: ModelElement<DXD.BevelTop>
{
  public BevelTop(): base(){ }
  
  public BevelTop(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BevelTop(DXD.BevelTop openXmlElement): base(openXmlElement) { }
  
}
