namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a variable stored as part of a document. Document variables are used to preserve macro settings in
/// between macro sessions.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.variable?view=word-pia"/>
public partial interface IVariable : IModelObject
{
  /// <summary>
  /// Returns or sets the name of the specified object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.variable.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// Returns or sets the value of the document variable.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.variable.value?view=word-pia"/>
  public string Value { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns an Integer that represents the position of an item in a collection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.variable.index?view=word-pia"/>
  public int Index { get; }
}
