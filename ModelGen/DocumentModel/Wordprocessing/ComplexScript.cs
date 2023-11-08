namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies whether the contents of this run shall be treated as complex script text regardless of their Unicode character values when determining the formatting for this run.
/// </summary>
public partial class ComplexScript: ModelElement<DXW.ComplexScript>
{
  public ComplexScript(): base(){ }
  
  public ComplexScript(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ComplexScript(DXW.ComplexScript openXmlElement): base(openXmlElement) { }
  
}
