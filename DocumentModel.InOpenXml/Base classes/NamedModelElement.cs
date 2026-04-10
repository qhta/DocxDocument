namespace DocumentModel;
/// <summary>
/// Named model element that implements the INamedObject interface,
/// allowing it to have a name property and raise events when the name changes.
/// </summary>
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
  set
  {
   if (_name != value)
   {
    var oldName = _name;
    _name = value;
    NotifyPropertyChanged("Name", oldName, _name);
   }
  }
 }

 private string? _name;
}