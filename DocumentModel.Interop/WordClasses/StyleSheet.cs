namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single cascading style sheet attached to a web document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.stylesheet?view=word-pia"/>
public partial class StyleSheet : InteropObject
{
  /// <summary>
  /// Specifies the name of a cascading style sheet, including the drive or Web path.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.stylesheet.fullname?view=word-pia"/>
  public string? FullName { get; set; }

  /// <summary>
  /// Returns an Integer that represents the position of an item in a collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.stylesheet.index?view=word-pia"/>
  public int Index { get; set; }

  /// <summary>
  /// Returns the name of the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.stylesheet.name?view=word-pia"/>
  public string? Name { get; set; }

  /// <summary>
  /// Returns the disk or Web path to the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.stylesheet.path?view=word-pia"/>
  public string? Path { get; set; }

  /// <summary>
  /// Returns the template type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.stylesheet.type?view=word-pia"/>
  public StyleSheetLinkType Type { get; set; }

  /// <summary>
  /// Returns a String representing the title of a Web style sheet.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.stylesheet.title?view=word-pia"/>
  public string? Title { get; set; }


  #region methods

/// <summary>
  /// Moves the style sheet to a new precedence level.
  /// </summary>
  /// <param name="precedence">The new precedence for the style sheet.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.stylesheet.move?view=word-pia"/>
  public void Move(StyleSheetPrecedence precedence) { throw new NotImplementedException(); }

  #endregion methods
}
