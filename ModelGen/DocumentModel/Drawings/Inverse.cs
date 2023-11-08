namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the inverse of its input color.
/// </summary>
public partial class Inverse: ModelElement<DXD.Inverse>
{
  public Inverse(): base(){ }
  
  public Inverse(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Inverse(DXD.Inverse openXmlElement): base(openXmlElement) { }
  
}
