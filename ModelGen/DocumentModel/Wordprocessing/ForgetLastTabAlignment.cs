namespace DocumentModel.Wordprocessing;


/// <summary>
///   Ignore Width of Last Tab Stop When Aligning Paragraph If It Is Not Left Aligned.
/// </summary>
public partial class ForgetLastTabAlignment: ModelElement<DXW.ForgetLastTabAlignment>
{
  public ForgetLastTabAlignment(): base(){ }
  
  public ForgetLastTabAlignment(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ForgetLastTabAlignment(DXW.ForgetLastTabAlignment openXmlElement): base(openXmlElement) { }
  
}
