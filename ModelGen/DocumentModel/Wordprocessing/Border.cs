namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies information about the border applied to the text in the current run.
/// </summary>
public partial class Border: ModelElement<DXW.Border>
{
  public Border(): base(){ }
  
  public Border(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Border(DXW.Border openXmlElement): base(openXmlElement) { }
  
}
