namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents an envelope.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope?view=word-pia"/>
public partial interface IEnvelope : IModelObject
{
  /// <summary>
  /// Gets the delivery address on the envelope.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.address?view=word-pia"/>
  public IRange Address { get; }

  /// <summary>
  /// Gets the return address on the envelope.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.returnaddress?view=word-pia"/>
  public IRange ReturnAddress { get; }

  /// <summary>
  /// Gets or sets a value indicating whether POSTNET bar codes are printed by default.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.defaultprintbarcode?view=word-pia"/>
  public bool DefaultPrintBarCode { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets a value indicating whether Facing Identification Mark (FIM-A) marks are printed by default.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.defaultprintfima?view=word-pia"/>
  public bool DefaultPrintFIMA { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the default envelope height, in points.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.defaultheight?view=word-pia"/>
  public float DefaultHeight { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the default envelope width, in points.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.defaultwidth?view=word-pia"/>
  public float DefaultWidth { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the default envelope size name.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.defaultsize?view=word-pia"/>
  public string DefaultSize { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets a value indicating whether the return address is omitted by default.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.defaultomitreturnaddress?view=word-pia"/>
  public bool DefaultOmitReturnAddress { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the paper tray used to feed envelopes.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.feedsource?view=word-pia"/>
  public PaperTray FeedSource { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the distance, in points, from the left edge of the envelope to the delivery address.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.addressfromleft?view=word-pia"/>
  public float AddressFromLeft { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the distance, in points, from the top edge of the envelope to the delivery address.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.addressfromtop?view=word-pia"/>
  public float AddressFromTop { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the distance, in points, from the left edge of the envelope to the return address.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.returnaddressfromleft?view=word-pia"/>
  public float ReturnAddressFromLeft { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the distance, in points, from the top edge of the envelope to the return address.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.returnaddressfromtop?view=word-pia"/>
  public float ReturnAddressFromTop { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets the style used for the delivery address.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.addressstyle?view=word-pia"/>
  public IStyle AddressStyle { get; }

  /// <summary>
  /// Gets the style used for the return address.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.returnaddressstyle?view=word-pia"/>
  public IStyle ReturnAddressStyle { get; }

  /// <summary>
  /// Gets or sets the default envelope orientation.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.defaultorientation?view=word-pia"/>
  public EnvelopeOrientation DefaultOrientation { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets a value indicating whether envelopes are fed face up by default.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.defaultfaceup?view=word-pia"/>
  public bool DefaultFaceUp { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets a value indicating whether vertical envelopes are used.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.vertical?view=word-pia"/>
  public bool Vertical { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the distance, in points, from the left edge to the recipient name.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.recipientnamefromleft?view=word-pia"/>
  public float RecipientNamefromLeft { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the distance, in points, from the top edge to the recipient name.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.recipientnamefromtop?view=word-pia"/>
  public float RecipientNamefromTop { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the distance, in points, from the left edge to the recipient postal barcode area.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.recipientpostalfromleft?view=word-pia"/>
  public float RecipientPostalfromLeft { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the distance, in points, from the top edge to the recipient postal barcode area.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.recipientpostalfromtop?view=word-pia"/>
  public float RecipientPostalfromTop { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the distance, in points, from the left edge to the sender name.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.sendernamefromleft?view=word-pia"/>
  public float SenderNamefromLeft { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the distance, in points, from the top edge to the sender name.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.sendernamefromtop?view=word-pia"/>
  public float SenderNamefromTop { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the distance, in points, from the left edge to the sender postal barcode area.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.senderpostalfromleft?view=word-pia"/>
  public float SenderPostalfromLeft { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the distance, in points, from the top edge to the sender postal barcode area.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.senderpostalfromtop?view=word-pia"/>
  public float SenderPostalfromTop { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}
