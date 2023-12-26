namespace DocumentModel.Drawings.ChartsStyle;


/// <summary>
///   Defines the DownBar Class.
/// </summary>
public partial class DownBar: ModelElement<DXO13DCS.DownBar>
{
  public DownBar(): base(){ }
  
  public DownBar(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DownBar(DXO13DCS.DownBar openXmlElement): base(openXmlElement) { }
  
}
