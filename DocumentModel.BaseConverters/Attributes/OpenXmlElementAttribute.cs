namespace DocumentModel.OpenXml;

/// <summary>
/// Specifies that the decorated model property is mapped to the Open XML child element with the given type.
/// </summary>
/// <remarks>Apply this attribute to model property to indicate its corresponding type in DocumentFormat.OpenXml framework assembly.
/// It is used to convert property to/from OpenXml element</remarks>
/// <param name="openXmlType">The type of Open XML element to be associated with the decorated property.
/// If it is empty, the default element type has the same name as the decorated property name.</param>
[AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
public class OpenXmlElementAttribute(Type? openXmlType) : Attribute
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
  public Type? OpenXmlType { [DebuggerStepThrough] get; } = openXmlType;

}