namespace DocumentModel.Drawings;


/// <summary>
///   Text Alignment Types
/// </summary>
public partial class TextAlignmentTypeValues: ModelElement<DXD.TextAlignmentTypeValues>
{
  public TextAlignmentTypeValues(): base(){ }
  
  public TextAlignmentTypeValues(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TextAlignmentTypeValues(DXD.TextAlignmentTypeValues openXmlElement): base(openXmlElement) { }
  
}
