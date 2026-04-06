namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a file converter that's used to open or save files.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fileconverter?view=word-pia"/>
public interface IFileConverter : IModelObject
{
  /// <summary>
  /// Returns the name of the specified file converter.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fileconverter.formatname?view=word-pia"/>
  public string FormatName { get; }
  /// <summary>
  /// Returns a unique name that identifies the file converter.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fileconverter.classname?view=word-pia"/>
  public string ClassName { get; }
  /// <summary>
  /// Returns the file format of the specified file converter.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fileconverter.saveformat?view=word-pia"/>
  public int SaveFormat { get; }
  /// <summary>
  /// Returns the file format of the specified file converter.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fileconverter.openformat?view=word-pia"/>
  public int OpenFormat { get; }
  /// <summary>
  /// Determines if the specified file converter is designed to save files.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fileconverter.cansave?view=word-pia"/>
  public bool CanSave { get; }
  /// <summary>
  /// Determines if the specified file converter is designed to open files.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fileconverter.canopen?view=word-pia"/>
  public bool CanOpen { get; }
  /// <summary>
  /// Returns the disk or Web path to the specified object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fileconverter.path?view=word-pia"/>
  public string Path { get; }
  /// <summary>
  /// Returns or sets the name of the specified object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fileconverter.name?view=word-pia"/>
  public string Name { get; }
  /// <summary>
  /// Returns the file name extensions associated with the specified <see cref="IFileConverter"/> object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fileconverter.extensions?view=word-pia"/>
  public string Extensions { get; }

}
