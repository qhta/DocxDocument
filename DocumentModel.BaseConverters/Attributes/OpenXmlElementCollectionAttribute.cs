namespace DocumentModel.OpenXml;

/// <summary>
/// Specifies that the decorated model property type is mapped to the Open XML child element collection.
/// </summary>
[AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
public class OpenXmlElementCollectionAttribute(Type openXmlType) : Attribute
{

  /// <summary>
  /// The Open XML element type name associated with the decorated member.
  /// </summary>
  public Type? OpenXmlType { [DebuggerStepThrough] get; } = openXmlType;
}