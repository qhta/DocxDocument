namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of protection applied to the current document.
/// </summary>
public enum WdProtectionType
{
  /// <summary>
  /// Allow only revisions to be made to existing content. wdAllowOnlyComments1 Allow only comments to be added to
  /// the document. wdAllowOnlyFormFields2 Allow content to be added to the document only through form fields.
  /// </summary>
  AllowOnlyRevisions = 0,
  /// <summary>
  /// Specifies the type of protection applied to the current document.
  /// </summary>
  AllowOnlyComments = 1,
  /// <summary>
  /// Specifies the type of protection applied to the current document.
  /// </summary>
  AllowOnlyFormFields = 2,
  /// <summary>
  /// Allow read-only access to the document.
  /// </summary>
  AllowOnlyReading = 3,
  /// <summary>
  /// Specifies the type of protection applied to the current document.
  /// </summary>
  NoProtection = -1
}
