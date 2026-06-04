namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of template.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdtemplatetype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdTemplateType))]
public enum TemplateType
{
  /// <summary>
  /// The normal default template.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTemplateType.wdNormalTemplate))]
  NormalTemplate = 0,
  /// <summary>
  /// A global template.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTemplateType.wdGlobalTemplate))]
  GlobalTemplate = 1,
  /// <summary>
  /// An attached template.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTemplateType.wdAttachedTemplate))]
  AttachedTemplate = 2
}
