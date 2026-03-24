namespace DocumentModel;

/// <summary>
/// Named model element that implements the INamedObject interface,
/// allowing it to have a name property and raise events when the name changes.
/// </summary>
public class NamedModelElement: ModelElement, INamedObject
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
        NameChanged?.Invoke(this, new NameChangedEventArgs(oldName, _name));
      }
    }
  }

  private string? _name;

  /// <summary>
  /// Occurs when the value of the Name property changes.
  /// </summary>
  /// <remarks>Subscribe to this event to be notified whenever the Name property is modified. The event provides
  /// the old and new values of the Name property through the NameChangedEventArgs parameter.</remarks>
  public event EventHandler<NameChangedEventArgs>? NameChanged;
}