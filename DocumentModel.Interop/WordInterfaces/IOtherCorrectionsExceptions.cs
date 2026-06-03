namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of OtherCorrectionsException objects that represents the list of words that Microsoft Word won't
/// correct automatically. This list corresponds to the list of AutoCorrect exceptions on the Other Corrections
/// tab in the AutoCorrect Exceptions dialog box (AutoCorrect command, Tools menu).
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.othercorrectionsexceptions?view=word-pia"/>
public interface IOtherCorrectionsExceptions : IInteropObject, IInteropCollection<IOtherCorrectionsException>
{


  #region methods

/// <summary>
  /// Adds a new correction entry with the specified name and returns the corresponding exception instance. 
  /// </summary>
  /// <param name="Name">The name of the correction to add. Cannot be null or empty.</param>
  /// <returns>An instance of OtherCorrectionsException representing the added correction.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.othercorrectionsexceptions.add?view=word-pia"/>
  public IOtherCorrectionsException Add(string Name);

  #endregion methods
}
