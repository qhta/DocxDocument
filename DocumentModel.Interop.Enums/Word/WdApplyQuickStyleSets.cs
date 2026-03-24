namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a Quick Style set to apply to the document.
/// </summary>
public enum WdApplyQuickStyleSets
{
  /// <summary>
  /// Specifies a Quick Style set to apply to the document.
  /// </summary>
  SessionStartSet = unchecked((int)1),
  /// <summary>
  /// Resets the Quick Style to the style set from the template, if any.
  /// </summary>
  TemplateSet = unchecked((int)2)
}
