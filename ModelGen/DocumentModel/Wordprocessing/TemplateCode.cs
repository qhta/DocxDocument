namespace DocumentModel.Wordprocessing;


/// <summary>
///   Numbering Template Code.
/// </summary>
public partial class TemplateCode: ModelElement<DXW.TemplateCode>
{
  public TemplateCode(): base(){ }
  
  public TemplateCode(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TemplateCode(DXW.TemplateCode openXmlElement): base(openXmlElement) { }
  
}
