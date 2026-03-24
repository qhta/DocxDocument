namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies when to apply on-screen shading for form fields.
/// </summary>
public enum WdFieldShading
{
  /// <summary>
  /// Never apply.
  /// </summary>
  Never = unchecked((int)0),
  /// <summary>
  /// Always apply.
  /// </summary>
  Always = unchecked((int)1),
  /// <summary>
  /// Apply only when form field is selected.
  /// </summary>
  WhenSelected = unchecked((int)2)
}
