namespace DocumentModel;
/// <summary>
/// Represents a collection of model elements that can be synchronized with an Open XML composite element and its child elements.
/// </summary>
/// <typeparam name = "ItemType">Type of the model element contained in the collection.</typeparam>
/// <typeparam name = "OpenXmlCollectionType">Type of the Open XML composite element representing the collection.</typeparam>
/// <typeparam name = "OpenXmlItemType">Type of the Open XML element representing individual items.</typeparam>
[DataContract]
[XmlRoot("ModelElementCollection", Namespace = "DocumentModel")]
public abstract class ModelElementCollection<ItemType, OpenXmlCollectionType, OpenXmlItemType> :
  ModelElementCollection<ItemType, OpenXmlCollectionType>
  where ItemType : ModelElement
  where OpenXmlCollectionType : DX.OpenXmlCompositeElement
  where OpenXmlItemType : DX.OpenXmlElement
{
  /// <summary>
  /// Initializes a new instance of the collection with default settings.
  /// </summary>
  /// <remarks>
  /// It must be public to fulfill JsonSerialization requirements.
  /// </remarks>
  // ReSharper disable once PublicConstructorInAbstractClass
  public ModelElementCollection()
  {
  }

  /// <summary>
  /// Initializes a new instance of the ModelElementCollection class with the specified parent element.
  /// </summary>
  /// <param name = "parent">The parent ModelElement that owns this collection. Cannot be null.</param>
  /// <param name = "openXmlCollection">The Open XML composite element that represents the collection. Can be null.</param>
  protected ModelElementCollection(ModelElement parent, DX.OpenXmlCompositeElement? openXmlCollection) : base(parent, openXmlCollection)
  {
  }

  /// <summary>
  /// Initializes a new instance of the collection from an enumerable of model elements.
  /// </summary>
  /// <param name = "itemTypeCollection">The collection of model elements to add.</param>
  protected ModelElementCollection(IEnumerable<ItemType> itemTypeCollection) : base()
  {
  }

  /// <summary>
  /// Determines whether the specified Open XML element is of the type that this collection can accept.
  /// </summary>
  /// <param name="item">The OpenXmlElement to check.</param>
  /// <returns>True if the item is accepted; otherwise, false.</returns>
  protected override bool AcceptSourceItem(DX.OpenXmlElement item) => item is OpenXmlItemType;

  /// <summary>
  /// Loads model elements from the specified Open XML composite element and populates the collection.
  /// </summary>
  /// <param name = "openXmlModeledCollection">The Open XML composite element containing child elements to load.</param>
  protected override bool LoadDataCollection(OpenXmlCollectionType openXmlModeledCollection)
  {
    if (IsLoaded)
      return false;
    SetIsLoading(true);
    this.Clear();
    foreach (var openXmlElement in openXmlModeledCollection.Elements<OpenXmlItemType>().Where(AcceptSourceItem))
    {
      var constructor = typeof(ItemType).GetConstructor([typeof(ModelElement<OpenXmlItemType>), typeof(OpenXmlItemType)]);
      ItemType modelObject;
      if (constructor != null)
      {
        Debug.WriteLine($"Invoking constructor with parameters (ModelElement<{typeof(OpenXmlItemType).Name}>, {typeof(OpenXmlItemType).Name}) for type {typeof(ItemType).FullName}.");
        modelObject = (ItemType)constructor.Invoke([this, openXmlElement]);
      }
      else
      {
        //Debug.WriteLine($"Constructor with parameters (ModelElement<{typeof(OpenXmlItemType).Name}>, {typeof(OpenXmlItemType).Typeface}) not found for type {typeof(ItemType).FullName}. Falling back to parameterless constructor and LoadData method.");
        modelObject = Activator.CreateInstance<ItemType>();
        modelObject.LoadData(openXmlElement);
      }

      this.Add(modelObject);
    }
    SetIsLoading(false);
    return true;
  }

  /// <summary>
  /// Updates the Open XML composite element to reflect the current state of the collection.
  /// </summary>
  /// <param name = "openXmlModeledCollection">The Open XML composite element to update.</param>
  protected override bool UpdateDataCollection(OpenXmlCollectionType openXmlModeledCollection)
  {
    SetUpdatableObject(openXmlModeledCollection);
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
    return true;
  }
}