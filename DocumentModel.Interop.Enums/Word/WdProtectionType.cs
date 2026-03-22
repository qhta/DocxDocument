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
  wdAllowOnlyRevisions = unchecked((int)0),
  /// <summary>
  /// Specifies the type of protection applied to the current document.
  /// </summary>
  wdAllowOnlyComments = unchecked((int)1),
  /// <summary>
  /// Specifies the type of protection applied to the current document.
  /// </summary>
  wdAllowOnlyFormFields = unchecked((int)2),
  /// <summary>
  /// Allow read-only access to the document.
  /// </summary>
  wdAllowOnlyReading = unchecked((int)3),
  /// <summary>
  /// Specifies the type of protection applied to the current document.
  /// </summary>
  wdNoProtection = unchecked((int)-1)
}
