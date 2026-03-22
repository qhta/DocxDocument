namespace DocumentModel;
/// <summary>
///   Represents a collection of model elements associated with an OpenXml element, providing synchronization between the document model and OpenXml representation.
///   Supports initialization from an existing collection and advanced collection management for WordprocessingML or other OpenXml-based elements.
/// </summary>
/// <typeparam name="ItemType">Specifies the type of model elements contained in the collection.</typeparam>
public abstract class ModelElementCollection<ItemType> : ElementCollection<ItemType> where ItemType : ModelElement
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="ModelElementCollection{ItemType}"/> class.
  /// </summary>
  protected ModelElementCollection()
  {
  }
  /// <summary>
  ///   Initializes a new instance of the <see cref="ModelElementCollection{ItemType}"/> class that contains elements copied from the specified collection.
  /// </summary>
  /// <param name="items">The collection of items to copy into the new collection. Cannot be null.</param>
  protected ModelElementCollection(IEnumerable<ItemType> items) : this()
  {
    foreach (var item in items)
    {
      Add(item);
    }
  }
}
