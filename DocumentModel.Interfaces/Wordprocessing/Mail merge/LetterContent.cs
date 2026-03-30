namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the elements of a letter created by the Letter Wizard as part of the requested batch update sourced from the local Word PIA documentation set.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.lettercontent?view=word-pia"/>
public interface LetterContent
{

  /// <summary>
  /// Gets a duplicate of the letter content.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.duplicate?view=word-pia"/>
  public LetterContent Duplicate { get; }
  /// <summary>
  /// Gets or sets the date format for the letter.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.dateformat?view=word-pia"/>
  public string DateFormat { get; set; }
  /// <summary>
  /// Gets or sets a value indicating whether to include the header and footer.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.includeheaderfooter?view=word-pia"/>
  public bool IncludeHeaderFooter { get; set; }
  /// <summary>
  /// Gets or sets the page design template name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.pagedesign?view=word-pia"/>
  public string PageDesign { get; set; }
  /// <summary>
  /// Gets or sets the letter style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.letterstyle?view=word-pia"/>
  public LetterStyle LetterStyle { get; set; }
  /// <summary>
  /// Gets or sets a value indicating whether letterhead is used.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.letterhead?view=word-pia"/>
  public bool Letterhead { get; set; }
  /// <summary>
  /// Gets or sets the letterhead location.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.letterheadlocation?view=word-pia"/>
  public LetterheadLocation LetterheadLocation { get; set; }
  /// <summary>
  /// Gets or sets the letterhead size.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.letterheadsize?view=word-pia"/>
  public float LetterheadSize { get; set; }
  /// <summary>
  /// Gets or sets the recipient name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.recipientname?view=word-pia"/>
  public string RecipientName { get; set; }
  /// <summary>
  /// Gets or sets the recipient address.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.recipientaddress?view=word-pia"/>
  public string RecipientAddress { get; set; }
  /// <summary>
  /// Gets or sets the salutation text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.salutation?view=word-pia"/>
  public string Salutation { get; set; }
  /// <summary>
  /// Gets or sets the salutation type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.salutationtype?view=word-pia"/>
  public SalutationType SalutationType { get; set; }
  /// <summary>
  /// Gets or sets the recipient reference.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.recipientreference?view=word-pia"/>
  public string RecipientReference { get; set; }
  /// <summary>
  /// Gets or sets the mailing instructions.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.mailinginstructions?view=word-pia"/>
  public string MailingInstructions { get; set; }
  /// <summary>
  /// Gets or sets the attention line.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.attentionline?view=word-pia"/>
  public string AttentionLine { get; set; }
  /// <summary>
  /// Gets or sets the subject.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.subject?view=word-pia"/>
  public string Subject { get; set; }
  /// <summary>
  /// Gets or sets the number of enclosures.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.enclosurenumber?view=word-pia"/>
  public int EnclosureNumber { get; set; }
  /// <summary>
  /// Gets or sets the carbon-copy (CC) list.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.cclist?view=word-pia"/>
  public string CCList { get; set; }
  /// <summary>
  /// Gets or sets the return address.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.returnaddress?view=word-pia"/>
  public string ReturnAddress { get; set; }
  /// <summary>
  /// Gets or sets the sender name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.sendername?view=word-pia"/>
  public string SenderName { get; set; }
  /// <summary>
  /// Gets or sets the closing text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.closing?view=word-pia"/>
  public string Closing { get; set; }
  /// <summary>
  /// Gets or sets the sender company.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.sendercompany?view=word-pia"/>
  public string SenderCompany { get; set; }
  /// <summary>
  /// Gets or sets the sender job title.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.senderjobtitle?view=word-pia"/>
  public string SenderJobTitle { get; set; }
  /// <summary>
  /// Gets or sets the sender initials.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.senderinitials?view=word-pia"/>
  public string SenderInitials { get; set; }
  /// <summary>
  /// Gets or sets a value indicating whether to include the information block.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.infoblock?view=word-pia"/>
  public bool InfoBlock { get; set; }
  /// <summary>
  /// Gets or sets the recipient postal code.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.recipientcode?view=word-pia"/>
  public string RecipientCode { get; set; }
  /// <summary>
  /// Gets or sets the recipient gender used for salutation.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.recipientgender?view=word-pia"/>
  public SalutationGender RecipientGender { get; set; }
  /// <summary>
  /// Gets or sets the short-form return address.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.returnaddressshortform?view=word-pia"/>
  public string ReturnAddressShortForm { get; set; }
  /// <summary>
  /// Gets or sets the sender city.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.sendercity?view=word-pia"/>
  public string SenderCity { get; set; }
  /// <summary>
  /// Gets or sets the sender postal code.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.sendercode?view=word-pia"/>
  public string SenderCode { get; set; }
  /// <summary>
  /// Gets or sets the sender gender used for salutation.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.sendergender?view=word-pia"/>
  public SalutationGender SenderGender { get; set; }
  /// <summary>
  /// Gets or sets the sender reference.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.senderreference?view=word-pia"/>
  public string SenderReference { get; set; }
}
