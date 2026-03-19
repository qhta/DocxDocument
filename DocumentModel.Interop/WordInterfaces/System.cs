namespace DocumentModel.Interop.Word;

/// <summary>
/// Contains information about the computer system.
/// </summary>
public partial interface System : InteropObject
{
  /// <summary>
  /// The operating system.
  /// </summary>
  public string OperatingSystem { get; }

  /// <summary>
  /// The processor type.
  /// </summary>
  public string ProcessorType { get; }

  /// <summary>
  /// The version.
  /// </summary>
  public string Version { get; }

  /// <summary>
  /// The free disk space.
  /// </summary>
  public int FreeDiskSpace { get; }

  /// <summary>
  /// The country.
  /// </summary>
  public WdCountry Country { get; }

  /// <summary>
  /// The language designation.
  /// </summary>
  public string LanguageDesignation { get; }

  /// <summary>
  /// The horizontal resolution.
  /// </summary>
  public int HorizontalResolution { get; }

  /// <summary>
  /// The vertical resolution.
  /// </summary>
  public int VerticalResolution { get; }

  /// <summary>
  /// The math coprocessor installed.
  /// </summary>
  public bool MathCoprocessorInstalled { get; }

  /// <summary>
  /// The computer type.
  /// </summary>
  public string ComputerType { get; }

  /// <summary>
  /// The macintosh name.
  /// </summary>
  public string MacintoshName { get; }

  /// <summary>
  /// The quick draw installed.
  /// </summary>
  public bool QuickDrawInstalled { get; }

  /// <summary>
  /// The cursor.
  /// </summary>
  public WdCursorType Cursor { get; set; }

  /// <summary>
  /// The country region.
  /// </summary>
  public WdCountry CountryRegion { get; }
}
