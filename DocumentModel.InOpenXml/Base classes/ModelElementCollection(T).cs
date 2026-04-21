using DocumentModel;

namespace DocumentModel;
/// <summary>
///   Represents a collection of model elements associated with an OpenXml element, providing synchronization between the document model and OpenXml representation.
///   Supports initialization from an existing collection and advanced collection management for WordprocessingML or other OpenXml-based elements.
/// </summary>
/// <typeparam name = "ItemType">Specifies the type of model elements contained in the collection.</typeparam>
[XmlRoot("ModelElementCollection", Namespace = "DocumentModel")]
public abstract partial class ModelElementCollection<ItemType> : ElementCollection<ItemType>,
  ILazyLoadable
  where ItemType : ModelElement
{
  //private bool _IsLazyLoad;

  /// <summary>
  ///   Initializes a new instance of the <see cref = "ModelElementCollection{ItemType}"/> class.
  /// </summary>
  protected ModelElementCollection()
  {
  }

  /// <summary>
  ///   Initializes a new instance of the <see cref = "ModelElementCollection{ItemType}"/> class that contains elements copied from the specified collection.
  /// </summary>
  /// <param name = "items">The collection of items to copy into the new collection. Cannot be null.</param>
  protected ModelElementCollection(IEnumerable<ItemType> items) : this()
  {
    foreach (var item in items)
    {
      Add(item);
    }
  }

  /// <summary>
  /// Initializes a new instance of the ModelElementCollection class with the specified parent element.
  /// </summary>
  /// <param name = "parent">The parent ModelElement that owns this collection. Cannot be null.</param>
  protected ModelElementCollection(ModelElement parent) : base(parent)
  {
    TryLazyLoad();
  }

  /// <summary>
  /// Enables or disables lazy loading for the collection. 
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public bool IsLazyLoadEnabled { get; set; }

  /// <summary>
  /// Data source for lazy loading. 
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public object? DataSource { get; set; }


  /// <summary>
  /// If LazyLoad is enabled, this method loads the related data from the data source and disables lazy loading.
  /// </summary>
  public void TryLazyLoad()
  {
    if (IsLazyLoadEnabled)
    {
      if (DataSource is DX.OpenXmlCompositeElement openXmlElement)
      {
        Debug.WriteLine($"Lazy loading data for {GetType().Name} from OpenXmlCompositeElement: {openXmlElement.LocalName}");
        LoadData(openXmlElement);
      }
      IsLazyLoadEnabled = false;
    }
  }

  public override int Count
  {
    get
    {
      TryLazyLoad();
      return base.Count;
    }
  }
}