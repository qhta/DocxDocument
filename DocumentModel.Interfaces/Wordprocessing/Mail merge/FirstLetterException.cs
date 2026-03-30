namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents an abbreviation excluded from automatic correction.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.firstletterexception?view=word-pia"/>
public partial interface IFirstLetterException : IModelObject
{
  /// <summary>
  /// Returns an integer that represents the position of an item in a collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.firstletterexception.index?view=word-pia"/>
  public int Index { get; }

  /// <summary>
  /// Returns or sets the name of the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.firstletterexception.name?view=word-pia"/>
  public string Name { get; }
}
