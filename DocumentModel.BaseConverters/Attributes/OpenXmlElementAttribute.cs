namespace DocumentModel.OpenXml;

/// <summary>
/// Specifies that the decorated model property is mapped to the Open XML child element with the given type.
/// </summary>
/// <remarks>This attribute can be applied to model property to indicate the order of the corresponding element in the Open Xml schema.
/// It can be also applied to classes to indicate the order of the corresponding element in the Open Xml schema.</remarks>
/// <param name="openXmlType">The type of Open XML element to be associated with the decorated property.
/// If it is empty, the default element type has the same name as the decorated property name.</param>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
public class OpenXmlElementAttribute(Type openXmlType) : Attribute
{
  
  /// <summary>
  /// The Open XML element type name associated with the decorated member.
  /// </summary>
  public Type OpenXmlType { [DebuggerStepThrough] get; } = openXmlType;
}