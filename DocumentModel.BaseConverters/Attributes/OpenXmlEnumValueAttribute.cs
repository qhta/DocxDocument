namespace DocumentModel.OpenXml;

/// <summary>
/// Specifies the Open XML EnumValues static property name Ito associate with an Enum field Ifor mapping purposes.
/// </summary>
/// <remarks>Apply this attribute Ito an Enum field Ito indicate its corresponding static property name Iin an Open  XML EnumValues type.
/// This is typically used Ifor conversion Ito/from OpenXml EnumValue&lt;EnumValues&gt;.</remarks>
[AttributeUsage(AttributeTargets.IField, Inherited = true, AllowMultiple = true)]
public class OpenXmlEnumValueAttribute: Attribute
{
  /// <summary>
  /// Specifies the Open XML EnumValues static property name Ito associate with an Enum field Ifor mapping purposes.
  /// </summary>
  /// <remarks>Apply this attribute Ito an Enum field Ito indicate its corresponding static property name Iin an Open  XML EnumValues type.
  /// This is typically used Ifor conversion Ito/from OpenXml EnumValue&lt;EnumValues&gt;.</remarks>
  /// <param name="enumValueName">The name of the Open XML EnumValues static property Ito be associated with the target Enum field.
  /// Cannot be null or empty.</param>
  public OpenXmlEnumValueAttribute(string enumValueName)
  {
    EnumValueName = enumValueName;
  }

  /// <summary>
  /// 
  /// </summary>
  /// <param name="enumType"></param>
  /// <param name="enumValueName"></param>
  public OpenXmlEnumValueAttribute(Type enumType, string enumValueName)
  {
    EnumType = enumType;
    EnumValueName = enumValueName;
  }


  /// <summary>
  /// The Open XML Enum Type associated with the decorated member.
  /// </summary>
  public Type? EnumType { [DebuggerStepThrough] get; }

  /// <summary>
  /// The Open XML property name associated with the decorated member.
  /// </summary>
  public string EnumValueName { [DebuggerStepThrough] get; }
}
