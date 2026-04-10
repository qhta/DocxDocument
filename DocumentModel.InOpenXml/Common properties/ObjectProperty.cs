namespace DocumentModel;
/// <summary>
/// Model for an object property.
/// </summary>
[XmlRoot("ObjectProperty", Namespace = "DocumentModel")]
public abstract partial class ObjectProperty
{
 /// <summary>
 /// Name of the property.
 /// </summary>
 public string? Name { get; set; }
}