namespace DocumentModel;

/// <summary>
/// Base class for all model elements, providing property change notification support.
/// </summary>
public class ModelElement: INotifyPropertyChanged
{
  /// <summary>
  /// Occurs when a property value changes.
  /// </summary>
  public event PropertyChangedEventHandler? PropertyChanged;

  /// <summary>
  /// Raises the <see cref="PropertyChanged"/> event for the specified property.
  /// </summary>
  /// <param name="propertyName">The name of the property that changed.</param>
  protected virtual void OnPropertyChanged(string propertyName)
  {
    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
  }

  public void NotifyPropertyChanged(string propertyName)
  {
    OnPropertyChanged(propertyName);
  }
}