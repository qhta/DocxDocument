namespace DocumentModel.Interop;

/// <summary>
/// Represents a hyperlink.
/// </summary>
public partial interface Hyperlink : InteropObject
{
  /// <summary>
  /// The name.
  /// </summary>
  public string Name { get; }

  /// <summary>
  /// The address old.
  /// </summary>
  public string AddressOld { get; }

  /// <summary>
  /// The type.
  /// </summary>
  //public Core.MsoHyperlinkType Type { get; }

  /// <summary>
  /// The range.
  /// </summary>
  public Range Range { get; }

  /// <summary>
  /// The shape.
  /// </summary>
  public Shape Shape { get; }

  /// <summary>
  /// The sub address old.
  /// </summary>
  public string SubAddressOld { get; }

  /// <summary>
  /// The extra info required.
  /// </summary>
  public bool ExtraInfoRequired { get; }

  /// <summary>
  /// The address.
  /// </summary>
  public string Address { get; set; }

  /// <summary>
  /// The sub address.
  /// </summary>
  public string SubAddress { get; set; }

  /// <summary>
  /// The email subject.
  /// </summary>
  public string EmailSubject { get; set; }

  /// <summary>
  /// The screen tip.
  /// </summary>
  public string ScreenTip { get; set; }

  /// <summary>
  /// The text to display.
  /// </summary>
  public string TextToDisplay { get; set; }

  /// <summary>
  /// The target.
  /// </summary>
  public string Target { get; set; }
}
