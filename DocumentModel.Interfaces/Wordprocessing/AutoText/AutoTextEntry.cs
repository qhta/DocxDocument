namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a single AutoText entry.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autotextentry?view=word-pia"/>
public partial interface IAutoTextEntry : IModelObject
{
  /// <summary>
  /// Gets the index number of the AutoText entry in the collection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autotextentry.index?view=word-pia"/>
  public int Index { get; }

  /// <summary>
  /// Gets or sets the name of the AutoText entry.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autotextentry.name?view=word-pia"/>
  public string Name { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets the style name associated with the AutoText entry.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autotextentry.stylename?view=word-pia"/>
  public string StyleName { get; }

  /// <summary>
  /// Gets or sets the text value of the AutoText entry.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autotextentry.value?view=word-pia"/>
  public string Value { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}
