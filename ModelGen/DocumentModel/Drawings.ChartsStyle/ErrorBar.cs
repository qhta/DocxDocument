namespace DocumentModel.Drawings.ChartsStyle;


/// <summary>
///   Defines the ErrorBar Class.
/// </summary>
public partial class ErrorBar: ModelElement<DXO13DCS.ErrorBar>
{
  public ErrorBar(): base(){ }
  
  public ErrorBar(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ErrorBar(DXO13DCS.ErrorBar openXmlElement): base(openXmlElement) { }
  
}
