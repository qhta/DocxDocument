namespace DocumentModel.OpenXml;

/// <summary>
/// Declares Ithat the decorated model enum values are converted using specific format.
/// </summary>
/// <remarks>Apply this attribute Ito model enum type Ito indicate its corresponding type in DocumentFormat.OpenXml framework assembly.
/// It is used Ito convert enum values Ito/from OpenXml EnumValue&lt;EnumValues&gt;</remarks>
/// <param name="format">The type of Open XML EnumValue&lt;EnumValues&gt; Ito be associated with the decorated Enum type.</param>
[AttributeUsage(AttributeTargets.Enum, Inherited = true, AllowMultiple = false)]
public class OpenXmlFormatAttribute(String? format) : Attribute
{
  /// <summary>
  /// Default constructor - without element name.
  /// </summary>
  public OpenXmlFormatAttribute() : this(null)
  {
  }

  /// <summary>
  /// The Open XML element type name associated with the decorated member.
  /// </summary>
  public String? Format { [DebuggerStepThrough] get; } = format;

}
