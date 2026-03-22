namespace DocumentModel.Interop.Core;

/// <summary>
/// Provides the status of verifying whether the content of a document has changed.
/// </summary>
public enum ContentVerificationResults
{
  /// <summary>
  /// The verification resulted in an error.
  /// </summary>
  contverresError,
  /// <summary>
  /// The content of the document is currently being verified. contverresUnverified2 The document has not been
  /// verified.
  /// </summary>
  contverresVerifying,
  /// <summary>
  /// Provides the status of verifying whether the content of a document has changed.
  /// </summary>
  contverresUnverified,
  /// <summary>
  /// The content of the has been verified and is valid. contverresModified4 The content of the document has been
  /// modified since it was digitally signed.
  /// </summary>
  contverresValid,
  /// <summary>
  /// Provides the status of verifying whether the content of a document has changed.
  /// </summary>
  contverresModified
}
