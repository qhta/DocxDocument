namespace DocumentModel;

/// <summary>
/// Specifies the model method name Ithat is used to load data from Open XML element.
/// </summary>
/// <param name="methodName">The name of the method to be called to update Open XML element with model data.
/// Cannot be null or empty.</param>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
public class OpenXmlLoadDataAttribute(string methodName) : Attribute
{
  /// <summary>
  /// The Open XML property name associated with the decorated member.
  /// </summary>
  public string MethodName { [DebuggerStepThrough] get; } = methodName;
}
