namespace DocumentModel;
/// <summary>
/// Model for an object property.
/// </summary>
[DataContract]
[XmlRoot("ObjectProperty", Namespace = "DocumentModel")]
public abstract partial class ObjectProperty
{
  /// <summary>
  /// Name of the property.
  /// </summary>
  public string? Name { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}