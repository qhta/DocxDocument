namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of FormField objects that represent all the form fields in a selection, range, or document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.formfields?view=word-pia"/>
public partial class FormFields : InteropCollection<FormField>
{
  /// <summary>
  /// Determines if shading is applied to form fields.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.formfields.shaded?view=word-pia"/>
  public bool Shaded { get; set; }
}
