namespace DocumentModel.Math;


/// <summary>
///   Inter-Equation Spacing.
/// </summary>
public partial class InterSpacing: ModelElement<DXM.InterSpacing>
{
  public InterSpacing(): base(){ }
  
  public InterSpacing(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public InterSpacing(DXM.InterSpacing openXmlElement): base(openXmlElement) { }
  
}
