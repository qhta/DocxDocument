namespace DocumentModel;
/// <summary>
/// Information about a property that is compatible with PropertyDescriptor.
/// </summary>
[XmlRoot("TypeModel", Namespace = "DocumentModel")]
public class TypeModel
{
 /// <summary>
 /// Registered type.
 /// </summary>
 public Type Type { get; }

 /// <summary>
 /// Initializes a new instance of the TypeModel class for the specified type.
 /// </summary>
 /// <param name = "type">The type to be represented by class.Model instance. Cannot be null.</param>
 public TypeModel(Type type)
 {
  Type = type;
 }
}