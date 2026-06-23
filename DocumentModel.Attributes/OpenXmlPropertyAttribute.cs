namespace DocumentModel;

/// <summary>
/// Specifies the Open XML EnumValues property name to associate with a class or property for serialization or mapping purposes.
/// </summary>
/// <remarks>Apply this attribute to a class or property to indicate its corresponding property name in an Open XML type
/// that is mapped to the decorated member declaring class.
/// This is typically used for custom serialization, mapping, or tooling scenarios where explicit property
/// naming is required.</remarks>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Class | AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
public class OpenXmlPropertyAttribute: Attribute
{
  /// <summary>
  /// Specifies the Open XML property name to associate with a class or property for serialization or mapping purposes.
  /// </summary>
  /// <remarks>Apply this attribute to a class or property to indicate its corresponding property name in an Open XML type
  /// that is mapped to the decorated member declaring class.
  /// This is typically used for custom serialization, mapping, or tooling scenarios where explicit property
  /// naming is required.</remarks>
  /// <param name="propertyName">The name of the Open XML property to be associated with the target class or property. Cannot be null or empty.</param>
  public OpenXmlPropertyAttribute(string propertyName)
  {
    PropertyName = propertyName;
  }

  /// <summary>
  /// Specifies the Open XML type and property name to associate with a class or property
  /// </summary>
  /// <param name="openXmlType">The Open XML type to associate with the target class or property. Cannot be null.</param>
  /// <param name="propertyName">The name of the Open XML property to be associated with the target class or property. Cannot be null or empty.</param>
  public OpenXmlPropertyAttribute(Type openXmlType, string propertyName)
  {
    Type = openXmlType;
    PropertyName = propertyName;
  }

  /// <summary>
  /// The Open XML property name associated with the decorated member.
  /// </summary>
  public string PropertyName { [DebuggerStepThrough] get; }

  /// <summary>
  /// The type associated with the Open XML property.
  /// </summary>
  public Type? Type { [DebuggerStepThrough] get; }

  /// <summary>
  /// The Open XML property name associated with the decorated member.
  /// </summary>
  public bool DirectAccess { [DebuggerStepThrough] get; set; }
}
