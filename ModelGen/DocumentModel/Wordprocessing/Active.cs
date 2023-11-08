namespace DocumentModel.Wordprocessing;


/// <summary>
///   Record Is Included in Mail Merge.
/// </summary>
public partial class Active: ModelElement<DXW.Active>
{
  public Active(): base(){ }
  
  public Active(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Active(DXW.Active openXmlElement): base(openXmlElement) { }
  
}
