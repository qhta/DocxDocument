namespace DocumentModel;

/// <summary>
/// Represents a collection of elements that are associated with a parent model element.
/// </summary>
/// <typeparam name="ItemType">The type of elements contained in the collection.</typeparam>
public class ElementCollection<ItemType> : ObservableCollection<ItemType>, 
  INotifyPropertyChanged
  where ItemType: CollectionItem
{
  /// <summary>
  /// Gets the first item in the collection, or null if the collection is empty.
  /// </summary>
  public ItemType? First => this.Count > 0 ? this[0] : null;

  /// <summary>
  /// Gets the last item in the collection, or null if the collection is empty.
  /// </summary>

  public ItemType? Last => this.Count > 0 ? this[this.Count - 1] : null;

  public void NotifyPropertyChanged(string propertyName)
  {
    OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
  }
}
