namespace DocumentModel;

/// <summary>
/// Collection of elements that have unique keys to identify them.
/// </summary>
/// <typeparam name="KeyType"></typeparam>
/// <typeparam name="ItemType"></typeparam>
public interface ElementCollection<KeyType, ItemType> : ElementCollection<ItemType> 
  where ItemType : UniqueModelElement<KeyType> where KeyType: IEquatable<KeyType>
{
}
