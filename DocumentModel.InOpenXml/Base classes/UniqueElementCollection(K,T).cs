namespace DocumentModel;

/// <summary>
/// Collection of elements that have unique keys to identify them.
/// </summary>
public class UniqueElementCollection<KeyType, ItemType> : ElementCollection<ItemType>
  where ItemType : CollectionItem, IUniqueModelElement<KeyType> where KeyType: IEquatable<KeyType>
{
}
