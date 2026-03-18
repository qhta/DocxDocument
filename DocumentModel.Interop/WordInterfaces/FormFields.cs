namespace DocumentModel.Interop;

/// <summary>
/// A collection of FormField objects that represent all the form fields in a selection, range, or document.
/// </summary>
public partial interface FormFields : InteropObject, InteropCollection<FormField>
{
  /// <summary>
  /// The shaded.
  /// </summary>
  public bool Shaded { get; set; }
}
