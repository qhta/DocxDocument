namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies whether the bold property shall be applied to all complex script characters in the contents of this run when displayed in a document.
/// </summary>
public partial class BoldComplexScript: ModelElement<DXW.BoldComplexScript>
{
  public BoldComplexScript(): base(){ }
  
  public BoldComplexScript(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BoldComplexScript(DXW.BoldComplexScript openXmlElement): base(openXmlElement) { }
  
}
