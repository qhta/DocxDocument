using DocumentModel;

using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace DocumentModel;
/// <summary>
///   Represents a collection of model elements associated with an OpenXml element, which loads separate elements on demand.
/// </summary>
[DataContract]
[XmlRoot("ContentItemsCollection", Namespace = "DocumentModel")]
[LazyLoad]
public abstract partial class ContentItemsCollection<ItemType> : ModelElementCollection<ItemType, DX.OpenXmlCompositeElement>
  where ItemType : ModelElement
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
  /// Gets the target model item type corresponding to the specified OpenXml element type, based on the defined mapping between OpenXml element types and model element types.
  /// </summary>
  /// <param name="openXmlElement">The OpenXml element to get the target model item type for.</param>
  /// <returns>The target model item type.</returns>
  protected override Type GetTargetModelItemType(DX.OpenXmlElement openXmlElement) => OpenXmlElement2ModelTypeMapping[openXmlElement.GetType()];

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
      ItemType modelObject;
      if (constructor != null)
      {
        Debug.WriteLine($"Invoking constructor with parameters for type {modelItemType.FullName}.");
        modelObject = (ItemType)constructor.Invoke([this, openXmlElement]);
      }
      else
      {
        //Debug.WriteLine($"Constructor with parameters (ModelElement<{typeof(OpenXmlItemType).Name}>, {typeof(OpenXmlItemType).Typeface}) not found for type {typeof(ItemType).FullName}. Falling back to parameterless constructor and LoadData method.");
        modelObject = (ItemType)Activator.CreateInstance(modelItemType)!;
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
  protected override void UpdateDataCollection(DX.OpenXmlCompositeElement openXmlModeledCollection)
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
  }

}