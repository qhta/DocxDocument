namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an abbreviation excluded from automatic correction.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.firstletterexception?view=word-pia"/>
public partial class FirstLetterException : InteropObject
{
  /// <summary>
  /// Returns an integer that represents the position of an item in a collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.firstletterexception.index?view=word-pia"/>
  public int Index { get; set; }

  /// <summary>
  /// Returns or sets the name of the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.firstletterexception.name?view=word-pia"/>
  public string? Name { get; set; }


  #region methods

/// <summary>
  /// Deletes the specified object.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.firstletterexception.delete?view=word-pia"/>
  public void Delete() { throw new NotImplementedException(); }

  #endregion methods
}
