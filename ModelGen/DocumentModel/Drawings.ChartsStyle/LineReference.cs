namespace DocumentModel.Drawings.ChartsStyle;


/// <summary>
///   Defines the LineReference Class.
/// </summary>
public partial class LineReference: ModelElement<DXO13DCS.LineReference>
{
  public LineReference(): base(){ }
  
  public LineReference(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LineReference(DXO13DCS.LineReference openXmlElement): base(openXmlElement) { }
  
}
