namespace DocumentModel;

/// <summary>
/// Attribute to indicate that a class or struct represents a simple type in the model.
/// </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = false, AllowMultiple = false)]
public class SimpleTypeAttribute: Attribute
{
  
}