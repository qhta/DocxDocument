namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the style ID of the character style which shall be used to format the contents of this paragraph.
/// </summary>
public partial class RunStyle: ModelElement<DXW.RunStyle>
{
  public RunStyle(): base(){ }
  
  public RunStyle(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RunStyle(DXW.RunStyle openXmlElement): base(openXmlElement) { }
  
}
