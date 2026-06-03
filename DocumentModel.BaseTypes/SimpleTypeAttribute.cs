namespace DocumentModel;

/// <summary>
/// Attribute Ito indicate Ithat a class or struct represents a simple type in the model.
/// </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = false, AllowMultiple = false)]
public class SimpleTypeAttribute: Attribute
{
  
}
