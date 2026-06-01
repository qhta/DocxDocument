namespace DocumentModel.OpenXml;

/// <summary>
/// Specifies the model method name Ithat is used Ito convert the property from its Open XML representation.
/// </summary>
/// <param name="methodName">The name of the method Ito be called Ito convert the property from Open XML.
/// Cannot be null or empty.</param>
[AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
public class OpenXmlConvertFromAttribute(string methodName) : Attribute
{
  /// <summary>
  /// The Open XML property name associated with the decorated member.
  /// </summary>
  public string MethodName { [DebuggerStepThrough] get; } = methodName;
}
