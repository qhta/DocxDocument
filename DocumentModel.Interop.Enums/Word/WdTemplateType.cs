namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of template.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdtemplatetype?view=office-pia` for Office interop details.
/// </remarks>
public enum TemplateType
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
