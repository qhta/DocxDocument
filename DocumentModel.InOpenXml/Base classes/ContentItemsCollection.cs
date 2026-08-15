using System.Reflection.Metadata.Ecma335;

using DocumentModel;

using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace DocumentModel;
/// <summary>
///   Represents a collection of model elements associated with an OpenXml element, which loads separate elements on demand.
/// </summary>
[DataContract]
[XmlRoot("ContentItemsCollection", Namespace = "DocumentModel")]
[LazyLoad]
public abstract partial class ContentItemsCollection : ModelElementCollection<ModelElement, DX.OpenXmlCompositeElement>
{

  /// <summary>
  /// Default constructor needed for XML serialization. Initializes a new instance of the StoryItemsCollection class.
  /// </summary>
  protected ContentItemsCollection()
  {
    IsLazyLoadEnabled = true;
  }

  /// <summary>
  /// Initializes a new instance of the ContentItemsCollection class with the specified parent model element and Open
  /// XML composite element.
  /// </summary>
  /// <param name="parent">The parent ModelElement that owns this collection. Cannot be null.</param>
  /// <param name="dataSource">The underlying OpenXmlCompositeElement that provides the XML structure for the collection. Can be null.</param>
  protected ContentItemsCollection(ModelElement parent, DX.OpenXmlCompositeElement? dataSource) :
    base(parent)
  {
    IsLazyLoadEnabled = true;
    DataSource = dataSource;
  }


  /// <summary>
  /// 
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  protected abstract Dictionary<Type, Type> OpenXmlElement2ModelTypeMapping { get; }

  /// <summary>
  /// Gets the mapping between model element types and their corresponding OpenXml element types.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  protected abstract Dictionary<Type, Type[]> ModelType2OpenXmlElementsMapping { get; }

  /// <summary>
  /// Checks if the specified item is acceptable for this collection.
  /// </summary>
  /// <param name="item">The item to check.</param>
  /// <returns>True if the item is acceptable; otherwise, false.</returns>
  protected override bool AcceptSourceItem(DX.OpenXmlElement item)
  {
    return OpenXmlElement2ModelTypeMapping.ContainsKey(item.GetType());
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
      if (!ModelType2OpenXmlElementsMapping.TryGetValue(modelType, out var openXmlTypes))
        throw new InvalidOperationException($"No OpenXml element type mapping found for model element type {modelType}");

      foreach (var openXmlChildElement in openXmlElement.Elements())
      {
        if (!AcceptSourceItem(openXmlChildElement))
          continue;
        if (OpenXmlElement2ModelTypeMapping.TryGetValue(openXmlChildElement.GetType(), out var modelItemType) == false)
          throw new InvalidOperationException($"No model element type mapping found for OpenXml element type {openXmlChildElement.GetType()}");

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
  protected override Type GetTargetModelItemType(DX.OpenXmlElement openXmlElement) => OpenXmlElement2ModelTypeMapping[openXmlElement.GetType()];

  /// <summary>
  /// Creates a model element of the specified type from the given OpenXml child element, ensuring that the converted item is compatible with the expected model type.
  /// The method sets the parent of the created model element and, if applicable, associates it with the corresponding OpenXml element for updatable items.
  /// </summary>
  /// <typeparam name="ItemType">The type of the model element to create.</typeparam>
  /// <param name="openXmlChildElement">The OpenXml child element to convert.</param>
  /// <param name="modelItemType">The expected model item type.</param>
  /// <returns>The created model element of the specified type.</returns>
  /// <exception cref="InvalidOperationException"></exception>
  private ItemType CreateModelElement<ItemType>(DX.OpenXmlElement openXmlChildElement, Type modelItemType)
  {
    var modelItem = OpenXmlModelConverter.ConvertFrom(openXmlChildElement, modelItemType);
    if (modelItem is not ModelElement modelElement)
      throw new InvalidOperationException($"Converted item is not a model element");

    if (modelItem != null && !modelItemType.IsInstanceOfType(modelItem))
      throw new InvalidOperationException($"Converted model item is not compatible to {modelItemType}");

    modelElement.Parent = this.Parent;
    if (modelItem is IUpdatable updatableModelItem)
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
      if (!OpenXmlElement2ModelTypeMapping.TryGetValue(openXmlItemType, out var modelItemType))
        throw new InvalidOperationException($"No model element type mapping found for OpenXml element type {openXmlItemType}");
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
        (modelObject as ILoadable)?.LoadData(openXmlElement);
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
  /// <param name = "openXmlModeledCollection">The Open XML composite element to update.</param>
  protected override bool UpdateDataCollection(DX.OpenXmlCompositeElement openXmlModeledCollection)
  {
    SetUpdatableObject(openXmlModeledCollection);

    foreach (var modelItem in this)
    {
      var modelItemType = modelItem.GetType();
      if (!ModelType2OpenXmlElementsMapping.TryGetValue(modelItemType, out var openXmlItemTypes))
        throw new InvalidOperationException($"No OpenXml element type mapping found for model element type {modelItemType}");

      var openXmlItemType = openXmlItemTypes.First();
      var children = openXmlModeledCollection.Elements().Where(item => item.GetType().IsEqualOrSubclassOf(openXmlItemType)).ToArray();
      foreach (var child in children)
      {
        child.Remove();
      }
      
      DX.OpenXmlElement openXmlElement = (DX.OpenXmlElement)Activator.CreateInstance(openXmlItemType)!;
      modelItem.UpdateData(openXmlElement);
      openXmlModeledCollection.AddChildElement(openXmlElement);
    }
    return true;
  }
  
}