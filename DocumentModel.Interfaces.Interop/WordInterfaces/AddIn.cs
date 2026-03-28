namespace DocumentModel.Interop;

/// <summary>
/// Represents a single add-in, either installed or not installed.
/// </summary>
public partial interface AddIn : InteropObject
{
  /// <summary>
  /// The name.
  /// </summary>
  public string Name { get; }

  /// <summary>
  /// The index.
  /// </summary>
  public int Index { get; }

  /// <summary>
  /// The path.
  /// </summary>
  public string Path { get; }

  /// <summary>
  /// The installed.
  /// </summary>
  public bool Installed { get; set; }

  /// <summary>
  /// The compiled.
  /// </summary>
  public bool Compiled { get; }

  /// <summary>
  /// The autoload.
  /// </summary>
  public bool Autoload { get; }
}
