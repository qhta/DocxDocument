using System.Diagnostics;

namespace DocumentModel.OpenXml;

/// <summary>
/// Specifies the Word Interop Enum type value name to associate with an Enum field for mapping purposes.
/// </summary>
/// <remarks>Apply this attribute to an Enum field to indicate its corresponding static property name in a Word Interop Enum type.
/// This is typically used for conversion to/from Word Interop Enum values.</remarks>
[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
public class WordInteropEnumValueAttribute: Attribute
{
  /// <summary>
  /// Specifies the Word Interop Enum type value name to associate with an Enum field for mapping purposes.
  /// </summary>
  /// <remarks>Apply this attribute to an Enum field to indicate its corresponding static property name in a Word Interop Enum type.
  /// This is typically used for conversion to/from Word Interop Enum values.</remarks>
  /// <param name="enumValueName">The name of the Word Interop Enum type value to be associated with the target Enum field.
  /// Cannot be null or empty.</param>
  public WordInteropEnumValueAttribute(string enumValueName)
  {
    EnumValueName = enumValueName;
  }

  /// <summary>
  /// Specifies the Word Interop Enum type and value name to associate with an Enum field for mapping purposes.
  /// </summary>
  /// <param name="enumType">The Word Interop Enum type to be associated with the target Enum field.</param>
  /// <param name="enumValueName">The name of the Word Interop Enum type value to be associated with the target Enum field.</param>
  public WordInteropEnumValueAttribute(Type enumType, string enumValueName)
  {
    EnumType = enumType;
    EnumValueName = enumValueName;
  }


  /// <summary>
  /// The Word Interop Enum Type associated with the decorated member.
  /// </summary>
  public Type? EnumType { [DebuggerStepThrough] get; }

  /// <summary>
  /// The Open XML property name associated with the decorated member.
  /// </summary>
  public string EnumValueName { [DebuggerStepThrough] get; }
}
