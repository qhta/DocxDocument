namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a file converter that's used to open or save files.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fileconverter?view=word-pia"/>
public interface FileConverter : InteropObject
{
  /// <summary>
  /// The format name.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fileconverter.formatname?view=word-pia"/>
  public string FormatName { get; }
  /// <summary>
  /// The class name.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fileconverter.classname?view=word-pia"/>
  public string ClassName { get; }
  /// <summary>
  /// The save format.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fileconverter.saveformat?view=word-pia"/>
  public int SaveFormat { get; }
  /// <summary>
  /// The open format.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fileconverter.openformat?view=word-pia"/>
  public int OpenFormat { get; }
  /// <summary>
  /// The can save.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fileconverter.cansave?view=word-pia"/>
  public bool CanSave { get; }
  /// <summary>
  /// The can open.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fileconverter.canopen?view=word-pia"/>
  public bool CanOpen { get; }
  /// <summary>
  /// The path.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fileconverter.path?view=word-pia"/>
  public string Path { get; }
  /// <summary>
  /// The name.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fileconverter.name?view=word-pia"/>
  public string Name { get; }
  /// <summary>
  /// The extensions.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fileconverter.extensions?view=word-pia"/>
  public string Extensions { get; }

}
