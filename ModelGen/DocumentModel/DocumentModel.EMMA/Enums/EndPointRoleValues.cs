namespace DocumentModel.EMMA;

/// <summary>
/// Defines the EndPointRoleValues enumeration.
/// </summary>
public enum EndPointRoleValues
{
  /// <summary>
  /// source.
  /// </summary>
  [XmlEnum("source")]
  Source,
  
  /// <summary>
  /// sink.
  /// </summary>
  [XmlEnum("sink")]
  Sink,
  
  /// <summary>
  /// reply-to.
  /// </summary>
  [XmlEnum("reply-to")]
  Replyto,
  
  /// <summary>
  /// router.
  /// </summary>
  [XmlEnum("router")]
  Router,
  
}
