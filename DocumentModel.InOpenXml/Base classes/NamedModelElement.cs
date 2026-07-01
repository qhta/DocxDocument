namespace DocumentModel;
/// <summary>
/// Named model element that implements the INamedObject interface,
/// allowing it to have a name property and raise events when the name changes.
/// </summary>
[DataContract]
[XmlRoot("NamedModelElement", Namespace = "DocumentModel")]
public class NamedModelElement : ModelElement, INamedObject
{
 /// <summary>
 /// Represents the name of the model element.
 /// Setting this property will raise the NameChanged event if the name changes.
 /// </summary>
 public string? Name
 {
  get => _name;
  set => UpdateField(ref _name, value, nameof(Name));
 }
  /// <summary>
  /// Backing field for the Name property. It must be protected to allow BuiltInProperty to set it directly during XML deserialization without triggering the PropertyChanged event, which could lead to unintended side effects during deserialization.
  /// </summary>
  protected string? _name;
}