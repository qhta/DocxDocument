namespace DocumentModel.Interop.Word;

/// <summary>
/// This is a primary interface in a COM coclass that is required by managed code for interoperability with the corresponding COM object. Use this primary interface only when the method you want to use shares the same name as an event of the COM object; in this case, cast to this interface to call the method, and cast to the latest events interface to connect to the event. Otherwise, use the .NET interface that is derived from the COM coclass to access methods, properties, and events of the COM object. For more information about the COM obect, see LetterContent.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent?view=word-pia"/>
public interface _LetterContent : InteropObject
{
  /// <summary>
  /// The duplicate.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.duplicate?view=word-pia"/>
  public LetterContent Duplicate { get; }
  /// <summary>
  /// The date format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.dateformat?view=word-pia"/>
  public string DateFormat { get; set; }
  /// <summary>
  /// The include header footer.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.includeheaderfooter?view=word-pia"/>
  public bool IncludeHeaderFooter { get; set; }
  /// <summary>
  /// The page design.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.pagedesign?view=word-pia"/>
  public string PageDesign { get; set; }
  /// <summary>
  /// The letter style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.letterstyle?view=word-pia"/>
  public WdLetterStyle LetterStyle { get; set; }
  /// <summary>
  /// The letterhead.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.letterhead?view=word-pia"/>
  public bool Letterhead { get; set; }
  /// <summary>
  /// The letterhead location.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.letterheadlocation?view=word-pia"/>
  public WdLetterheadLocation LetterheadLocation { get; set; }
  /// <summary>
  /// The letterhead size.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.letterheadsize?view=word-pia"/>
  public float LetterheadSize { get; set; }
  /// <summary>
  /// The recipient name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.recipientname?view=word-pia"/>
  public string RecipientName { get; set; }
  /// <summary>
  /// The recipient address.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.recipientaddress?view=word-pia"/>
  public string RecipientAddress { get; set; }
  /// <summary>
  /// The salutation.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.salutation?view=word-pia"/>
  public string Salutation { get; set; }
  /// <summary>
  /// The salutation type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.salutationtype?view=word-pia"/>
  public WdSalutationType SalutationType { get; set; }
  /// <summary>
  /// The recipient reference.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.recipientreference?view=word-pia"/>
  public string RecipientReference { get; set; }
  /// <summary>
  /// The mailing instructions.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.mailinginstructions?view=word-pia"/>
  public string MailingInstructions { get; set; }
  /// <summary>
  /// The attention line.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.attentionline?view=word-pia"/>
  public string AttentionLine { get; set; }
  /// <summary>
  /// The subject.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.subject?view=word-pia"/>
  public string Subject { get; set; }
  /// <summary>
  /// The enclosure number.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.enclosurenumber?view=word-pia"/>
  public int EnclosureNumber { get; set; }
  /// <summary>
  /// The cclist.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.cclist?view=word-pia"/>
  public string CCList { get; set; }
  /// <summary>
  /// The return address.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.returnaddress?view=word-pia"/>
  public string ReturnAddress { get; set; }
  /// <summary>
  /// The sender name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.sendername?view=word-pia"/>
  public string SenderName { get; set; }
  /// <summary>
  /// The closing.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.closing?view=word-pia"/>
  public string Closing { get; set; }
  /// <summary>
  /// The sender company.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.sendercompany?view=word-pia"/>
  public string SenderCompany { get; set; }
  /// <summary>
  /// The sender job title.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.senderjobtitle?view=word-pia"/>
  public string SenderJobTitle { get; set; }
  /// <summary>
  /// The sender initials.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.senderinitials?view=word-pia"/>
  public string SenderInitials { get; set; }
  /// <summary>
  /// The info block.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.infoblock?view=word-pia"/>
  public bool InfoBlock { get; set; }
  /// <summary>
  /// The recipient code.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.recipientcode?view=word-pia"/>
  public string RecipientCode { get; set; }
  /// <summary>
  /// The recipient gender.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.recipientgender?view=word-pia"/>
  public WdSalutationGender RecipientGender { get; set; }
  /// <summary>
  /// The return address short form.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.returnaddressshortform?view=word-pia"/>
  public string ReturnAddressShortForm { get; set; }
  /// <summary>
  /// The sender city.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.sendercity?view=word-pia"/>
  public string SenderCity { get; set; }
  /// <summary>
  /// The sender code.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.sendercode?view=word-pia"/>
  public string SenderCode { get; set; }
  /// <summary>
  /// The sender gender.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.sendergender?view=word-pia"/>
  public WdSalutationGender SenderGender { get; set; }
  /// <summary>
  /// The sender reference.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.senderreference?view=word-pia"/>
  public string SenderReference { get; set; }

}
