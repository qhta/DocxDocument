namespace DocumentModel.OpenXml;

/// <summary>
/// Specifies that the decorated model class is a collection of Open XML elements.
/// </summary>
/// <param name="type">The type of Open XML element that can be a child of an element associated with this class.
/// </param>
[AttributeUsage(AttributeTargets.Class, Inherited = true, AllowMultiple = true)]
public class OpenXmlItemAttribute(Type? type) : Attribute
{
  /// <summary>
  /// Default constructor - without element name.
  /// </summary>
  public OpenXmlItemAttribute() : this(null)
  {
  }

  /// <summary>
  /// The Open XML element type name associated with the decorated member.
  /// </summary>
  public Type? Type { [DebuggerStepThrough] get; } = type;

}