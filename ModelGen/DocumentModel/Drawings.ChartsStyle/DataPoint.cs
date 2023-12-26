namespace DocumentModel.Drawings.ChartsStyle;


/// <summary>
///   Defines the DataPoint Class.
/// </summary>
public partial class DataPoint: ModelElement<DXO13DCS.DataPoint>
{
  public DataPoint(): base(){ }
  
  public DataPoint(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DataPoint(DXO13DCS.DataPoint openXmlElement): base(openXmlElement) { }
  
}
