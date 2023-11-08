namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that the nearest ancestor structured document tag shall be of type equation.
/// </summary>
public partial class SdtContentEquation: ModelElement<DXW.SdtContentEquation>
{
  public SdtContentEquation(): base(){ }
  
  public SdtContentEquation(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SdtContentEquation(DXW.SdtContentEquation openXmlElement): base(openXmlElement) { }
  
}
