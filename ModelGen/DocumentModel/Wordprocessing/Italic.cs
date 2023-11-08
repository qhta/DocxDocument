namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies whether the italic property should be applied to all non-complex script characters in the contents of this run when displayed in a document.
/// </summary>
public partial class Italic: ModelElement<DXW.Italic>
{
  public Italic(): base(){ }
  
  public Italic(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Italic(DXW.Italic openXmlElement): base(openXmlElement) { }
  
}
