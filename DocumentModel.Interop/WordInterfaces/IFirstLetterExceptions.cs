namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of FirstLetterException objects that represent the abbreviations excluded from automatic correction.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.firstletterexceptions?view=word-pia"/>
public interface IFirstLetterExceptions : IInteropObject, IInteropCollection<IFirstLetterException>
{


  #region methods

/// <summary>
  /// Returns the value produced by the add operation.
  /// </summary>
  /// <param name="name">Specifies the name.</param>
  /// <returns>The resulting value.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.firstletterexceptions.add?view=word-pia"/>
  public IFirstLetterException Add(string name);

  #endregion methods
}
