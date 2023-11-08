namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the FormProtection Class.
/// </summary>
public partial class FormProtection: ModelElement<DXW.FormProtection>
{
  public FormProtection(): base(){ }
  
  public FormProtection(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FormProtection(DXW.FormProtection openXmlElement): base(openXmlElement) { }
  
}
