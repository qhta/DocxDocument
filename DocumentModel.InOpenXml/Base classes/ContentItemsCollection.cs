namespace DocumentModel;
/// <summary>
///   Represents a collection of model elements associated with an OpenXml element, which loads separate elements on demand.
/// </summary>
[DataContract]
[XmlRoot("ContentItemsCollection", Namespace = "DocumentModel")]
[DirectAccess]
public abstract partial class ContentItemsCollection : ModelElementCollection<ModelElement, DX.OpenXmlCompositeElement>
{

  /// <summary>
  /// Default constructor needed for XML serialization. Initializes a new instance of the ContentItemsCollection class.
  /// </summary>
  protected ContentItemsCollection()
  {
  }

  /// <summary>
  /// Initializes a new instance of the ContentItemsCollection class with the specified parent model element and Open
  /// XML composite element.
  /// </summary>
  /// <param name="parent">The parent ModelElement that owns this collection. Cannot be null.</param>
  /// <param name="dataSource">The underlying OpenXmlCompositeElement that provides the XML structure for the collection. Can be null.</param>
  protected ContentItemsCollection(ModelElement parent, DX.OpenXmlCompositeElement? dataSource) :
    base(parent, dataSource)
  {
  }


  /// <summary>
  /// Checks if the specified item is acceptable for this collection.
  /// </summary>
  /// <param name="item">The item to check.</param>
  /// <returns>True if the item is acceptable; otherwise, false.</returns>
  public override bool AcceptSourceItem(DX.OpenXmlElement item)
  {
    try
    {
      OpenXmlElementMapper.GetModelElementType(item.GetType());
      return true;
    }
    catch (ApplicationException)
    {
      return false;
    }
  }

  /// <summary>
  /// Gets an enumerator that iterates through the collection, yielding each item in the collection.
  /// The enumerator retrieves items from the underlying OpenXml composite element, converting them to the appropriate model type based on the defined type mapping. Only items accepted by the AcceptItem method are included in the enumeration.
  /// </summary>
  /// <returns></returns>
  /// <exception cref="InvalidOperationException"></exception>
  public IEnumerator<ItemType> GetTypedEnumerator<ItemType>()
  where ItemType : ModelElement
  {
    var modelType = typeof(ItemType);
    if (DataSource is DX.OpenXmlCompositeElement openXmlElement)
    {
      var openXmlTypes = OpenXmlElementMapper.GetOpenXmlElementTypes(modelType);

      foreach (var openXmlChildElement in GetSourceElements())
      {
        if (!AcceptSourceItem(openXmlChildElement))
          continue;
        var modelItemType = OpenXmlElementMapper.GetModelElementType(openXmlChildElement.GetType());

        if (modelItemType == typeof(ItemType))
        {
          var modelItem = CreateModelElement<ItemType>(openXmlChildElement, modelItemType);
          yield return modelItem;
        }
      }
    }
  }


  /// <summary>
  /// Gets the target model item type corresponding to the specified OpenXml element type, based on the defined mapping between OpenXml element types and model element types.
  /// </summary>
  /// <param name="openXmlElement">The OpenXml element to get the target model item type for.</param>
  /// <returns>The target model item type.</returns>
  public override Type GetTargetModelItemType(DX.OpenXmlElement openXmlElement) => OpenXmlElementMapper.GetModelElementType(openXmlElement.GetType());

  /// <summary>
  /// Creates a model element of the specified type from the given OpenXml child element, ensuring that the converted item is compatible with the expected model type.
  /// The method sets the parent of the created model element and, if applicable, associates it with the corresponding OpenXml element for updatable items.
  /// </summary>
  /// <typeparam name="ItemType">The type of the model element to create.</typeparam>
  /// <param name="openXmlChildElement">The OpenXml child element to convert.</param>
  /// <param name="modelItemType">The expected model item type.</param>
  /// <returns>The created model element of the specified type.</returns>
  /// <exception cref="InvalidOperationException"></exception>
  protected virtual ItemType CreateModelElement<ItemType>(DX.OpenXmlElement openXmlChildElement, Type modelItemType)
  {
    var modelItem = OpenXmlModelConverter.ConvertFrom(openXmlChildElement, modelItemType);
    if (modelItem is not ModelElement modelElement)
      throw new InvalidOperationException($"Converted item is not a model element");

    if (modelItem != null && !modelItemType.IsInstanceOfType(modelItem))
      throw new InvalidOperationException($"Converted model item is not compatible to {modelItemType}");

    modelElement.SetParent(Parent);
    if (modelItem is IUpdatableElement updatableModelItem)
      updatableModelItem.SetUpdatableObject(openXmlChildElement);

    return (ItemType)modelItem!;
  }


  /// <summary>
  /// Loads model elements from the specified Open XML composite element and populates the collection.
  /// </summary>
  /// <param name = "openXmlModeledCollection">The Open XML composite element containing child elements to load.</param>
  protected override bool LoadDataCollection(DX.OpenXmlCompositeElement openXmlModeledCollection)
  {
    if (IsLoaded)
      return false;
    SetIsLoading(true);
    this.Clear();
    foreach (var openXmlElement in openXmlModeledCollection.Elements().Where(AcceptSourceItem))
    {
      var openXmlItemType = openXmlElement.GetType();
      var modelItemType = OpenXmlElementMapper.GetModelElementType(openXmlItemType);
      var constructor = modelItemType.GetConstructor([modelItemType, openXmlItemType]);
      ModelElement modelObject;
      if (constructor != null)
      {
        Debug.WriteLine($"Invoking constructor with parameters for type {modelItemType.FullName}.");
        modelObject = (ModelElement)constructor.Invoke([this, openXmlElement]);
      }
      else
      {
        //Debug.WriteLine($"Constructor with parameters (ModelElement<{typeof(OpenXmlItemType).Name}>, {typeof(OpenXmlItemType).Typeface}) not found for type {typeof(ItemType).FullName}. Falling back to parameterless constructor and LoadData method.");
        modelObject = (ModelElement)Activator.CreateInstance(modelItemType)!;
        (modelObject as ILoadable)?.TryLoadData(openXmlElement);
      }

      this.Add(modelObject);
    }
    SetIsLoading(false);
    SetIsLoaded(true);
    return true;
  }

  /// <summary>
  /// Updates the Open XML composite element to reflect the current state of the collection.
  /// </summary>
  /// <param name = "openXmlCompositeElement">The Open XML composite element to update.</param>
  protected override bool UpdateDataCollection(DX.OpenXmlCompositeElement openXmlCompositeElement)
  {
    SetUpdatableObject(openXmlCompositeElement);

    foreach (var modelItem in this)
    {
      var modelItemType = modelItem.GetType();
      var openXmlItemTypes = OpenXmlElementMapper.GetOpenXmlElementTypes(modelItemType);

      var openXmlItemType = openXmlItemTypes.First();
      var children = openXmlCompositeElement.Elements().Where(item => item.GetType().IsEqualOrSubclassOf(openXmlItemType)).ToArray();
      foreach (var child in children)
      {
        child.Remove();
      }
      
      DX.OpenXmlElement openXmlElement = (DX.OpenXmlElement)Activator.CreateInstance(openXmlItemType)!;
      modelItem.UpdateData(openXmlElement);
      openXmlCompositeElement.AddChildElement(openXmlElement);
    }
    return true;
  }

  /// <summary>
  /// Overrides the Add method to prevent adding items directly to the collection. Instead, use the AddModelElement method to add model elements to the collection.
  /// </summary>
  /// <param name="modelItem"></param>
  public override void Add(ModelElement modelItem)
  {
    return; // Disable adding items directly to the collection. Use AddModelElement instead.
  }

  /// <summary>
  /// Adds a model Item to the collection.
  /// </summary>
  /// <param name = "modelItem">The modelItem to add.</param>
  public void AddModelElement(ModelElement modelItem)
  {
    if (modelItem is DMW.BookmarkStart)
      Debug.Assert(true);
    var updatableElement = GetUpdatableObject();
    if (updatableElement is not DX.OpenXmlCompositeElement openXmlCompositeElement)
      throw new ApplicationException("Updatable element of content modelItem collection must be a OpenXmlCompositeElement");

    var openXmlElement = (modelItem as IUpdatableElement).GetUpdatableObject() as DX.OpenXmlElement;
    if (openXmlElement is null)
    {
      openXmlElement = modelItem.GetUpdatableElement() as DX.OpenXmlElement;
      if (openXmlElement is null)
        throw new ApplicationException("Updatable element of modelItem must be a OpenXmlElement");
      Debug.WriteLine($"Created {openXmlElement.GetType().FullName} for modelItem of type {modelItem.GetType().FullName}");
    }
    if (openXmlElement is not DXW.TextType)
      modelItem.UpdateData(openXmlElement);
    openXmlCompositeElement.AddChildElement(openXmlElement);

  }
}