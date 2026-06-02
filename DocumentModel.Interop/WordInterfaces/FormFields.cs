namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of FormField objects that represent all the form fields in a selection, range, or document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.formfields?view=word-pia"/>
public partial interface IFormFields : IInteropObject, IInteropCollection<FormField>
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
  /// <param name="Range">Specifies the range.</param>
  /// <param name="Type">Specifies the type.</param>
  /// <returns>The resulting value.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.formfields.add?view=word-pia"/>
  public FormField Add(Range Range, FieldType Type);

  #endregion methods
}
