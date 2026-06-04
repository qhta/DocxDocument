namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a Quick Style set to apply to the document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdapplyquickstylesets?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdApplyQuickStyleSets))]
public enum ApplyQuickStyleSets
{
  /// <summary>
  /// Resets the Quick Style to the style set in use when the document was opened.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdApplyQuickStyleSets.wdSessionStartSet))]
  SessionStartSet = 1,
  /// <summary>
  /// Resets the Quick Style to the style set from the template, if any.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdApplyQuickStyleSets.wdTemplateSet))]
  TemplateSet = 2
}
