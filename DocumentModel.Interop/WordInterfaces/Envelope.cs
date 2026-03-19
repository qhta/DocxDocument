namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an envelope.
/// </summary>
public partial interface Envelope : InteropObject
{
  /// <summary>
  /// The address.
  /// </summary>
  public Range Address { get; }

  /// <summary>
  /// The return address.
  /// </summary>
  public Range ReturnAddress { get; }

  /// <summary>
  /// The default print bar code.
  /// </summary>
  public bool DefaultPrintBarCode { get; set; }

  /// <summary>
  /// The default print fima.
  /// </summary>
  public bool DefaultPrintFIMA { get; set; }

  /// <summary>
  /// The default height.
  /// </summary>
  public float DefaultHeight { get; set; }

  /// <summary>
  /// The default width.
  /// </summary>
  public float DefaultWidth { get; set; }

  /// <summary>
  /// The default size.
  /// </summary>
  public string DefaultSize { get; set; }

  /// <summary>
  /// The default omit return address.
  /// </summary>
  public bool DefaultOmitReturnAddress { get; set; }

  /// <summary>
  /// The feed source.
  /// </summary>
  public WdPaperTray FeedSource { get; set; }

  /// <summary>
  /// The address from left.
  /// </summary>
  public float AddressFromLeft { get; set; }

  /// <summary>
  /// The address from top.
  /// </summary>
  public float AddressFromTop { get; set; }

  /// <summary>
  /// The return address from left.
  /// </summary>
  public float ReturnAddressFromLeft { get; set; }

  /// <summary>
  /// The return address from top.
  /// </summary>
  public float ReturnAddressFromTop { get; set; }

  /// <summary>
  /// The address style.
  /// </summary>
  public Style AddressStyle { get; }

  /// <summary>
  /// The return address style.
  /// </summary>
  public Style ReturnAddressStyle { get; }

  /// <summary>
  /// The default orientation.
  /// </summary>
  public WdEnvelopeOrientation DefaultOrientation { get; set; }

  /// <summary>
  /// The default face up.
  /// </summary>
  public bool DefaultFaceUp { get; set; }

  /// <summary>
  /// The vertical.
  /// </summary>
  public bool Vertical { get; set; }

  /// <summary>
  /// The recipient namefrom left.
  /// </summary>
  public float RecipientNamefromLeft { get; set; }

  /// <summary>
  /// The recipient namefrom top.
  /// </summary>
  public float RecipientNamefromTop { get; set; }

  /// <summary>
  /// The recipient postalfrom left.
  /// </summary>
  public float RecipientPostalfromLeft { get; set; }

  /// <summary>
  /// The recipient postalfrom top.
  /// </summary>
  public float RecipientPostalfromTop { get; set; }

  /// <summary>
  /// The sender namefrom left.
  /// </summary>
  public float SenderNamefromLeft { get; set; }

  /// <summary>
  /// The sender namefrom top.
  /// </summary>
  public float SenderNamefromTop { get; set; }

  /// <summary>
  /// The sender postalfrom left.
  /// </summary>
  public float SenderPostalfromLeft { get; set; }

  /// <summary>
  /// The sender postalfrom top.
  /// </summary>
  public float SenderPostalfromTop { get; set; }
}
