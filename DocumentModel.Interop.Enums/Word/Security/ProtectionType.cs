namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of protection applied to the current document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdprotectiontype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdProtectionType")]
public enum ProtectionType
{
  /// <summary>
  /// Allow only revisions to be made to existing content.
  /// </summary>
  [InteropEnumValue("wdAllowOnlyRevisions")]
  AllowOnlyRevisions = 0,
  /// <summary>
  /// Allow only comments to be added to the document.
  /// </summary>
  [InteropEnumValue("wdAllowOnlyComments")]
  AllowOnlyComments = 1,
  /// <summary>
  /// Allow content to be added to the document only through form fields.
  /// </summary>
  [InteropEnumValue("wdAllowOnlyFormFields")]
  AllowOnlyFormFields = 2,
  /// <summary>
  /// Allow read-only access to the document.
  /// </summary>
  [InteropEnumValue("wdAllowOnlyReading")]
  AllowOnlyReading = 3,
  /// <summary>
  /// Do not apply protection to the document.
  /// </summary>
  [InteropEnumValue("wdNoProtection")]
  NoProtection = -1
}
