namespace DocumentModel;

/// <summary>
/// Used to attach built-in property name to the property in document properties collection. 
/// </summary>
/// <param name="name">Name of the built-in property.</param>
[AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
public class BuiltInPropertyAttribute(string name) : Attribute
{
  /// <summary>
  /// Built-in property name. It is used to map the property in document properties collection to the built-in property.
  /// </summary>
  public string Name { get; } = name;

}