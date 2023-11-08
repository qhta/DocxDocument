namespace DocumentModel.Wordprocessing;


/// <summary>
///   Attached Document Template.
/// </summary>
public partial class AttachedTemplate: ModelElement<DXW.AttachedTemplate>
{
  public AttachedTemplate(): base(){ }
  
  public AttachedTemplate(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AttachedTemplate(DXW.AttachedTemplate openXmlElement): base(openXmlElement) { }
  
}
