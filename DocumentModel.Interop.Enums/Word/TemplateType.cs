namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of template.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdtemplatetype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdTemplateType")]
public enum TemplateType
{
  /// <summary>
  /// The normal default template.
  /// </summary>
  [WordInteropEnumValue("wdNormalTemplate")]
  NormalTemplate = 0,
  /// <summary>
  /// A global template.
  /// </summary>
  [WordInteropEnumValue("wdGlobalTemplate")]
  GlobalTemplate = 1,
  /// <summary>
  /// An attached template.
  /// </summary>
  [WordInteropEnumValue("wdAttachedTemplate")]
  AttachedTemplate = 2
}
