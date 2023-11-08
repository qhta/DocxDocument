namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the amount by which each character shall be expanded or when the character is rendered in the document. This property has an of stretching or compressing each character in the run, as opposed to the spacing element which expands/compresses the text by adding additional character pitch but not changing the width of the actual characters displayed on the line.
/// </summary>
public partial class Width: ModelElement<DXW.Width>
{
  public Width(): base(){ }
  
  public Width(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Width(DXW.Width openXmlElement): base(openXmlElement) { }
  
}
