namespace DocumentModel.Math;


/// <summary>
///   Intra-Equation Spacing.
/// </summary>
public partial class IntraSpacing: ModelElement<DXM.IntraSpacing>
{
  public IntraSpacing(): base(){ }
  
  public IntraSpacing(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public IntraSpacing(DXM.IntraSpacing openXmlElement): base(openXmlElement) { }
  
}
