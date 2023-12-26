namespace DocumentModel.Drawings.ChartsStyle;


/// <summary>
///   Defines the DropLine Class.
/// </summary>
public partial class DropLine: ModelElement<DXO13DCS.DropLine>
{
  public DropLine(): base(){ }
  
  public DropLine(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DropLine(DXO13DCS.DropLine openXmlElement): base(openXmlElement) { }
  
}
