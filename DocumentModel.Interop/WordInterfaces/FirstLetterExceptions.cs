namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of FirstLetterException objects that represent the abbreviations excluded from automatic correction.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.firstletterexceptions?view=word-pia"/>
public partial interface IFirstLetterExceptions : IInteropObject, IInteropCollection<FirstLetterException>
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
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.firstletterexceptions.add?view=word-pia"/>
  public FirstLetterException Add(string Name);

  #endregion methods
}
