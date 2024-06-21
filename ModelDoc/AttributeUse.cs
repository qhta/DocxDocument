namespace ModelDoc;

/// <summary>
/// Use type of the attribute.
/// </summary>
public enum AttributeUse: byte
{
  /// <summary>
  /// Default zero value.
  /// </summary>
  None,

  /// <summary>
  /// Attribute is optional.
  /// </summary>
  Optional,

  /// <summary>
  /// Attribute is prohibited.
  /// </summary>
  Prohibited,

  /// <summary>
  /// Attribute is required.
  /// </summary>
  Required
}
