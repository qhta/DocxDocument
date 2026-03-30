namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.formfields?view=word-pia"/>
public partial interface FormFields: IModelObject
{
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
}
