namespace DocumentModel.OpenXml;

/// <summary>
/// Specifies that the decorated model property or class is mapped to the Open XML child element with the given type name.
/// </summary>
/// <remarks>Apply this attribute to a class or property to indicate its corresponding element name in an Open
/// XML document. This is typically used for custom serialization, mapping, or tooling scenarios where explicit element
/// naming is required.</remarks>
/// <param name="elementName">The name of the Open XML element to be associated with the target class or property.
/// If it is empty, the default element name is the same as decorated property or class name.</param>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
public class OpenXmlElementAttribute(string? elementName) : Attribute
{
  /// <summary>
  /// Default constructor - without element name.
  /// </summary>
  public OpenXmlElementAttribute() : this(null)
  {
  }

  /// <summary>
  /// The Open XML element type name associated with the decorated member.
  /// </summary>
  public string? ElementName { get; } = elementName;
}