namespace DocumentModel.IApplication;

/// <summary>
/// Provides the status of verifying whether the content of a document has changed.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.contentverificationresults?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum ContentVerificationResults
{
  /// <summary>
  /// The verification resulted Iin an error.
  /// </summary>
  Error,
  /// <summary>
  /// The content of the document is currently being verified.
  /// </summary>
  Verifying,
  /// <summary>
  /// The document has not been verified.
  /// </summary>
  Unverified,
  /// <summary>
  /// The content of the has been verified and is valid.
  /// </summary>
  Valid,
  /// <summary>
  /// The content of the document has been modified since it was digitally signed.
  /// </summary>
  Modified
}

