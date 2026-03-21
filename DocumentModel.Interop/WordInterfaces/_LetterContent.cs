namespace DocumentModel.Interop.Word;

/// <summary>
/// This is a primary interface in a COM coclass that is required by managed code for interoperability with the corresponding COM object. Use this primary interface only when the method you want to use shares the same name as an event of the COM object; in this case, cast to this interface to call the method, and cast to the latest events interface to connect to the event. Otherwise, use the .NET interface that is derived from the COM coclass to access methods, properties, and events of the COM object. For more information about the COM obect, see LetterContent.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent?view=word-pia"/>
public interface _LetterContent : InteropObject
{
  /// <summary>
  /// The duplicate.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.duplicate?view=word-pia"/>
  public LetterContent Duplicate { get; }
  /// <summary>
  /// The date format.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.dateformat?view=word-pia"/>
  public string DateFormat { get; set; }
  /// <summary>
  /// The include header footer.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.includeheaderfooter?view=word-pia"/>
  public bool IncludeHeaderFooter { get; set; }
  /// <summary>
  /// The page design.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.pagedesign?view=word-pia"/>
  public string PageDesign { get; set; }
  /// <summary>
  /// The letter style.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.letterstyle?view=word-pia"/>
  public WdLetterStyle LetterStyle { get; set; }
  /// <summary>
  /// The letterhead.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.letterhead?view=word-pia"/>
  public bool Letterhead { get; set; }
  /// <summary>
  /// The letterhead location.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.letterheadlocation?view=word-pia"/>
  public WdLetterheadLocation LetterheadLocation { get; set; }
  /// <summary>
  /// The letterhead size.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.letterheadsize?view=word-pia"/>
  public float LetterheadSize { get; set; }
  /// <summary>
  /// The recipient name.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.recipientname?view=word-pia"/>
  public string RecipientName { get; set; }
  /// <summary>
  /// The recipient address.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.recipientaddress?view=word-pia"/>
  public string RecipientAddress { get; set; }
  /// <summary>
  /// The salutation.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.salutation?view=word-pia"/>
  public string Salutation { get; set; }
  /// <summary>
  /// The salutation type.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.salutationtype?view=word-pia"/>
  public WdSalutationType SalutationType { get; set; }
  /// <summary>
  /// The recipient reference.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.recipientreference?view=word-pia"/>
  public string RecipientReference { get; set; }
  /// <summary>
  /// The mailing instructions.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.mailinginstructions?view=word-pia"/>
  public string MailingInstructions { get; set; }
  /// <summary>
  /// The attention line.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.attentionline?view=word-pia"/>
  public string AttentionLine { get; set; }
  /// <summary>
  /// The subject.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.subject?view=word-pia"/>
  public string Subject { get; set; }
  /// <summary>
  /// The enclosure number.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.enclosurenumber?view=word-pia"/>
  public int EnclosureNumber { get; set; }
  /// <summary>
  /// The cclist.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.cclist?view=word-pia"/>
  public string CCList { get; set; }
  /// <summary>
  /// The return address.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.returnaddress?view=word-pia"/>
  public string ReturnAddress { get; set; }
  /// <summary>
  /// The sender name.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.sendername?view=word-pia"/>
  public string SenderName { get; set; }
  /// <summary>
  /// The closing.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.closing?view=word-pia"/>
  public string Closing { get; set; }
  /// <summary>
  /// The sender company.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.sendercompany?view=word-pia"/>
  public string SenderCompany { get; set; }
  /// <summary>
  /// The sender job title.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.senderjobtitle?view=word-pia"/>
  public string SenderJobTitle { get; set; }
  /// <summary>
  /// The sender initials.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.senderinitials?view=word-pia"/>
  public string SenderInitials { get; set; }
  /// <summary>
  /// The info block.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.infoblock?view=word-pia"/>
  public bool InfoBlock { get; set; }
  /// <summary>
  /// The recipient code.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.recipientcode?view=word-pia"/>
  public string RecipientCode { get; set; }
  /// <summary>
  /// The recipient gender.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.recipientgender?view=word-pia"/>
  public WdSalutationGender RecipientGender { get; set; }
  /// <summary>
  /// The return address short form.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.returnaddressshortform?view=word-pia"/>
  public string ReturnAddressShortForm { get; set; }
  /// <summary>
  /// The sender city.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.sendercity?view=word-pia"/>
  public string SenderCity { get; set; }
  /// <summary>
  /// The sender code.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.sendercode?view=word-pia"/>
  public string SenderCode { get; set; }
  /// <summary>
  /// The sender gender.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.sendergender?view=word-pia"/>
  public WdSalutationGender SenderGender { get; set; }
  /// <summary>
  /// The sender reference.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._lettercontent.senderreference?view=word-pia"/>
  public string SenderReference { get; set; }

}
