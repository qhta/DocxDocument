namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a file converter that's used to open or save files.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fileconverter?view=word-pia"/>
public interface FileConverter : InteropObject
{
  /// <summary>
  /// The format name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fileconverter.formatname?view=word-pia"/>
  public string FormatName { get; }
  /// <summary>
  /// The class name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fileconverter.classname?view=word-pia"/>
  public string ClassName { get; }
  /// <summary>
  /// The save format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fileconverter.saveformat?view=word-pia"/>
  public int SaveFormat { get; }
  /// <summary>
  /// The open format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fileconverter.openformat?view=word-pia"/>
  public int OpenFormat { get; }
  /// <summary>
  /// The can save.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fileconverter.cansave?view=word-pia"/>
  public bool CanSave { get; }
  /// <summary>
  /// The can open.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fileconverter.canopen?view=word-pia"/>
  public bool CanOpen { get; }
  /// <summary>
  /// The path.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fileconverter.path?view=word-pia"/>
  public string Path { get; }
  /// <summary>
  /// The name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fileconverter.name?view=word-pia"/>
  public string Name { get; }
  /// <summary>
  /// The extensions.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fileconverter.extensions?view=word-pia"/>
  public string Extensions { get; }

}
