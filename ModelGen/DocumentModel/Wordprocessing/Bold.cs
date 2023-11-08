namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies whether the bold property shall be applied to all non-complex script characters in the contents of this run when displayed in a document.
/// </summary>
public partial class Bold: ModelElement<DXW.Bold>
{
  public Bold(): base(){ }
  
  public Bold(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Bold(DXW.Bold openXmlElement): base(openXmlElement) { }
  
}
