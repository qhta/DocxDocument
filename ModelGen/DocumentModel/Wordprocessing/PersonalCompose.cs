namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that the parent style, when in use in the context of an e-mail message, can be used by default to format new message text within the e-mail message.
/// </summary>
public partial class PersonalCompose: ModelElement<DXW.PersonalCompose>
{
  public PersonalCompose(): base(){ }
  
  public PersonalCompose(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PersonalCompose(DXW.PersonalCompose openXmlElement): base(openXmlElement) { }
  
}
