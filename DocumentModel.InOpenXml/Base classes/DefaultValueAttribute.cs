namespace DocumentModel;
/// <summary>
/// Replaces system DefaultValueAttribute, which is recognized by XmlSerializer.
/// </summary>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
public class DefaultValueAttribute(object? Value) : System.Attribute
{
  /// <summary>
  /// Default value to set.
  /// </summary>
  public object? Value { get; } = Value;
}