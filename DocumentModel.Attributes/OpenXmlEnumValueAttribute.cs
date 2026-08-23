namespace DocumentModel;

/// <summary>
/// Specifies the Open XML EnumValues static property name to associate with an Enum field for mapping purposes.
/// </summary>
/// <remarks>Apply this attribute to an Enum field to indicate its corresponding static property name in an Open  XML EnumValues type.
/// This is typically used for conversion to/from OpenXml EnumValue&lt;EnumValues&gt;.</remarks>
[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
public class OpenXmlEnumValueAttribute : Attribute
{
  /// <summary>
  /// Specifies the Open XML EnumValues static property name to associate with an Enum field for mapping purposes.
  /// </summary>
  /// <remarks>Apply this attribute to an Enum field to indicate its corresponding static property name in an Open  XML EnumValues type.
  /// This is typically used for conversion to/from OpenXml EnumValue&lt;EnumValues&gt;.</remarks>
  /// <param name="enumValueName">The name of the Open XML EnumValues static property to be associated with the target Enum field.
  /// Cannot be null or empty.</param>
  public OpenXmlEnumValueAttribute(string enumValueName)
  {
    EnumValueName = enumValueName;
  }

  /// <summary>
  /// Specifies the Open XML EnumValues static property name to associate with an Enum field for mapping purposes.
  /// </summary>
  /// <param name="enumType">The Open XML Enum type to be associated with the target Enum field.</param>
  /// <param name="enumValueName">The name of the Open XML EnumValues static property to be associated with the target Enum field.</param>
  public OpenXmlEnumValueAttribute(Type enumType, string enumValueName)
  {
    EnumType = enumType;
    EnumValueName = enumValueName;
  }

  /// <summary>
  /// Specifies the Open XML Enum integer value to associate with an Enum field for mapping purposes.
  /// </summary>
  /// <remarks>Apply this attribute to an Enum field to indicate its corresponding static property name in an Open  XML EnumValues type.
  /// This is typically used for conversion to/from OpenXml EnumValue&lt;EnumValues&gt;.</remarks>
  /// <param name="enumValue">The Open XML Enum integer value to be associated with the target Enum field.</param>
  public OpenXmlEnumValueAttribute(int enumValue)
  {
    EnumValue = enumValue;
  }

  /// <summary>
  /// Specifies the Open XML Enum integer value to associate with an Enum field for mapping purposes.
  /// </summary>
  /// <param name="enumType">The Open XML Enum type to be associated with the target Enum field.</param>
  /// <param name="enumValue">The Open XML Enum integer value to be associated with the target Enum field.</param>
  public OpenXmlEnumValueAttribute(Type enumType, int enumValue)
  {
    EnumType = enumType;
    EnumValue = enumValue;
  }
  /// <summary>
  /// The Open XML Enum Type associated with the decorated member.
  /// </summary>
  public Type? EnumType { [DebuggerStepThrough] get; }

  /// <summary>
  /// The Open XML property name associated with the decorated member.
  /// </summary>
  public string? EnumValueName { [DebuggerStepThrough] get; }

  /// <summary>
  /// The Open XML Enum integer value associated with the decorated member.
  /// </summary>
  public int? EnumValue { [DebuggerStepThrough] get; }
}
