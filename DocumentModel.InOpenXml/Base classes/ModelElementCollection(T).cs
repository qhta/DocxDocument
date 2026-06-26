using DocumentModel;

namespace DocumentModel;
/// <summary>
///   Represents a collection of model elements associated with an OpenXml element, providing synchronization between the document model and OpenXml representation.
///   Supports initialization from an existing collection and advanced collection management for WordprocessingML or other OpenXml-based elements.
/// </summary>
/// <typeparam name = "ItemType">Specifies the type of model elements contained in the collection.</typeparam>
[XmlRoot("ModelElementCollection", Namespace = "DocumentModel")]
[LazyLoad]
public abstract partial class ModelElementCollection<ItemType> : ElementCollection<ItemType>, IDirectAccessElement
  where ItemType : ModelElement
{

  /// <summary>
  ///   Initializes a new instance of the <see cref = "ModelElementCollection{ItemType}"/> class.
  /// </summary>
  protected ModelElementCollection()
  {
  }

  /// <summary>
  /// Initializes a new instance of the ModelElementCollection class using the specified OpenXmlCompositeElement as the
  /// underlying XML element.
  /// </summary>
  /// <param name="openXmlElement">The OpenXmlCompositeElement that provides the XML content for the collection. Cannot be null.</param>
  protected ModelElementCollection(DX.OpenXmlCompositeElement openXmlElement): base()
  {
    DataSource = openXmlElement;
    HasDirectAccess = true;

  }

  /// <summary>
  /// Initializes a new instance of the ModelElementCollection class with the specified parent element and OpenXml
  /// composite element as the data source.
  /// </summary>
  /// <param name="parent">The parent ModelElement that will own this collection. Cannot be null.</param>
  /// <param name="openXmlElement">The OpenXmlCompositeElement that serves as the data source for the collection. Can be null.</param>
  protected ModelElementCollection(ModelElement parent, DX.OpenXmlElement? openXmlElement) : base(parent)
  {
    DataSource = openXmlElement;
    HasDirectAccess = openXmlElement != null;
    IsLazyLoadEnabled = this.GetType().GetCustomAttribute<LazyLoadAttribute>()?.IsEnabled == true &&
                        this is ILazyLoadable;
  }

  /// <summary>
  /// Specifies whether the collection has direct access to its underlying OpenXmlCompositeElement, indicating that it can manipulate the XML content directly without lazy loading. This property is set to true when the collection is initialized with an OpenXmlCompositeElement and false otherwise.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  public bool HasDirectAccess { get; private set; }

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
  /// Overriden accessor for the Items collection that ensures lazy loading is attempted before returning the collection.
  /// </summary>
  protected override ObservableCollection<ItemType> Items
  {
    get
    {
      TryLazyLoad();
      return base.Items;
    }
  }


  /// <summary>
  /// Returns the number of items in the collection.
  /// </summary>
  public override int Count
  {
    get
    {
      //if (IsLazyLoadEnabled)
      //  if (DataSource is DX.OpenXmlCompositeElement openXmlElement)
      //    return openXmlElement.Elements().Count();
      return Items.Count;
    }
  }

  /// <summary>
  /// Checks if the collection is empty.
  /// A collection is considered empty if all its properties are null or empty
  /// (as determined by the base implementation of IsEmpty())
  /// and it contains no items or if all items in the collection are themselves empty
  /// (i.e., they implement IEmptyCheckable and return true for IsEmpty()).
  /// </summary>
  /// <returns></returns>
  public override bool IsEmpty()
  {
    //if (IsLazyLoadEnabled)
    //  if (DataSource is DX.OpenXmlCompositeElement openXmlElement)
    //    return !openXmlElement.Elements().Any();
    return !Items.Any();
  }


  /// <summary>
  /// Returns or assigns the item at the specified index.
  /// </summary>
  /// <param name = "index">The zero-based index.</param>
  public override ItemType this[int index] { get => Items[index]; set => Items[index] = value; }

  /// <summary>
  /// Enables or disables lazy loading for the collection. 
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public bool IsLazyLoadEnabled { [DebuggerStepThrough] get; set; }

  /// <summary>
  /// Data source for lazy loading. 
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public object? DataSource { [DebuggerStepThrough] get; set; }


  /// <summary>
  /// If LazyLoad is enabled, this method loads the related data from the data source and disables lazy loading.
  /// </summary>
  public virtual void TryLazyLoad()
  {
    if (IsLazyLoadEnabled)
    {
      IsLazyLoadEnabled = false;
      OpenXmlModelConverter.Init();
      if (DataSource is DX.OpenXmlCompositeElement openXmlElement)
      {
        //Debug.WriteLine($"Lazy loading data for {GetType().Name} from OpenXmlCompositeElement: {openXmlElement.LocalName}");
        LoadData(openXmlElement);
        DataSource = null;
      }
    }
  }

}