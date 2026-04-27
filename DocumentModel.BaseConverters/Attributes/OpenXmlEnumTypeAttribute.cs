namespace DocumentModel.OpenXml;

/// <summary>
/// Specifies mapping of the model enum type to one of the types used in OpenXML.
/// <para>
/// It can be mapped to the Open XML EnumValue&lt;EnumValues&gt; or to the EnumValues type itself, depending on the usage scenario.
/// The former is used when the model enum is used as a property type of type OpenXmlSimpleType,
/// and the latter is used when the model enum is used as a property type of type EnumValue&lt;EnumValues&gt;.
/// </para>
/// <para>
/// It can be mapped to the String type when the model enum is used as a property type of type StringValue,
/// and the conversion between enum values and string values is handled using OpenXmlEnumValueAttribute on the enum members.
/// </para>
/// </summary>
/// <param name="targetType">The type to be associated with the decorated Enum type when converted to/from Open XML.</param>
[AttributeUsage(AttributeTargets.Enum, Inherited = true, AllowMultiple = true)]
public class OpenXmlEnumTypeAttribute(Type targetType) : Attribute
{

  /// <summary>
  /// The Open XML element type name associated with the decorated member.
  /// </summary>
  public Type TargetType { [DebuggerStepThrough] get; } = targetType;

}