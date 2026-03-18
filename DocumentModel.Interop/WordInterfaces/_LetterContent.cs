namespace DocumentModel.Interop;

/// <summary>
/// This is a primary interface in a COM coclass that is required by managed code for interoperability with the corresponding COM object. Use this primary interface only when the method you want to use shares the same name as an event of the COM object; in this case, cast to this interface to call the method, and cast to the latest events interface to connect to the event. Otherwise, use the .NET interface that is derived from the COM coclass to access methods, properties, and events of the COM object. For more information about the COM obect, see LetterContent.
/// </summary>
public interface _LetterContent : InteropObject
{
  /// <summary>
  /// The duplicate.
  /// </summary>
  public LetterContent Duplicate { get; }
  /// <summary>
  /// The date format.
  /// </summary>
  public string DateFormat { get; set; }
  /// <summary>
  /// The include header footer.
  /// </summary>
  public bool IncludeHeaderFooter { get; set; }
  /// <summary>
  /// The page design.
  /// </summary>
  public string PageDesign { get; set; }
  /// <summary>
  /// The letter style.
  /// </summary>
  public WdLetterStyle LetterStyle { get; set; }
  /// <summary>
  /// The letterhead.
  /// </summary>
  public bool Letterhead { get; set; }
  /// <summary>
  /// The letterhead location.
  /// </summary>
  public WdLetterheadLocation LetterheadLocation { get; set; }
  /// <summary>
  /// The letterhead size.
  /// </summary>
  public float LetterheadSize { get; set; }
  /// <summary>
  /// The recipient name.
  /// </summary>
  public string RecipientName { get; set; }
  /// <summary>
  /// The recipient address.
  /// </summary>
  public string RecipientAddress { get; set; }
  /// <summary>
  /// The salutation.
  /// </summary>
  public string Salutation { get; set; }
  /// <summary>
  /// The salutation type.
  /// </summary>
  public WdSalutationType SalutationType { get; set; }
  /// <summary>
  /// The recipient reference.
  /// </summary>
  public string RecipientReference { get; set; }
  /// <summary>
  /// The mailing instructions.
  /// </summary>
  public string MailingInstructions { get; set; }
  /// <summary>
  /// The attention line.
  /// </summary>
  public string AttentionLine { get; set; }
  /// <summary>
  /// The subject.
  /// </summary>
  public string Subject { get; set; }
  /// <summary>
  /// The enclosure number.
  /// </summary>
  public int EnclosureNumber { get; set; }
  /// <summary>
  /// The cclist.
  /// </summary>
  public string CCList { get; set; }
  /// <summary>
  /// The return address.
  /// </summary>
  public string ReturnAddress { get; set; }
  /// <summary>
  /// The sender name.
  /// </summary>
  public string SenderName { get; set; }
  /// <summary>
  /// The closing.
  /// </summary>
  public string Closing { get; set; }
  /// <summary>
  /// The sender company.
  /// </summary>
  public string SenderCompany { get; set; }
  /// <summary>
  /// The sender job title.
  /// </summary>
  public string SenderJobTitle { get; set; }
  /// <summary>
  /// The sender initials.
  /// </summary>
  public string SenderInitials { get; set; }
  /// <summary>
  /// The info block.
  /// </summary>
  public bool InfoBlock { get; set; }
  /// <summary>
  /// The recipient code.
  /// </summary>
  public string RecipientCode { get; set; }
  /// <summary>
  /// The recipient gender.
  /// </summary>
  public WdSalutationGender RecipientGender { get; set; }
  /// <summary>
  /// The return address short form.
  /// </summary>
  public string ReturnAddressShortForm { get; set; }
  /// <summary>
  /// The sender city.
  /// </summary>
  public string SenderCity { get; set; }
  /// <summary>
  /// The sender code.
  /// </summary>
  public string SenderCode { get; set; }
  /// <summary>
  /// The sender gender.
  /// </summary>
  public WdSalutationGender SenderGender { get; set; }
  /// <summary>
  /// The sender reference.
  /// </summary>
  public string SenderReference { get; set; }

}
