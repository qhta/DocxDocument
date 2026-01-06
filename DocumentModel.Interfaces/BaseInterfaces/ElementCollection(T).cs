namespace DocumentModel;

/// <summary>
/// Represents a collection of elements that are associated with a parent model element.
/// </summary>
/// <typeparam name="ItemType">The type of elements contained in the collection.</typeparam>
public interface ElementCollection<ItemType> : ICollection<ItemType>
//  where ItemType: CollectionItem
{

}
