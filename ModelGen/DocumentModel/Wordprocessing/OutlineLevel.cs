namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the outline level which shall be associated with the current paragraph in the document. The outline level specifies an integer which defines the level of the associated text. This level shall not affect the appearance of the text in the document but shall be used to calculate the TOC field if the appropriate field switches have been set and can be used by consumers to provide additional application behavior.
/// </summary>
public partial class OutlineLevel: ModelElement<DXW.OutlineLevel>
{
  public OutlineLevel(): base(){ }
  
  public OutlineLevel(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public OutlineLevel(DXW.OutlineLevel openXmlElement): base(openXmlElement) { }
  
}
