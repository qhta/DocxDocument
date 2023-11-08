namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a vector representing up.  To be more precise, this attribute defines a vector representing up in relation to the face of the backdrop plane.
/// </summary>
public partial class UpVector: ModelElement<DXD.UpVector>
{
  public UpVector(): base(){ }
  
  public UpVector(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public UpVector(DXD.UpVector openXmlElement): base(openXmlElement) { }
  
}
