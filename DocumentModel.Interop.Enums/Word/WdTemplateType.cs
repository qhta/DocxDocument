namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of template.
/// </summary>
public enum WdTemplateType
{
  /// <summary>
  /// The normal default template.
  /// </summary>
  wdNormalTemplate = unchecked((int)0),
  /// <summary>
  /// A global template.
  /// </summary>
  wdGlobalTemplate = unchecked((int)1),
  /// <summary>
  /// An attached template.
  /// </summary>
  wdAttachedTemplate = unchecked((int)2)
}
