namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the DocumentTypeValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum DocumentKind
{
  /// <summary>
  ///   Default Document.
  /// </summary>
  NotSpecified,

  /// <summary>
  ///   Letter.
  /// </summary>
  Letter,

  /// <summary>
  ///   E-Mail Message.
  /// </summary>
  Email
}