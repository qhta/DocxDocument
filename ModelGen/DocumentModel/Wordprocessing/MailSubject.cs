namespace DocumentModel.Wordprocessing;


/// <summary>
///   Merged E-mail or Fax Subject Line.
/// </summary>
public partial class MailSubject: ModelElement<DXW.MailSubject>
{
  public MailSubject(): base(){ }
  
  public MailSubject(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MailSubject(DXW.MailSubject openXmlElement): base(openXmlElement) { }
  
}
