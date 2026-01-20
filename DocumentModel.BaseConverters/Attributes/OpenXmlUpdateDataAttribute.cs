namespace DocumentModel.OpenXml;

/// <summary>
/// Specifies the model method name that is used to update Open XML element with model data.
/// </summary>
/// <param name="methodName">The name of the method to be called to update Open XML element with model data.
/// Cannot be null or empty.</param>
[AttributeUsage(AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
public class OpenXmlUpdateDataAttribute(string methodName) : Attribute
{
  /// <summary>
  /// The Open XML property name associated with the decorated member.
  /// </summary>
  public string MethodName { [DebuggerStepThrough] get; } = methodName;
}