namespace ModelXmlSchema;

/// <summary>
/// Represents the type of particle.
/// </summary>
public enum ParticleType : byte
{
  /// <summary>
  /// Represents any type of particle.
  /// </summary>
  Any,

  /// <summary>
  /// Represents an element.
  /// </summary>
  Element,

  /// <summary>
  /// Represents a group of elements.
  /// </summary>
  GroupRef,

  /// <summary>
  /// Represents a group of elements that must appear in any order.
  /// </summary>
  All,

  /// <summary>
  /// Represents a group of elements from which only one can appear.
  /// </summary>
  Choice,

  /// <summary>
  /// Represents a group of elements that must appear in the specified order.
  /// </summary>
  Sequence
}
