namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies whether the italic property should be applied to all complex script characters in the contents of this run when displayed in a document.
/// </summary>
public partial class ItalicComplexScript: ModelElement<DXW.ItalicComplexScript>
{
  public ItalicComplexScript(): base(){ }
  
  public ItalicComplexScript(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ItalicComplexScript(DXW.ItalicComplexScript openXmlElement): base(openXmlElement) { }
  
}
