namespace ModelXmlSchema;

/// <summary>
/// Enumerates discriminators of the attribute classes.
/// </summary>
public enum AttributeType: byte
{
  /// <summary>
  /// An attribute definition.
  /// </summary>
  AttributeDef,

  /// <summary>
  /// Attribute reference.
  /// </summary>
  AttributeRef,

  /// <summary>
  /// Group of attributes.
  /// </summary>
  AttributeGroup,

  /// <summary>
  /// AttributeGroup reference.
  /// </summary>
  AttributeGroupRef,
}
