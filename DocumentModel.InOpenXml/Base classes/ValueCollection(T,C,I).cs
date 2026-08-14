namespace DocumentModel;
/// <summary>
/// Represents a collection of values that can be synchronized with an Open XML composite element and its child elements.
/// </summary>
/// <typeparam name = "ItemType">Type of the model element contained in the collection.</typeparam>
/// <typeparam name = "OpenXmlCollectionType">Type of the Open XML composite element representing the collection.</typeparam>
/// <typeparam name = "OpenXmlItemType">Type of the Open XML element representing individual items.</typeparam>
[DataContract]
[XmlRoot("ValueCollection", Namespace = "DocumentModel")]
public abstract class ValueCollection<ItemType, OpenXmlCollectionType, OpenXmlItemType> : 
  ValueCollection<ItemType, OpenXmlCollectionType> 
  where ItemType : notnull 
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
  public ValueCollection()
  {
  }

  /// <summary>
  /// Initializes a new instance of the collection from an Open XML composite element.
  /// </summary>
  /// <param name = "parent">The parent model element.</param>  
  /// <param name = "openXmlElement">The Open XML composite element to initialize from.</param>
  protected ValueCollection(ModelElement parent, OpenXmlCollectionType? openXmlElement) : base(parent, openXmlElement)
  {
  }

  /// <summary>
  /// Initializes a new instance of the collection from an enumerable of model elements.
  /// </summary>
  /// <param name = "itemTypeCollection">The collection of model elements to add.</param>
  protected ValueCollection(IEnumerable<ItemType> itemTypeCollection) : base()
  {
    foreach (var item in itemTypeCollection)
    {
      this.Add(item);
    }
  }

  /// <summary>
  /// Loads model elements from the specified Open XML composite element and populates the collection.
  /// </summary>
  /// <param name = "openXmlModeledCollection">The Open XML composite element containing child elements to load.</param>
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
        modelObject = (ItemType)OpenXmlModelConverter.ConvertFrom(openXmlElement, typeof(ItemType))!;
      }

      this.Add(modelObject);
    }
  }

  /// <summary>
  /// Updates the Open XML composite element to reflect the current state of the collection.
  /// </summary>
  /// <param name = "openXmlModeledCollection">The Open XML composite element to update.</param>
  protected override void UpdateDataCollection(OpenXmlCollectionType openXmlModeledCollection)
  {
    var children = openXmlModeledCollection.Elements().Where(item => item is OpenXmlItemType).ToArray();
    foreach (var child in children)
    {
      child.Remove();
    }

    foreach (var item in this)
    {
      OpenXmlItemType openXmlElement = (OpenXmlItemType)OpenXmlModelConverter.ConvertTo(item, typeof(OpenXmlItemType))!;
      openXmlModeledCollection.AppendChild(openXmlElement);
    }
  }
}