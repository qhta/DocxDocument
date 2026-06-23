namespace DocumentModel;

/// <summary>
/// Specifies the model method name that is used to set data in model property.
/// </summary>
/// <param name="methodName">The name of the method to be called to set data in model property.
/// Cannot be null or empty.</param>
[AttributeUsage( AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
public class OpenXmlSetMethodAttribute(string methodName) : Attribute
{
  /// <summary>
  /// The Open XML property name associated with the decorated member.
  /// </summary>
  public string MethodName { [DebuggerStepThrough] get; } = methodName;
}
