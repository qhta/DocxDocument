namespace DocumentModel;

/// <summary>
/// Specifies the model method name that is used to load data from Open XML element.
/// It must be a public or non-public instance method defined in the model class and should accept an Open XML element as a parameter.
/// </summary>
/// <param name="methodName">The name of the method to be called to load data from Open XML element.
/// Cannot be null or empty.</param>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
public class OpenXmlLoadDataAttribute(string methodName) : Attribute
{
  /// <summary>
  /// The Open XML property name associated with the decorated member.
  /// </summary>
  public string MethodName { [DebuggerStepThrough] get; } = methodName;
}
