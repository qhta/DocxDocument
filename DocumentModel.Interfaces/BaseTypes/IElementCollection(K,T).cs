namespace DocumentModel;

/// <summary>
/// Collection of elements that have unique keys to identify them.
/// </summary>
/// <typeparam name="KeyType"></typeparam>
/// <typeparam name="ItemType"></typeparam>
public interface ElementCollection<KeyType, ItemType> : IElementCollection<ItemType> where ItemType : IUniqueModelElement<KeyType> where KeyType: IEquatable<KeyType>
{
}
