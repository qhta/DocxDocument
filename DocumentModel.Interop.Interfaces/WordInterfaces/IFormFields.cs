namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of FormField objects that represent all the form fields in a selection, range, or document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.formfields?view=word-pia"/>
public interface IFormFields : IInteropObject, IInteropCollection<IFormField>
{
  /// <summary>
  /// Determines if shading is applied to form fields.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.formfields.shaded?view=word-pia"/>
  public bool Shaded { get; set; }


  #region methods

/// <summary>
  /// Returns the value produced by the add operation.
  /// </summary>
  /// <param name="range">Specifies the range.</param>
  /// <param name="type">Specifies the type.</param>
  /// <returns>The resulting value.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.formfields.add?view=word-pia"/>
  public IFormField Add(IRange range, FieldType type);

  #endregion methods
}
