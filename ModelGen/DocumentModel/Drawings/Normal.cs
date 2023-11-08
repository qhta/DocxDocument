namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a normal vector.  To be more precise, this attribute defines a vector normal to the face of the backdrop plane.
/// </summary>
public partial class Normal: ModelElement<DXD.Normal>
{
  public Normal(): base(){ }
  
  public Normal(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Normal(DXD.Normal openXmlElement): base(openXmlElement) { }
  
}
