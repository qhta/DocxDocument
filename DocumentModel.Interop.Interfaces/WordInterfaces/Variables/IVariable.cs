namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a variable stored as part of a document. Document variables are used to preserve macro settings in
/// between macro sessions.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.variable?view=word-pia"/>
public interface IVariable : IInteropObject
{
  /// <summary>
  /// Returns or sets the name of the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.variable.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// Returns or sets the value of the document variable.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.variable.value?view=word-pia"/>
  public string Value { get; set; }

  /// <summary>
  /// Returns an Integer that represents the position of an item in a collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.variable.index?view=word-pia"/>
  public int Index { get; }


  #region methods

/// <summary>
  /// Deletes the specified object.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.variable.delete?view=word-pia"/>
  public void Delete();

  #endregion methods
}
