namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of HangulAndAlphabetException objects that represents all Hangul and alphabet AutoCorrect exceptions. This list corresponds to the list of AutoCorrect exceptions on the Korean tab in the AutoCorrect Exceptions dialog box (AutoCorrect command, Tools menu).
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hangulandalphabetexceptions?view=word-pia"/>
public partial interface IHangulAndAlphabetExceptions : IInteropObject, IInteropCollection<HangulAndAlphabetException>
{


  #region methods

/// <summary>
  /// Returns the value produced by the add operation.
  /// </summary>
  /// <param name="Name">Specifies the name.</param>
  /// <returns>The resulting value.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hangulandalphabetexceptions.add?view=word-pia"/>
  public HangulAndAlphabetException Add(string Name);

  #endregion methods
}
