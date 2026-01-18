namespace DocumentModel.OpenXml;

/// <summary>
/// Specifies the model method name that is used to convert the property to its Open XML representation.
/// </summary>
/// <param name="methodName">The name of the method to be called to convert the property to Open XML.
/// Cannot be null or empty.</param>[AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
public class ConvertToOpenXmlAttribute(string methodName) : Attribute
{
  /// <summary>
  /// The Open XML property name associated with the decorated member.
  /// </summary>
  public string MethodName { get; } = methodName;
}