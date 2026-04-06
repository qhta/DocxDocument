namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a subdocument within a document or range.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.subdocument?view=word-pia"/>
public partial interface ISubdocument : IModelObject
{
  /// <summary>
  /// True if a subdocument in a master document is locked.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.subdocument.locked?view=word-pia"/>
  public bool Locked { get; set; }

  /// <summary>
  /// Returns a Range object that represents the portion of a document that's contained in the specified object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.subdocument.range?view=word-pia"/>
  public IRange Range { get; }

  /// <summary>
  /// Returns or sets the name of the specified object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.subdocument.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// Returns the disk or Web path to the specified object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.subdocument.path?view=word-pia"/>
  public string Path { get; }

  /// <summary>
  /// True if the specified subdocument has been saved to a file.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.subdocument.hasfile?view=word-pia"/>
  public bool HasFile { get; }

  /// <summary>
  /// Returns the heading level used to create the subdocument.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.subdocument.level?view=word-pia"/>
  public int Level { get; }
}
