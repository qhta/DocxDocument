namespace DocumentModel.Interop.Word;

/// <summary>
/// Contains information about the computer system.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.system?view=word-pia"/>
public partial interface System : InteropObject
{
  /// <summary>
  /// The operating system.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.system.operatingsystem?view=word-pia"/>
  public string OperatingSystem { get; }

  /// <summary>
  /// The processor type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.system.processortype?view=word-pia"/>
  public string ProcessorType { get; }

  /// <summary>
  /// The version.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.system.version?view=word-pia"/>
  public string Version { get; }

  /// <summary>
  /// The free disk space.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.system.freediskspace?view=word-pia"/>
  public int FreeDiskSpace { get; }

  /// <summary>
  /// The country.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.system.country?view=word-pia"/>
  public WdCountry Country { get; }

  /// <summary>
  /// The language designation.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.system.languagedesignation?view=word-pia"/>
  public string LanguageDesignation { get; }

  /// <summary>
  /// The horizontal resolution.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.system.horizontalresolution?view=word-pia"/>
  public int HorizontalResolution { get; }

  /// <summary>
  /// The vertical resolution.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.system.verticalresolution?view=word-pia"/>
  public int VerticalResolution { get; }

  /// <summary>
  /// The math coprocessor installed.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.system.mathcoprocessorinstalled?view=word-pia"/>
  public bool MathCoprocessorInstalled { get; }

  /// <summary>
  /// The computer type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.system.computertype?view=word-pia"/>
  public string ComputerType { get; }

  /// <summary>
  /// The macintosh name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.system.macintoshname?view=word-pia"/>
  public string MacintoshName { get; }

  /// <summary>
  /// The quick draw installed.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.system.quickdrawinstalled?view=word-pia"/>
  public bool QuickDrawInstalled { get; }

  /// <summary>
  /// The cursor.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.system.cursor?view=word-pia"/>
  public WdCursorType Cursor { get; set; }

  /// <summary>
  /// The country region.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.system.countryregion?view=word-pia"/>
  public WdCountry CountryRegion { get; }
}
