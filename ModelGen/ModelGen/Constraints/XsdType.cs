namespace ModelGen;

/// <summary>
/// Enum type that describes accepted string formats. 
/// Allows several different formats for a string.
/// </summary>
[Flags]
public enum XsdType
{
  /// <summary>
  /// String can be an unique identifier.
  /// </summary>
  Id = 1,

  /// <summary>
  /// String can be a name.
  /// </summary>
  Name = 2,

  /// <summary>
  /// String can be a token (as defined in Xsd schema)
  /// </summary>
  Token = 4,

  /// <summary>
  /// String can be an unqualified name (as defined in Xsd schema)
  /// </summary>
  NcName = 8,

  /// <summary>
  /// String can be an qualified name (as defined in Xsd schema)
  /// </summary>
  QName = 16,

  /// <summary>
  /// String can be in URI format (as defined in Xsd schema)
  /// </summary>
  Uri = 32,
}
