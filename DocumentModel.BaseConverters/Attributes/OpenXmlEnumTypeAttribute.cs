namespace DocumentModel.OpenXml;

/// <summary>
/// Specifies that the decorated model enum type is mapped to the Open XML EnumValue&lt;EnumValues&gt;.
/// </summary>
/// <remarks>Apply this attribute to model enum type to indicate its corresponding type in DocumentFormat.OpenXml framework assembly.
/// It is used to convert enum values to/from OpenXml EnumValue&lt;EnumValues&gt;</remarks>
/// <param name="openXmlType">The type of Open XML EnumValue&lt;EnumValues&gt; to be associated with the decorated Enum type.</param>
[AttributeUsage(AttributeTargets.Enum, Inherited = true, AllowMultiple = false)]
public class OpenXmlEnumTypeAttribute(Type? openXmlType) : Attribute
{
  /// <summary>
  /// Default constructor - without element name.
  /// </summary>
  public OpenXmlEnumTypeAttribute() : this(null)
  {
  }

  /// <summary>
  /// The Open XML element type name associated with the decorated member.
  /// </summary>
  public Type? OpenXmlType { [DebuggerStepThrough] get; } = openXmlType;

}