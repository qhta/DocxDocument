namespace DocumentModel;

/// <summary>
/// Specifies the model method name that is used to update Open XML element with model data.
/// It must be a public or non-public instance method defined in the model class and should accept an Open XML element as a parameter.
/// </summary>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
public class OpenXmlUpdateDataAttribute : Attribute
{
  /// <summary>
  /// Specifies the model method name that is used to update Open XML element with model data.
  /// </summary>
  /// <param name="methodName">The name of the method to be called to update Open XML element with model data.
  /// Cannot be null or empty.</param>
  public OpenXmlUpdateDataAttribute(string methodName)
  {
    MethodName = methodName;
  }

  /// <summary>
  /// The Open XML property name associated with the decorated member.
  /// </summary>
  public string MethodName { [DebuggerStepThrough] get; }
}
