namespace DocumentModel.Interop.Word;

/// <summary>
/// Contains information about the computer system.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.system?view=word-pia"/>
public partial interface System : InteropObject
{
  /// <summary>
  /// Returns the operating system.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.system.operatingsystem?view=word-pia"/>
  public string OperatingSystem { get; }

  /// <summary>
  /// Returns the processor type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.system.processortype?view=word-pia"/>
  public string ProcessorType { get; }

  /// <summary>
  /// Returns the version.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.system.version?view=word-pia"/>
  public string Version { get; }

  /// <summary>
  /// Returns the free disk space.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.system.freediskspace?view=word-pia"/>
  public int FreeDiskSpace { get; }

  /// <summary>
  /// Returns the country.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.system.country?view=word-pia"/>
  public WdCountry Country { get; }

  /// <summary>
  /// Returns the language designation.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.system.languagedesignation?view=word-pia"/>
  public string LanguageDesignation { get; }

  /// <summary>
  /// Returns the horizontal resolution.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.system.horizontalresolution?view=word-pia"/>
  public int HorizontalResolution { get; }

  /// <summary>
  /// Returns the vertical resolution.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.system.verticalresolution?view=word-pia"/>
  public int VerticalResolution { get; }

  /// <summary>
  /// Returns whether math coprocessor installed.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.system.mathcoprocessorinstalled?view=word-pia"/>
  public bool MathCoprocessorInstalled { get; }

  /// <summary>
  /// Returns the computer type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.system.computertype?view=word-pia"/>
  public string ComputerType { get; }

  /// <summary>
  /// Returns the macintosh name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.system.macintoshname?view=word-pia"/>
  public string MacintoshName { get; }

  /// <summary>
  /// Returns whether quick draw installed.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.system.quickdrawinstalled?view=word-pia"/>
  public bool QuickDrawInstalled { get; }

  /// <summary>
  /// Returns or sets the cursor.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.system.cursor?view=word-pia"/>
  public WdCursorType Cursor { get; set; }

  /// <summary>
  /// Returns the country region.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.system.countryregion?view=word-pia"/>
  public WdCountry CountryRegion { get; }
}
