namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a single cascading style sheet attached to a web document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.stylesheet?view=word-pia"/>
public partial interface IStyleSheet : IModelObject
{
  /// <summary>
  /// Specifies the name of a cascading style sheet, including the drive or Web path.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.stylesheet.fullname?view=word-pia"/>
  public string FullName { get; }

  /// <summary>
  /// Returns an Integer that represents the position of an item in a collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.stylesheet.index?view=word-pia"/>
  public int Index { get; }

  /// <summary>
  /// Returns the name of the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.stylesheet.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// Returns the disk or Web path to the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.stylesheet.path?view=word-pia"/>
  public string Path { get; }

  /// <summary>
  /// Returns the template type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.stylesheet.type?view=word-pia"/>
  public StyleSheetLinkType Type { get; set; }

  /// <summary>
  /// Returns a String representing the title of a Web style sheet.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.stylesheet.title?view=word-pia"/>
  public string Title { get; set; }
}
