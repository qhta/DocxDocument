namespace DocumentModel;
/// <summary>
///   Maintains a collection of type definitions that can be referenced by name for model mapping and serialization.
/// </summary>
[XmlRoot("KnownTypes", Namespace = "DocumentModel")]
public class KnownTypes : Dictionary<string, TypeModel>
{
 /// <summary>
 ///   Initializes the collection with a set of commonly used .NET types.
 /// </summary>
 public KnownTypes()
 {
  // Register known types here
  RegisterType("string", typeof(string));
  RegisterType("int", typeof(int));
  RegisterType("bool", typeof(bool));
 }

 /// <summary>
 ///   Registers a type definition in the collection under the specified name.
 /// </summary>
 /// <param name = "name">The name to associate with the type.</param>
 /// <param name = "type">The .NET type to register.</param>
 private void RegisterType(string name, Type type)
 {
  this[name] = new TypeModel(type);
 }
}