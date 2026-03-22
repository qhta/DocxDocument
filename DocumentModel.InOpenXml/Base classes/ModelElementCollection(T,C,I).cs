
namespace DocumentModel;

/// <summary>
/// Represents a collection of model elements that can be synchronized with an Open XML composite element and its child elements.
/// </summary>
/// <typeparam name="ItemType">Type of the model element contained in the collection.</typeparam>
/// <typeparam name="OpenXmlCollectionType">Type of the Open XML composite element representing the collection.</typeparam>
/// <typeparam name="OpenXmlItemType">Type of the Open XML element representing individual items.</typeparam>
public abstract class ModelElementCollection<ItemType, OpenXmlCollectionType, OpenXmlItemType> :
  ModelElementCollection<ItemType, OpenXmlCollectionType>
  where ItemType : ModelElement
  where OpenXmlCollectionType : DX.OpenXmlCompositeElement
  where OpenXmlItemType : DX.OpenXmlElement
{
  /// <summary>
  /// Initializes a new instance of the collection with default settings.
  /// </summary>
  protected ModelElementCollection()
  {
  }
  /// <summary>
  /// Initializes a new instance of the ModelElementCollection class with the specified parent element.
  /// </summary>
  /// <param name="parent">The parent ModelElement that owns this collection. Cannot be null.</param>
  protected ModelElementCollection(ModelElement parent) : base(parent)
  {
  }
  /// <summary>
  /// Initializes a new instance of the collection from an Open XML composite element.
  /// </summary>
  /// <param name="openXmlCollection">The Open XML composite element to initialize from.</param>
  protected ModelElementCollection(OpenXmlCollectionType? openXmlCollection) : base()
  {
  }
  /// <summary>
  /// Initializes a new instance of the collection from an enumerable of model elements.
  /// </summary>
  /// <param name="itemTypeCollection">The collection of model elements to add.</param>
  protected ModelElementCollection(IEnumerable<ItemType> itemTypeCollection) : base()
  {
    foreach (var item in itemTypeCollection)
    {
      this.Add(item);
    }
  }
  /// <summary>
  /// Loads model elements from the specified Open XML composite element and populates the collection.
  /// </summary>
  /// <param name="openXmlModeledCollection">The Open XML composite element containing child elements to load.</param>
  protected override void LoadDataCollection(OpenXmlCollectionType openXmlModeledCollection)
  {
    this.Clear();
    foreach (var openXmlElement in openXmlModeledCollection!.ChildElements.OfType<OpenXmlItemType>())
    {
      var constructor = typeof(ItemType).GetConstructor([typeof(ModelElement<OpenXmlItemType>), typeof(OpenXmlItemType)]);
      ItemType modelObject;
      if (constructor != null)
      {
        modelObject = (ItemType)constructor.Invoke([this, openXmlElement]);
      }
      else
      {
        modelObject = Activator.CreateInstance<ItemType>();
        modelObject.LoadData(openXmlElement);
      }
      this.Add(modelObject);
    }
  }
  /// <summary>
  /// Updates the Open XML composite element to reflect the current state of the collection.
  /// </summary>
  /// <param name="openXmlModeledCollection">The Open XML composite element to update.</param>
  protected override void UpdateDataCollection(OpenXmlCollectionType openXmlModeledCollection)
  {
    SetUpdatableElement(openXmlModeledCollection);
    var children = openXmlModeledCollection.Elements().Where(item => item is OpenXmlItemType).ToArray();
    foreach (var child in children)
    {
      child.Remove();
    }
    foreach (var item in this)
    {
      OpenXmlItemType openXmlElement = Activator.CreateInstance<OpenXmlItemType>();
      item.UpdateData(openXmlElement);
      openXmlModeledCollection.AppendChild(openXmlElement);
    }
  }
}
