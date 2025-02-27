namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies whether the right indent shall be automatically adjusted for the given paragraph when a document grid has been defined for the current section using the docGrid element, modifying of the current right indent used on this paragraph.
/// </summary>
public partial class AdjustRightIndent: ModelElement<DXW.AdjustRightIndent>
{
  public AdjustRightIndent(): base(){ }
  
  public AdjustRightIndent(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AdjustRightIndent(DXW.AdjustRightIndent openXmlElement): base(openXmlElement) { }
  
}
