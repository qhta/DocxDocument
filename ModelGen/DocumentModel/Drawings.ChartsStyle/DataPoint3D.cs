namespace DocumentModel.Drawings.ChartsStyle;


/// <summary>
///   Defines the DataPoint3D Class.
/// </summary>
public partial class DataPoint3D: ModelElement<DXO13DCS.DataPoint3D>
{
  public DataPoint3D(): base(){ }
  
  public DataPoint3D(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DataPoint3D(DXO13DCS.DataPoint3D openXmlElement): base(openXmlElement) { }
  
}
