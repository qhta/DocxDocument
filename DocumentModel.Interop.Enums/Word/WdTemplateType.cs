namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of template.
/// </summary>
public enum WdTemplateType
{
  /// <summary>
  /// The normal default template.
  /// </summary>
  NormalTemplate = unchecked((int)0),
  /// <summary>
  /// A global template.
  /// </summary>
  GlobalTemplate = unchecked((int)1),
  /// <summary>
  /// An attached template.
  /// </summary>
  AttachedTemplate = unchecked((int)2)
}
