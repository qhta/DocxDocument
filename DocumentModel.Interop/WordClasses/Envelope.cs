namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an envelope.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope?view=word-pia"/>
public partial class Envelope : InteropObject
{
  /// <summary>
  /// Gets the delivery address on the envelope.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.address?view=word-pia"/>
  public Range Address { get; set; }

  /// <summary>
  /// Gets the return address on the envelope.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.returnaddress?view=word-pia"/>
  public Range ReturnAddress { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether POSTNET bar codes are printed by default.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.defaultprintbarcode?view=word-pia"/>
  public bool DefaultPrintBarCode { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether Facing Identification Mark (FIM-A) marks are printed by default.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.defaultprintfima?view=word-pia"/>
  public bool DefaultPrintFIMA { get; set; }

  /// <summary>
  /// Gets or sets the default envelope height, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.defaultheight?view=word-pia"/>
  public float DefaultHeight { get; set; }

  /// <summary>
  /// Gets or sets the default envelope width, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.defaultwidth?view=word-pia"/>
  public float DefaultWidth { get; set; }

  /// <summary>
  /// Gets or sets the default envelope size name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.defaultsize?view=word-pia"/>
  public string? DefaultSize { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the return address is omitted by default.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.defaultomitreturnaddress?view=word-pia"/>
  public bool DefaultOmitReturnAddress { get; set; }

  /// <summary>
  /// Gets or sets the paper tray used to feed envelopes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.feedsource?view=word-pia"/>
  public PaperTray FeedSource { get; set; }

  /// <summary>
  /// Gets or sets the distance, in points, from the left edge of the envelope to the delivery address.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.addressfromleft?view=word-pia"/>
  public float AddressFromLeft { get; set; }

  /// <summary>
  /// Gets or sets the distance, in points, from the top edge of the envelope to the delivery address.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.addressfromtop?view=word-pia"/>
  public float AddressFromTop { get; set; }

  /// <summary>
  /// Gets or sets the distance, in points, from the left edge of the envelope to the return address.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.returnaddressfromleft?view=word-pia"/>
  public float ReturnAddressFromLeft { get; set; }

  /// <summary>
  /// Gets or sets the distance, in points, from the top edge of the envelope to the return address.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.returnaddressfromtop?view=word-pia"/>
  public float ReturnAddressFromTop { get; set; }

  /// <summary>
  /// Gets the style used for the delivery address.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.addressstyle?view=word-pia"/>
  public Style AddressStyle { get; set; }

  /// <summary>
  /// Gets the style used for the return address.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.returnaddressstyle?view=word-pia"/>
  public Style ReturnAddressStyle { get; set; }

  /// <summary>
  /// Gets or sets the default envelope orientation.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.defaultorientation?view=word-pia"/>
  public EnvelopeOrientation DefaultOrientation { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether envelopes are fed face up by default.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.defaultfaceup?view=word-pia"/>
  public bool DefaultFaceUp { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether vertical envelopes are used.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.vertical?view=word-pia"/>
  public bool Vertical { get; set; }

  /// <summary>
  /// Gets or sets the distance, in points, from the left edge to the recipient name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.recipientnamefromleft?view=word-pia"/>
  public float RecipientNamefromLeft { get; set; }

  /// <summary>
  /// Gets or sets the distance, in points, from the top edge to the recipient name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.recipientnamefromtop?view=word-pia"/>
  public float RecipientNamefromTop { get; set; }

  /// <summary>
  /// Gets or sets the distance, in points, from the left edge to the recipient postal barcode area.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.recipientpostalfromleft?view=word-pia"/>
  public float RecipientPostalfromLeft { get; set; }

  /// <summary>
  /// Gets or sets the distance, in points, from the top edge to the recipient postal barcode area.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.recipientpostalfromtop?view=word-pia"/>
  public float RecipientPostalfromTop { get; set; }

  /// <summary>
  /// Gets or sets the distance, in points, from the left edge to the sender name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.sendernamefromleft?view=word-pia"/>
  public float SenderNamefromLeft { get; set; }

  /// <summary>
  /// Gets or sets the distance, in points, from the top edge to the sender name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.sendernamefromtop?view=word-pia"/>
  public float SenderNamefromTop { get; set; }

  /// <summary>
  /// Gets or sets the distance, in points, from the left edge to the sender postal barcode area.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.senderpostalfromleft?view=word-pia"/>
  public float SenderPostalfromLeft { get; set; }

  /// <summary>
  /// Gets or sets the distance, in points, from the top edge to the sender postal barcode area.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.senderpostalfromtop?view=word-pia"/>
  public float SenderPostalfromTop { get; set; }


  #region methods

/// <summary>
  /// Executes the insert2000 operation.
  /// </summary>
  /// <param name="extractAddress">Specifies the extract address.</param>
  /// <param name="address">Specifies the address.</param>
  /// <param name="autoText">Specifies the auto text.</param>
  /// <param name="omitReturnAddress">Specifies the omit return address.</param>
  /// <param name="returnAddress">Specifies the return address.</param>
  /// <param name="returnAutoText">Specifies the return auto text.</param>
  /// <param name="printBarCode">Specifies the print bar code.</param>
  /// <param name="printFIMA">Specifies the print fima.</param>
  /// <param name="size">Specifies the size.</param>
  /// <param name="height">Specifies the height.</param>
  /// <param name="width">Specifies the width.</param>
  /// <param name="feedSource">Specifies the feed source.</param>
  /// <param name="addressFromLeft">Specifies the address from left.</param>
  /// <param name="addressFromTop">Specifies the address from top.</param>
  /// <param name="returnAddressFromLeft">Specifies the return address from left.</param>
  /// <param name="returnAddressFromTop">Specifies the return address from top.</param>
  /// <param name="defaultFaceUp">Specifies the default face up.</param>
  /// <param name="defaultOrientation">Specifies the default orientation.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.insert2000?view=word-pia"/>
  public void Insert2000(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width, object feedSource, object addressFromLeft, object addressFromTop, object returnAddressFromLeft, object returnAddressFromTop, object defaultFaceUp, object defaultOrientation) { throw new NotImplementedException(); }

  #endregion methods
}
