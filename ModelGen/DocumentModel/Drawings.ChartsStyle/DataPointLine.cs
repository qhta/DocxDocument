namespace DocumentModel.Drawings.ChartsStyle;


/// <summary>
///   Defines the DataPointLine Class.
/// </summary>
public partial class DataPointLine: ModelElement<DXO13DCS.DataPointLine>
{
  public DataPointLine(): base(){ }
  
  public DataPointLine(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DataPointLine(DXO13DCS.DataPointLine openXmlElement): base(openXmlElement) { }
  
}
