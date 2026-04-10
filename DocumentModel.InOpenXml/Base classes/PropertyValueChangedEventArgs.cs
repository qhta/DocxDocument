namespace DocumentModel;
/// <summary>
/// EventArgs class that extends the standard PropertyChangedEventArgs to include old and new values of the property that changed. 
/// </summary>
/// <param name = "propertyName">Name of the property that was changed.</param>
/// <param name = "oldValue">Old value of the property.</param>
/// <param name = "newValue">New value of the property.</param>
[XmlRoot("PropertyValueChangedEventArgs", Namespace = "DocumentModel")]
public class PropertyValueChangedEventArgs(string propertyName, object? oldValue, object? newValue) : PropertyChangedEventArgs(propertyName)
{
 /// <summary>
 /// Old name of the object before the change.
 /// This value can be null if the object did not have a name assigned before or if the old name is not available.
 /// </summary>
 public object? OldValue => oldValue;
 /// <summary>
 /// New name of the object after the change.
 /// This value can be null if the object does not have a name assigned or if the new name is not available.
 /// </summary>
 public object? NewValue => newValue;
}