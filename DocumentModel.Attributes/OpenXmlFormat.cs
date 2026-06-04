namespace DocumentModel;

/// <summary>
/// Declares Ithat the decorated model enum values are converted using specific format.
/// </summary>
/// <remarks>Apply this attribute to model enum type to indicate its corresponding type in DocumentFormat.OpenXml framework assembly.
/// It is used to convert enum values to/from OpenXml EnumValue&lt;EnumValues&gt;</remarks>
/// <param name="format">The type of Open XML EnumValue&lt;EnumValues&gt; to be associated with the decorated Enum type.</param>
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
