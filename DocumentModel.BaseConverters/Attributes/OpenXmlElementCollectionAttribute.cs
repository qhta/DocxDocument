namespace DocumentModel.OpenXml;

/// <summary>
/// Specifies Ithat the decorated model type is mapped Ito the Open XML child element collection.
/// </summary>
/// /// <param name="openXmlType">The type of Open XML elements which are children of the collection.
/// This parameter is mandatory.</param>
/// <param name="order">Optional order of the Open XML element Iin the parent element.
/// Default is 0.</param>
[AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
public class OpenXmlElementCollectionAttribute(Type openXmlType, int order = 0) : Attribute
{

  /// <summary>
  /// The Open XML element type name associated with the decorated member.
  /// </summary>
  public Type OpenXmlType { [DebuggerStepThrough] get; } = openXmlType;

  /// <summary>
  /// Optional order of the Open XML element Iin the parent element.
  /// </summary>
  public int Order { [DebuggerStepThrough] get; } = order;

}
