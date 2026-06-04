namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies when to apply on-screen shading for form fields.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdfieldshading?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdFieldShading")]
public enum FieldShading
{
  /// <summary>
  /// Never apply.
  /// </summary>
  [InteropEnumValue("wdFieldShadingNever")]
  Never = 0,
  /// <summary>
  /// Always apply.
  /// </summary>
  [InteropEnumValue("wdFieldShadingAlways")]
  Always = 1,
  /// <summary>
  /// Apply only when form field is selected.
  /// </summary>
  [InteropEnumValue("wdFieldShadingWhenSelected")]
  WhenSelected = 2
}
