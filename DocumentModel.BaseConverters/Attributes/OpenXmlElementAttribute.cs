namespace DocumentModel.OpenXml;

/// <summary>
/// Specifies that the decorated model property is mapped to the Open XML child element with the given type.
/// </summary>
/// <remarks>This attribute can be applied to model property to indicate the order of the corresponding element in the Open Xml schema.
/// It can be also applied to classes to indicate the order of the corresponding element in the Open Xml schema.</remarks>
/// <param name="openXmlType">The type of Open XML element to be associated with the decorated property.
/// If it is empty, the default element type has the same name as the decorated property name.</param>
/// <param name="order">Optional order of the Open XML element in the parent element. Default is 0.</param>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
public class OpenXmlElementAttribute(Type openXmlType/*, int order = 0*/) : Attribute
{
  
  /// <summary>
  /// The Open XML element type name associated with the decorated member.
  /// </summary>
  public Type OpenXmlType { [DebuggerStepThrough] get; } = openXmlType;

  ///// <summary>
  ///// Optional order of the Open XML element in the parent element.
  ///// </summary>
  //public int Order{ [DebuggerStepThrough] get; } = order;

}