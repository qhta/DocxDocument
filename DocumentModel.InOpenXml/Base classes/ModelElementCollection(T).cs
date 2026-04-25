using DocumentModel;

namespace DocumentModel;
/// <summary>
///   Represents a collection of model elements associated with an OpenXml element, providing synchronization between the document model and OpenXml representation.
///   Supports initialization from an existing collection and advanced collection management for WordprocessingML or other OpenXml-based elements.
/// </summary>
/// <typeparam name = "ItemType">Specifies the type of model elements contained in the collection.</typeparam>
[XmlRoot("ModelElementCollection", Namespace = "DocumentModel")]
[LazyLoad]
public partial class ModelElementCollection<ItemType> : ElementCollection<ItemType>,
  ILazyLoadable
  where ItemType : ModelElement
{

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
  ///   Initializes a new instance of the <see cref = "ModelElementCollection{ItemType}"/> class.
  /// </summary>
  public ModelElementCollection()
  {
  }

  /// <summary>
  ///   Initializes a new instance of the <see cref = "ModelElementCollection{ItemType}"/> class that contains elements copied from the specified collection.
  /// </summary>
  /// <param name = "items">The collection of items to copy into the new collection. Cannot be null.</param>
  public ModelElementCollection(IEnumerable<ItemType> items) : this()
  {
    foreach (var item in items)
    {
      Add(item);
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
  public virtual void TryLazyLoad()
  {
    if (IsLazyLoadEnabled)
    {
      IsLazyLoadEnabled = false;
      if (DataSource is DX.OpenXmlCompositeElement openXmlElement)
      {
        //Debug.WriteLine($"Lazy loading data for {GetType().Name} from OpenXmlCompositeElement: {openXmlElement.LocalName}");
        LoadData(openXmlElement);
        DataSource = null;
      }
    }
  }

}