namespace DocumentModel.Wordprocessing;

/// <summary>
/// A collection of Dictionary objects that includes the active custom spelling dictionaries.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dictionaries?view=word-pia"/>
public partial interface IDictionaries : IModelCollection<IDictionary>
{
  /// <summary>
  /// Gets the maximum number of custom dictionaries that can be active.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dictionaries.maximum?view=word-pia"/>
  public int Maximum { get; }

  /// <summary>
  /// Gets or sets the active custom spelling dictionary.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dictionaries.activecustomdictionary?view=word-pia"/>
  public IDictionary ActiveCustomDictionary { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}
