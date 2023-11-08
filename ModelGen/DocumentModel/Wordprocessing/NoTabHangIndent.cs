namespace DocumentModel.Wordprocessing;


/// <summary>
///   Do Not Create Custom Tab Stop for Hanging Indent.
/// </summary>
public partial class NoTabHangIndent: ModelElement<DXW.NoTabHangIndent>
{
  public NoTabHangIndent(): base(){ }
  
  public NoTabHangIndent(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NoTabHangIndent(DXW.NoTabHangIndent openXmlElement): base(openXmlElement) { }
  
}
