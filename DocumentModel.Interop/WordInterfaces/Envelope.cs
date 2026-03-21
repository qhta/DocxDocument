namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an envelope.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope?view=word-pia"/>
public partial interface Envelope : InteropObject
{
  /// <summary>
  /// The address.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.address?view=word-pia"/>
  public Range Address { get; }

  /// <summary>
  /// The return address.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.returnaddress?view=word-pia"/>
  public Range ReturnAddress { get; }

  /// <summary>
  /// The default print bar code.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.defaultprintbarcode?view=word-pia"/>
  public bool DefaultPrintBarCode { get; set; }

  /// <summary>
  /// The default print fima.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.defaultprintfima?view=word-pia"/>
  public bool DefaultPrintFIMA { get; set; }

  /// <summary>
  /// The default height.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.defaultheight?view=word-pia"/>
  public float DefaultHeight { get; set; }

  /// <summary>
  /// The default width.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.defaultwidth?view=word-pia"/>
  public float DefaultWidth { get; set; }

  /// <summary>
  /// The default size.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.defaultsize?view=word-pia"/>
  public string DefaultSize { get; set; }

  /// <summary>
  /// The default omit return address.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.defaultomitreturnaddress?view=word-pia"/>
  public bool DefaultOmitReturnAddress { get; set; }

  /// <summary>
  /// The feed source.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.feedsource?view=word-pia"/>
  public WdPaperTray FeedSource { get; set; }

  /// <summary>
  /// The address from left.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.addressfromleft?view=word-pia"/>
  public float AddressFromLeft { get; set; }

  /// <summary>
  /// The address from top.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.addressfromtop?view=word-pia"/>
  public float AddressFromTop { get; set; }

  /// <summary>
  /// The return address from left.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.returnaddressfromleft?view=word-pia"/>
  public float ReturnAddressFromLeft { get; set; }

  /// <summary>
  /// The return address from top.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.returnaddressfromtop?view=word-pia"/>
  public float ReturnAddressFromTop { get; set; }

  /// <summary>
  /// The address style.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.addressstyle?view=word-pia"/>
  public Style AddressStyle { get; }

  /// <summary>
  /// The return address style.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.returnaddressstyle?view=word-pia"/>
  public Style ReturnAddressStyle { get; }

  /// <summary>
  /// The default orientation.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.defaultorientation?view=word-pia"/>
  public WdEnvelopeOrientation DefaultOrientation { get; set; }

  /// <summary>
  /// The default face up.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.defaultfaceup?view=word-pia"/>
  public bool DefaultFaceUp { get; set; }

  /// <summary>
  /// The vertical.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.vertical?view=word-pia"/>
  public bool Vertical { get; set; }

  /// <summary>
  /// The recipient namefrom left.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.recipientnamefromleft?view=word-pia"/>
  public float RecipientNamefromLeft { get; set; }

  /// <summary>
  /// The recipient namefrom top.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.recipientnamefromtop?view=word-pia"/>
  public float RecipientNamefromTop { get; set; }

  /// <summary>
  /// The recipient postalfrom left.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.recipientpostalfromleft?view=word-pia"/>
  public float RecipientPostalfromLeft { get; set; }

  /// <summary>
  /// The recipient postalfrom top.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.recipientpostalfromtop?view=word-pia"/>
  public float RecipientPostalfromTop { get; set; }

  /// <summary>
  /// The sender namefrom left.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.sendernamefromleft?view=word-pia"/>
  public float SenderNamefromLeft { get; set; }

  /// <summary>
  /// The sender namefrom top.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.sendernamefromtop?view=word-pia"/>
  public float SenderNamefromTop { get; set; }

  /// <summary>
  /// The sender postalfrom left.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.senderpostalfromleft?view=word-pia"/>
  public float SenderPostalfromLeft { get; set; }

  /// <summary>
  /// The sender postalfrom top.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.senderpostalfromtop?view=word-pia"/>
  public float SenderPostalfromTop { get; set; }
}
