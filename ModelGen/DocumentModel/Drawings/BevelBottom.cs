namespace DocumentModel.Drawings;


/// <summary>
///   This element holds the properties associated with defining a bevel on the bottom or back face of a shape.
/// </summary>
public partial class BevelBottom: ModelElement<DXD.BevelBottom>
{
  public BevelBottom(): base(){ }
  
  public BevelBottom(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BevelBottom(DXD.BevelBottom openXmlElement): base(openXmlElement) { }
  
}
