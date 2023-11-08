namespace DocumentModel.Wordprocessing;


/// <summary>
///   Save Document as XML File through Custom XSL Transform.
/// </summary>
public partial class UseXsltWhenSaving: ModelElement<DXW.UseXsltWhenSaving>
{
  public UseXsltWhenSaving(): base(){ }
  
  public UseXsltWhenSaving(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public UseXsltWhenSaving(DXW.UseXsltWhenSaving openXmlElement): base(openXmlElement) { }
  
}
