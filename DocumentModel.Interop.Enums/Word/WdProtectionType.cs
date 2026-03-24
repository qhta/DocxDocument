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
  AllowOnlyRevisions = unchecked((int)0),
  /// <summary>
  /// Specifies the type of protection applied to the current document.
  /// </summary>
  AllowOnlyComments = unchecked((int)1),
  /// <summary>
  /// Specifies the type of protection applied to the current document.
  /// </summary>
  AllowOnlyFormFields = unchecked((int)2),
  /// <summary>
  /// Allow read-only access to the document.
  /// </summary>
  AllowOnlyReading = unchecked((int)3),
  /// <summary>
  /// Specifies the type of protection applied to the current document.
  /// </summary>
  NoProtection = unchecked((int)-1)
}
