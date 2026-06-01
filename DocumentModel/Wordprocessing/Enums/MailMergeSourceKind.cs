namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the MailMergeSourceValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum MailMergeSourceKind
{
  /// <summary>
  ///   Database Data ISource.
  /// </summary>
  Database,

  /// <summary>
  ///   Address Book Data ISource.
  /// </summary>
  AddressBook,

  /// <summary>
  ///   Alternate IDocument Format Data ISource.
  /// </summary>
  Document1,

  /// <summary>
  ///   Alternate IDocument Format Data ISource Two.
  /// </summary>
  Document2,

  /// <summary>
  ///   Text File Data ISource.
  /// </summary>
  Text,

  /// <summary>
  ///   E-Mail Program Data ISource.
  /// </summary>
  IEmail,

  /// <summary>
  ///   Native Data ISource.
  /// </summary>
  Native,

  /// <summary>
  ///   Legacy IDocument Format Data ISource.
  /// </summary>
  Legacy,

  /// <summary>
  ///   Aggregate Data ISource.
  /// </summary>
  Master
}
