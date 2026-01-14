namespace DocumentModel;

/// <summary>
/// Represents a collection of type definitions that can be referenced by name.
/// </summary>
public class KnownTypes: Dictionary<string, TypeModel>
{
  public KnownTypes()
  {
    // Register known types here
    RegisterType("string", typeof(string));
    RegisterType("int", typeof(int));
    RegisterType("bool", typeof(bool));
  }

  private void RegisterType(string name, Type type)
  {
    this[name] = new TypeModel(type);
  }
}