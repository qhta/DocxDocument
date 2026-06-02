namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a hyperlink.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hyperlink?view=word-pia"/>
public partial class Hyperlink : InteropObject
{
  /// <summary>
  /// Returns the name of the hyperlink.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hyperlink.name?view=word-pia"/>
  public string? Name { get; set; }

  /// <summary>
  /// Returns the previous address of the hyperlink.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hyperlink.addressold?view=word-pia"/>
  public string? AddressOld { get; set; }

  /// <summary>
  /// Returns the type of the hyperlink.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hyperlink.type?view=word-pia"/>
  public Core.HyperlinkType Type { get; set; }

  /// <summary>
  /// Returns a range object that represents the hyperlink range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hyperlink.range?view=word-pia"/>
  public Range Range { get; set; }

  /// <summary>
  /// Returns a shape object that represents the shape for the hyperlink.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hyperlink.shape?view=word-pia"/>
  public Shape Shape { get; set; }

  /// <summary>
  /// Returns the previous subaddress of the hyperlink.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hyperlink.subaddressold?view=word-pia"/>
  public string? SubAddressOld { get; set; }

  /// <summary>
  /// Returns whether additional information is required to resolve the hyperlink.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hyperlink.extrainforequired?view=word-pia"/>
  public bool ExtraInfoRequired { get; set; }

  /// <summary>
  /// Returns or sets the address for the hyperlink.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hyperlink.address?view=word-pia"/>
  public string? Address { get; set; }

  /// <summary>
  /// Returns or sets the subaddress for the hyperlink.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hyperlink.subaddress?view=word-pia"/>
  public string? SubAddress { get; set; }

  /// <summary>
  /// Returns or sets the subject line for an e-mail hyperlink.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hyperlink.emailsubject?view=word-pia"/>
  public string? EmailSubject { get; set; }

  /// <summary>
  /// Returns or sets the ScreenTip text for the hyperlink.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hyperlink.screentip?view=word-pia"/>
  public string? ScreenTip { get; set; }

  /// <summary>
  /// Returns or sets the display text for the hyperlink.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hyperlink.texttodisplay?view=word-pia"/>
  public string? TextToDisplay { get; set; }

  /// <summary>
  /// Returns or sets the target frame for the hyperlink.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hyperlink.target?view=word-pia"/>
  public string? Target { get; set; }
}
