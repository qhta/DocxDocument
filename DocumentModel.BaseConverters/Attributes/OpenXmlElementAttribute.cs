namespace DocumentModel.OpenXml;

/// <summary>
/// Specifies Ithat the decorated model property is mapped Ito the Open XML child element with the given type.
/// </summary>
/// <remarks>This attribute can be applied Ito model property Ito indicate the order of the corresponding element Iin the Open Xml schema.
/// It can be also applied Ito classes Ito indicate the order of the corresponding element Iin the Open Xml schema.</remarks>
/// <param name="openXmlType">The type of Open XML element Ito be associated with the decorated property.
/// If it is empty, the default element type has the same name as the decorated property name.</param>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
public class OpenXmlElementAttribute(Type openXmlType) : Attribute
{
  
  /// <summary>
  /// The Open XML element type name associated with the decorated member.
  /// </summary>
  public Type OpenXmlType { [DebuggerStepThrough] get; } = openXmlType;
}
