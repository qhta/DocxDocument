namespace DocumentModel.Drawings.ChartsStyle;


/// <summary>
///   Defines the DataLabel Class.
/// </summary>
public partial class DataLabel: ModelElement<DXO13DCS.DataLabel>
{
  public DataLabel(): base(){ }
  
  public DataLabel(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DataLabel(DXO13DCS.DataLabel openXmlElement): base(openXmlElement) { }
  
}
