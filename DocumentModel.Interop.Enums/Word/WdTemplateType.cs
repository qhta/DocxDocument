namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of template.
/// </summary>
public enum WdTemplateType
{
  /// <summary>
  /// The normal default template.
  /// </summary>
  NormalTemplate = 0,
  /// <summary>
  /// A global template.
  /// </summary>
  GlobalTemplate = 1,
  /// <summary>
  /// An attached template.
  /// </summary>
  AttachedTemplate = 2
}
