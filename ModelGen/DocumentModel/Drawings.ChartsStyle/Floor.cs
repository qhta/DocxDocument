namespace DocumentModel.Drawings.ChartsStyle;


/// <summary>
///   Defines the Floor Class.
/// </summary>
public partial class Floor: ModelElement<DXO13DCS.Floor>
{
  public Floor(): base(){ }
  
  public Floor(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Floor(DXO13DCS.Floor openXmlElement): base(openXmlElement) { }
  
}
