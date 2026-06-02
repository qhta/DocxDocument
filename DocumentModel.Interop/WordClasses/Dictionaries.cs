namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Dictionary objects that includes the active custom spelling dictionaries.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dictionaries?view=word-pia"/>
public partial class Dictionaries : InteropCollection<Dictionary>
{
  /// <summary>
  /// Gets the maximum number of custom dictionaries that can be active.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dictionaries.maximum?view=word-pia"/>
  public int Maximum { get; set; }

  /// <summary>
  /// Gets or sets the active custom spelling dictionary.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dictionaries.activecustomdictionary?view=word-pia"/>
  public Dictionary ActiveCustomDictionary { get; set; }


  #region methods

/// <summary>
  /// Adds a custom dictionary to the collection.
  /// </summary>
  /// <param name="FileName">The full path and file name of the custom dictionary.</param>
  /// <returns>The created <see cref="Dictionary"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dictionaries.add?view=word-pia"/>
  public Dictionary Add(string FileName) { throw new NotImplementedException(); }

  #endregion methods
}
