namespace DocumentModel.Wordprocessing;


/// <summary>
///   Mail Merge Error Reporting Setting.
/// </summary>
public partial class CheckErrors: ModelElement<DXW.CheckErrors>
{
  public CheckErrors(): base(){ }
  
  public CheckErrors(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CheckErrors(DXW.CheckErrors openXmlElement): base(openXmlElement) { }
  
}
