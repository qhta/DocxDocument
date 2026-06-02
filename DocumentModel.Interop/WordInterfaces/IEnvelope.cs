namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an envelope.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope?view=word-pia"/>
public interface IEnvelope : IInteropObject
{
  /// <summary>
  /// Gets the delivery address on the envelope.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.address?view=word-pia"/>
  public Range Address { get; }

  /// <summary>
  /// Gets the return address on the envelope.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.returnaddress?view=word-pia"/>
  public Range ReturnAddress { get; }

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
  public string DefaultSize { get; set; }

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
  public Style AddressStyle { get; }

  /// <summary>
  /// Gets the style used for the return address.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.returnaddressstyle?view=word-pia"/>
  public Style ReturnAddressStyle { get; }

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
  /// <param name="ExtractAddress">Specifies the extract address.</param>
  /// <param name="Address">Specifies the address.</param>
  /// <param name="AutoText">Specifies the auto text.</param>
  /// <param name="OmitReturnAddress">Specifies the omit return address.</param>
  /// <param name="ReturnAddress">Specifies the return address.</param>
  /// <param name="ReturnAutoText">Specifies the return auto text.</param>
  /// <param name="PrintBarCode">Specifies the print bar code.</param>
  /// <param name="PrintFIMA">Specifies the print fima.</param>
  /// <param name="Size">Specifies the size.</param>
  /// <param name="Height">Specifies the height.</param>
  /// <param name="Width">Specifies the width.</param>
  /// <param name="FeedSource">Specifies the feed source.</param>
  /// <param name="AddressFromLeft">Specifies the address from left.</param>
  /// <param name="AddressFromTop">Specifies the address from top.</param>
  /// <param name="ReturnAddressFromLeft">Specifies the return address from left.</param>
  /// <param name="ReturnAddressFromTop">Specifies the return address from top.</param>
  /// <param name="DefaultFaceUp">Specifies the default face up.</param>
  /// <param name="DefaultOrientation">Specifies the default orientation.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.envelope.insert2000?view=word-pia"/>
  public void Insert2000(object ExtractAddress, object Address, object AutoText, object OmitReturnAddress, object ReturnAddress, object ReturnAutoText, object PrintBarCode, object PrintFIMA, object Size, object Height, object Width, object FeedSource, object AddressFromLeft, object AddressFromTop, object ReturnAddressFromLeft, object ReturnAddressFromTop, object DefaultFaceUp, object DefaultOrientation);

  #endregion methods
}
