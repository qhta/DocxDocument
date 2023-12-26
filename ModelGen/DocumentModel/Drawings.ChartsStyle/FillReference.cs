namespace DocumentModel.Drawings.ChartsStyle;


/// <summary>
///   Defines the FillReference Class.
/// </summary>
public partial class FillReference: ModelElement<DXO13DCS.FillReference>
{
  public FillReference(): base(){ }
  
  public FillReference(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FillReference(DXO13DCS.FillReference openXmlElement): base(openXmlElement) { }
  
}
