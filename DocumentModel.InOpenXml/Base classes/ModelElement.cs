namespace DocumentModel;

/// <summary>
/// Base class for all model elements, providing property change notification support.
/// </summary>
public abstract class ModelElement: INotifyPropertyChanged, IEquatable<ModelElement>
{
  /// <summary>
  /// Default constructor needed for serialization.
  /// </summary>
  protected ModelElement()
  {
  }

  /// <summary>
  /// Occurs when a property value changes. Can be subscribed to by listeners to receive notifications of property changes.
  /// </summary>
  public event PropertyChangedEventHandler? PropertyChanged;

  /// <summary>
  /// Raises a property changed notification for the specified property.
  /// </summary>
  /// <remarks>Call this method to notify listeners that a property value has changed, typically when
  /// implementing the INotifyPropertyChanged interface in data-binding scenarios.</remarks>
  /// <param name="propertyName">The name of the property that has changed. Cannot be null or empty.</param>
  public void NotifyPropertyChanged(string propertyName)
  {
    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
  }

  /// <summary>
  /// Determines whether the current ModelElement is equal to another ModelElement instance.
  /// </summary>
  /// <param name="other">The ModelElement to compare with the current instance. Can be null.</param>
  /// <returns>true if the specified ModelElement is equal to the current instance; otherwise, false.</returns>
  public bool Equals(ModelElement? other)
  {
    if (other is null) return false;
    if (ReferenceEquals(this, other)) return true;
    return DeepComparer.DeepEqual(this, other);
  }

  /// <summary>
  /// Determines whether the specified object is equal to the current ModelElement instance.
  /// </summary>
  /// <remarks>Equality is determined by comparing the runtime type and the values of the ModelElement. This
  /// method overrides Object.Equals(Object).</remarks>
  /// <param name="obj">The object to compare with the current ModelElement instance.</param>
  /// <returns>true if the specified object is a ModelElement and is equal to the current instance; otherwise, false.</returns>
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
  public override bool Equals(object? obj)
  {
    if (obj is null) return false;
    if (ReferenceEquals(this, obj)) return true;
    if (obj.GetType() != GetType()) return false;
    return Equals((ModelElement)obj);
  }

}