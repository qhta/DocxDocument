namespace DocumentModel.Packaging;


/// <summary>
///   Defines the MailMergeRecipientDataPart
/// </summary>
public partial class MailMergeRecipientDataPart: ModelPartElement<DXPack.MailMergeRecipientDataPart>
{
  public MailMergeRecipientDataPart(): base(){ }
  
  public MailMergeRecipientDataPart(DXPack.OpenXmlPart openXmlElement): base(openXmlElement) { }
  
  public MailMergeRecipientDataPart(DXPack.MailMergeRecipientDataPart openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Gets or sets the part's root element when the part's content type is MailMergeRecipientDataPartType.OpenXmlMailMergeRecipientData.
  ///               Setting this property will throw InvalidOperationException if the MailMergeRecipients property is not null.
  /// </summary>
  [DataMember]
  public DMW.Recipients? Recipients
  {
    get
    {
        return RecipientsConverter.CreateModelElement(_Element?.RootElement as DXW.Recipients);
    }
    set
    {
      if (value != null)
      {
         var rootElement = RecipientsConverter.CreateOpenXmlElement<DXW.Recipients>(value);
         if (rootElement != null)
           _ExistingElement.Recipients = rootElement;
      }
    }
  }
  
  [DataMember]
  public String? RelationshipType
  {
    get
    {
      return _Element?.RelationshipType;
    }
    set
    {
      _ExistingElement.RelationshipType = value;
    }
  }
  
}
