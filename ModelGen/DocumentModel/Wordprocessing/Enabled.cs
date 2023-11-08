namespace DocumentModel.Wordprocessing;


/// <summary>
///   Form Field Enabled.
/// </summary>
public partial class Enabled: ModelElement<DXW.Enabled>
{
  public Enabled(): base(){ }
  
  public Enabled(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Enabled(DXW.Enabled openXmlElement): base(openXmlElement) { }
  
}
