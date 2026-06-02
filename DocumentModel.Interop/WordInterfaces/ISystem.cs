namespace DocumentModel.Interop.Word;

/// <summary>
/// Contains information about the computer system.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.system?view=word-pia"/>
public interface ISystem : IInteropObject
{
  /// <summary>
  /// Returns the name of the current operating system (for example, "Windows" or "Windows NT").
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.system.operatingsystem?view=word-pia"/>
  public string OperatingSystem { get; }

  /// <summary>
  /// Returns the type of processor that the system is using (for example, i486).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.system.processortype?view=word-pia"/>
  public string ProcessorType { get; }

  /// <summary>
  /// Returns the version number of the operating system.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.system.version?view=word-pia"/>
  public string Version { get; }

  /// <summary>
  /// Returns the available disk space for the current drive, in bytes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.system.freediskspace?view=word-pia"/>
  public int FreeDiskSpace { get; }

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.system.country?view=word-pia"/>
  public Country Country { get; }

  /// <summary>
  /// Returns the designated language of the system software.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.system.languagedesignation?view=word-pia"/>
  public string LanguageDesignation { get; }

  /// <summary>
  /// Returns the horizontal display resolution, in pixels.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.system.horizontalresolution?view=word-pia"/>
  public int HorizontalResolution { get; }

  /// <summary>
  /// Returns the vertical screen resolution in pixels.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.system.verticalresolution?view=word-pia"/>
  public int VerticalResolution { get; }

  /// <summary>
  /// True if a math coprocessor is installed on the system.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.system.mathcoprocessorinstalled?view=word-pia"/>
  public bool MathCoprocessorInstalled { get; }

  /// <summary>
  /// You have requested Help for a keyword used only on the Macintosh. For information about this keyword, consult
  /// the language reference Help included with Microsoft Office Macintosh Edition.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.system.computertype?view=word-pia"/>
  public string ComputerType { get; }

  /// <summary>
  /// You have requested Help for a keyword used only on the Macintosh. For information about this keyword, consult
  /// the language reference Help included with Microsoft Office Macintosh Edition.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.system.macintoshname?view=word-pia"/>
  public string MacintoshName { get; }

  /// <summary>
  /// You have requested Help for a keyword used only on the Macintosh. For information about this keyword, consult
  /// the language reference Help included with Microsoft Office Macintosh Edition.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.system.quickdrawinstalled?view=word-pia"/>
  public bool QuickDrawInstalled { get; }

  /// <summary>
  /// Returns or sets the state (shape) of the pointer. Can be one of the following CursorType constants:
  /// wdCursorIBeam, wdCursorNormal, wdCursorNorthwestArrow, or wdCursorWait.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.system.cursor?view=word-pia"/>
  public CursorType Cursor { get; set; }

  /// <summary>
  /// Returns the country/region designation of the system.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.system.countryregion?view=word-pia"/>
  public Country CountryRegion { get; }


  #region methods

/// <summary>
  /// Returns the profile string.
  /// </summary>
  /// <param name="Section">Specifies the section.</param>
  /// <param name="Key">Specifies the key.</param>
  /// <returns>The resulting string value.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.system.profilestring?view=word-pia"/>
  public string ProfileString(string Section, string Key);

  /// <summary>
  /// Starts the Microsoft System Information application if it's not running, or switches to it if it's already
  /// running.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.system.msinfo?view=word-pia"/>
  public void MSInfo();

  #endregion methods
}
