namespace DocumentModel.Wordprocessing;


/// <summary>
///   Merged Document To E-Mail Attachment.
/// </summary>
public partial class MailAsAttachment: ModelElement<DXW.MailAsAttachment>
{
  public MailAsAttachment(): base(){ }
  
  public MailAsAttachment(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MailAsAttachment(DXW.MailAsAttachment openXmlElement): base(openXmlElement) { }
  
}
