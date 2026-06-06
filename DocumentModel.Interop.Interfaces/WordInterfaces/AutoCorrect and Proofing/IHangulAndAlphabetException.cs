namespace DocumentModel.Interop.Word;	
/// <summary>
/// Represents a single Hangul-and-alphabet AutoCorrect exception.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hangulandalphabetexception?view=word-pia"/>
public interface IHangulAndAlphabetException : IInteropObject
{
  /// <summary>
  /// Returns the position of this item in its collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hangulandalphabetexception.index?view=word-pia"/>
  public int Index { get; }	
  /// <summary>
  /// Returns the name of the Hangul-and-alphabet AutoCorrect exception.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hangulandalphabetexception.name?view=word-pia"/>
  public string Name { get; }	

  #region methods	
/// <summary>
  /// Deletes the specified object.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hangulandalphabetexception.delete?view=word-pia"/>
  public void Delete();	
  #endregion methods
}
