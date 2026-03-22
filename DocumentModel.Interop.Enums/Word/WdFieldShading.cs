namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies when to apply on-screen shading for form fields.
/// </summary>
public enum WdFieldShading
{
  /// <summary>
  /// Never apply.
  /// </summary>
  wdFieldShadingNever = unchecked((int)0),
  /// <summary>
  /// Always apply.
  /// </summary>
  wdFieldShadingAlways = unchecked((int)1),
  /// <summary>
  /// Apply only when form field is selected.
  /// </summary>
  wdFieldShadingWhenSelected = unchecked((int)2)
}
