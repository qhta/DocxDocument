namespace DocumentModel;

/// <summary>
/// Attribute to mark a property or method as unavailable for use, indicating that it should not be accessed or used in the current context. \\
/// </summary>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
public class UnavailableAttribute(string? message) : Attribute
{
  /// <summary>
  /// Optional message providing additional information about the unavailability of the property or method.
  /// This message can be used to explain why the member is unavailable or to suggest alternative members to use instead.
  /// </summary>
  public string? Message { get; } = message;
}