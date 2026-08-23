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
    SetDataSource(dataSource);
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
  /// Gets the target model item type corresponding to the specified OpenXml element type, based on the defined mapping between OpenXml element types and model element types.
  /// </summary>
  /// <param name="openXmlElement">The OpenXml element to get the target model item type for.</param>
  /// <returns>The target model item type.</returns>
  public override Type GetTargetModelItemType(DX.OpenXmlElement openXmlElement) => OpenXmlElementMapper.GetModelElementType(openXmlElement.GetType());

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
      ItemType modelObject;
      if (constructor != null)
      {
        //Debug.WriteLine($"Invoking constructor with parameters for type {modelItemType.FullName}.");
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
  /// <param name = "openXmlCompositeElement">The Open XML composite element to update.</param>
  protected override bool UpdateDataCollection(DX.OpenXmlCompositeElement openXmlCompositeElement)
  {
    SetUpdatableObject(openXmlCompositeElement, null);

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

}