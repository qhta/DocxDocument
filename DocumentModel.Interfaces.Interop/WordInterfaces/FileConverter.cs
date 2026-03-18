namespace DocumentModel.Interop;

/// <summary>
/// Represents a file converter that's used to open or save files.
/// </summary>
public interface FileConverter : InteropObject
{
  /// <summary>
  /// The format name.
  /// </summary>
  public string FormatName { get; }
  /// <summary>
  /// The class name.
  /// </summary>
  public string ClassName { get; }
  /// <summary>
  /// The save format.
  /// </summary>
  public int SaveFormat { get; }
  /// <summary>
  /// The open format.
  /// </summary>
  public int OpenFormat { get; }
  /// <summary>
  /// The can save.
  /// </summary>
  public bool CanSave { get; }
  /// <summary>
  /// The can open.
  /// </summary>
  public bool CanOpen { get; }
  /// <summary>
  /// The path.
  /// </summary>
  public string Path { get; }
  /// <summary>
  /// The name.
  /// </summary>
  public string Name { get; }
  /// <summary>
  /// The extensions.
  /// </summary>
  public string Extensions { get; }

}
