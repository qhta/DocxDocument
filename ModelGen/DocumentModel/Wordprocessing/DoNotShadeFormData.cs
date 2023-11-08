namespace DocumentModel.Wordprocessing;


/// <summary>
///   Do Not Show Visual Indicator For Form Fields.
/// </summary>
public partial class DoNotShadeFormData: ModelElement<DXW.DoNotShadeFormData>
{
  public DoNotShadeFormData(): base(){ }
  
  public DoNotShadeFormData(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DoNotShadeFormData(DXW.DoNotShadeFormData openXmlElement): base(openXmlElement) { }
  
}
