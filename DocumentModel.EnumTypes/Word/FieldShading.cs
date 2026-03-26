namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies when to apply on-screen shading for form fields.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdfieldshading?view=office-pia` for Office interop details.
/// </remarks>
public enum FieldShading
{
  /// <summary>
  /// Never apply.
  /// </summary>
  Never = 0,
  /// <summary>
  /// Always apply.
  /// </summary>
  Always = 1,
  /// <summary>
  /// Apply only when form field is selected.
  /// </summary>
  WhenSelected = 2
}
