namespace DocumentModel.OpenXml;

/// <summary>
/// Specifies the Open XML property name to associate with a class or property for serialization or mapping purposes.
/// </summary>
/// <remarks>Apply this attribute to a class or property to indicate its corresponding property name in an Open
/// XML document. This is typically used for custom serialization, mapping, or tooling scenarios where explicit property
/// naming is required.</remarks>
/// <param name="propertyName">The name of the Open XML property to be associated with the target class or property. Cannot be null or empty.</param>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
public class OpenXmlPropertyAttribute(string propertyName) : Attribute
{
  /// <summary>
  /// The Open XML property name associated with the decorated member.
  /// </summary>
  public string PropertyName { [DebuggerStepThrough] get; } = propertyName;
}