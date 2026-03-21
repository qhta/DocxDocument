namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a hyperlink.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hyperlink?view=word-pia"/>
public partial interface Hyperlink : InteropObject
{
  /// <summary>
  /// The name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hyperlink.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// The address old.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hyperlink.addressold?view=word-pia"/>
  public string AddressOld { get; }

  /// <summary>
  /// The type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hyperlink.type?view=word-pia"/>
  public Core.MsoHyperlinkType Type { get; }

  /// <summary>
  /// The range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hyperlink.range?view=word-pia"/>
  public Range Range { get; }

  /// <summary>
  /// The shape.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hyperlink.shape?view=word-pia"/>
  public Shape Shape { get; }

  /// <summary>
  /// The sub address old.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hyperlink.subaddressold?view=word-pia"/>
  public string SubAddressOld { get; }

  /// <summary>
  /// The extra info required.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hyperlink.extrainforequired?view=word-pia"/>
  public bool ExtraInfoRequired { get; }

  /// <summary>
  /// The address.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hyperlink.address?view=word-pia"/>
  public string Address { get; set; }

  /// <summary>
  /// The sub address.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hyperlink.subaddress?view=word-pia"/>
  public string SubAddress { get; set; }

  /// <summary>
  /// The email subject.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hyperlink.emailsubject?view=word-pia"/>
  public string EmailSubject { get; set; }

  /// <summary>
  /// The screen tip.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hyperlink.screentip?view=word-pia"/>
  public string ScreenTip { get; set; }

  /// <summary>
  /// The text to display.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hyperlink.texttodisplay?view=word-pia"/>
  public string TextToDisplay { get; set; }

  /// <summary>
  /// The target.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hyperlink.target?view=word-pia"/>
  public string Target { get; set; }
}
