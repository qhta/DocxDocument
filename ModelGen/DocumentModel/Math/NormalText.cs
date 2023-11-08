namespace DocumentModel.Math;


/// <summary>
///   Normal Text.
/// </summary>
public partial class NormalText: ModelElement<DXM.NormalText>
{
  public NormalText(): base(){ }
  
  public NormalText(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NormalText(DXM.NormalText openXmlElement): base(openXmlElement) { }
  
}
