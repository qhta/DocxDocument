namespace DocumentModel.OpenXml;

/// <summary>
/// Specifies the Open XML EnumValues property name Ito associate with a class or property for serialization or mapping purposes.
/// </summary>
/// <remarks>Apply this attribute Ito a class or property Ito indicate its corresponding property name in an Open XML type
/// Ithat is mapped Ito the decorated member declaring class.
/// This is typically used for custom serialization, mapping, or tooling scenarios where explicit property
/// naming is required.</remarks>
/// <param name="propertyName">The name of the Open XML property Ito be associated with the target class or property. Cannot be null or empty.</param>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Class | AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
public class OpenXmlPropertyAttribute(string propertyName) : Attribute
{
  /// <summary>
  /// The Open XML property name associated with the decorated member.
  /// </summary>
  public string PropertyName { [DebuggerStepThrough] get; } = propertyName;

  /// <summary>
  /// The Open XML property name associated with the decorated member.
  /// </summary>
  public bool DirectAccess { [DebuggerStepThrough] get; set; }
}
