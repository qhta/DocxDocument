namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that this run contains WordprocessingML which shall be handled as though it was Office Open XML Math.
/// </summary>
public partial class OfficeMath: ModelElement<DXW.OfficeMath>
{
  public OfficeMath(): base(){ }
  
  public OfficeMath(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public OfficeMath(DXW.OfficeMath openXmlElement): base(openXmlElement) { }
  
}
