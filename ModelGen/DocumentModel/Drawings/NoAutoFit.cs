namespace DocumentModel.Drawings;


/// <summary>
///   No AutoFit.
/// </summary>
public partial class NoAutoFit: ModelElement<DXD.NoAutoFit>
{
  public NoAutoFit(): base(){ }
  
  public NoAutoFit(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NoAutoFit(DXD.NoAutoFit openXmlElement): base(openXmlElement) { }
  
}
