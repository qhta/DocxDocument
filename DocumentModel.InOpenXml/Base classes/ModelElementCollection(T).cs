namespace DocumentModel;


/// <summary>
/// Represents a collection of model elements that is associated with an OpenXml element.
/// </summary>
/// <typeparam name="ItemType">The type of elements contained in the collection.</typeparam>
/// <typeparam name="OpenXmlCollectionType">The type of the associated OpenXml element.</typeparam>
public abstract class ModelElementCollection<ItemType> : ElementCollection<ItemType> where ItemType : ModelElement
{
  protected bool isLoading;


  /// <summary>
  /// Initializes a new instance of the <see cref="ModelElement{OpenXmlItemType}"/> class.
  /// </summary>
  protected ModelElementCollection()
  {
    
  }

  /// <summary>
  /// Initializes a new instance of the ModelElementCollection class that contains elements copied from the specified
  /// collection.
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

