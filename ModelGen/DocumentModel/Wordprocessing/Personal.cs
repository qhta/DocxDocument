namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that the parent style, when in use in the context of an e-mail message, was used by default to format all message text from one or more users.
/// </summary>
public partial class Personal: ModelElement<DXW.Personal>
{
  public Personal(): base(){ }
  
  public Personal(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Personal(DXW.Personal openXmlElement): base(openXmlElement) { }
  
}
