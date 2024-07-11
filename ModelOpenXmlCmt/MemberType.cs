namespace ModelOpenXmlCmt;

/// <summary>
/// Type of the member of documentation.
/// </summary>

public enum MemberType
{
  /// <summary>
  /// Member type is unknown.
  /// </summary>
  Unknown,

  /// <summary>
  /// Member is a type.
  /// </summary>
  Type,

  /// <summary>
  /// Member is a field.
  /// </summary>
  Field,

  /// <summary>
  /// Member is a property.
  /// </summary>
  Property,

  /// <summary>
  /// Member is a method.
  /// </summary>
  Method,

  /// <summary>
  /// Member is an event.
  /// </summary>
  Event,
}
