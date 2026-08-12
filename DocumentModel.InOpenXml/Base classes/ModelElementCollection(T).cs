using System.Runtime.CompilerServices;

using DocumentModel;

namespace DocumentModel;
/// <summary>
///   Represents a collection of model elements associated with an OpenXml element, providing synchronization between the document model and OpenXml representation.
///   Supports initialization from an existing collection and advanced collection management for WordprocessingML or other OpenXml-based elements.
/// </summary>
/// <typeparam name = "ItemType">Specifies the type of model elements contained in the collection.</typeparam>
[DataContract]
[XmlRoot("ModelElementCollection", Namespace = "DocumentModel")]
[LazyLoad]
public partial class ModelElementCollection<ItemType> : ElementCollection<ItemType>, IDirectAccessElement
  where ItemType : ModelElement
{

  /// <summary>
  ///   Initializes a new instance of the <see cref = "ModelElementCollection{ItemType}"/> class.
  /// </summary>
  public ModelElementCollection()
  {
  }

  /// <summary>
  /// Initializes a new instance of the ModelElementCollection class using the specified OpenXmlCompositeElement as the
  /// underlying XML element.
  /// </summary>
  /// <param name="openXmlElement">The OpenXmlCompositeElement that provides the XML content for the collection. Cannot be null.</param>
  protected ModelElementCollection(DX.OpenXmlCompositeElement openXmlElement) : base()
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
    DataSource = items;
    IsLazyLoadEnabled = true;
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
      if (IsLazyLoadEnabled)
      {
        var sourceCollection = SourceCollection;
        if (sourceCollection is null)
          throw new ApplicationException("Can't check collection count because the source collection is null.");

        return sourceCollection.Count(AcceptSourceItem);
      }
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
    if (IsLazyLoadEnabled)
    {
      var sourceCollection = SourceCollection;
      if (sourceCollection is null)
        throw new ApplicationException("Can't check if collection is empty because the source collection is null.");

      return !sourceCollection.Where(AcceptSourceItem).Any();
    }
    return !Items.Any();
  }


  /// <summary>
  /// Returns or assigns the item at the specified index.
  /// </summary>
  /// <param name = "index">The zero-based index.</param>
  public override ItemType this[int index]
  {
    get
    {
      if (HasDirectAccess)
        throw new ApplicationException("Cannot access item by integer index when HasDirectAccess is true.");
      if (IsLazyLoadEnabled)
        TryLazyLoad(index);
      return Items[index];
    }
    set
    {
      if (HasDirectAccess)
        throw new ApplicationException("Cannot access item by integer index when HasDirectAccess is true.");
      if (IsLazyLoadEnabled)
        TryLazyLoad(index);
      Items[index] = value;
    }
  }

  /// <summary>
  /// Returns an enumerator that iterates through the collection.
  /// </summary>
  public override IEnumerator<ItemType> GetEnumerator()
  {
    if (HasDirectAccess)
      return EnumerateDirectly().GetEnumerator();

    if (IsLazyLoadEnabled)
      return EnumerateLazy().GetEnumerator();

    return base.GetEnumerator();
  }

  /// <summary>
  /// Enumerates the items in the collection, returning them directly after converting from the source collection.
  /// </summary>
  private IEnumerable<ItemType> EnumerateDirectly()
  {
    OpenXmlModelConverter.Init();

    // yield already-loaded items first
    foreach (var existing in base.Items)
      yield return existing;

    var sourceCollection = SourceCollection
                           ?? throw new ApplicationException("Can't enumerate data directly because the source collection is null.");

    int alreadyLoaded = base.Items.Count;

    foreach (var openXmlItem in sourceCollection.Skip(alreadyLoaded))
    {
      if (!AcceptSourceItem(openXmlItem))
        continue;
      var modelItem = OpenXmlElementConverter.ConvertFrom(openXmlItem, typeof(ItemType));
      if (modelItem is not ItemType item)
        throw new ApplicationException($"Failed to convert OpenXmlElement {openXmlItem} to {typeof(ItemType).Name}");

      yield return item;
    }

    IsLazyLoadEnabled = false;
  }


  /// <summary>
  /// Enumerates the items in the collection, loading them lazily from the source collection if lazy loading is enabled.
  /// </summary>
  private IEnumerable<ItemType> EnumerateLazy()
  {
    OpenXmlModelConverter.Init();

    // yield already-loaded items first
    foreach (var existing in base.Items)
      yield return existing;

    var sourceCollection = SourceCollection
                           ?? throw new ApplicationException("Can't lazy load data because the source collection is null.");

    int alreadyLoaded = base.Items.Count;

    foreach (var openXmlItem in sourceCollection.Skip(alreadyLoaded))
    {
      if (!AcceptSourceItem(openXmlItem))
        continue;
      var modelItem = OpenXmlElementConverter.ConvertFrom(openXmlItem, typeof(ItemType));
      if (modelItem is not ItemType item)
        throw new ApplicationException($"Failed to convert OpenXmlElement {openXmlItem} to {typeof(ItemType).Name}");

      Add(item);
      yield return item;
    }

    IsLazyLoadEnabled = false;
  }

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
  /// Source collection for lazy loading.
  /// If the DataSource is an OpenXmlCompositeElement, this property returns its child elements;
  /// otherwise, it returns DataSource as IEnumerable&lt;DX.OpenXmlElement&gt;.
  /// Setting this property updates the DataSource.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public virtual IEnumerable<DX.OpenXmlElement>? SourceCollection
  {
    get => DataSource is DX.OpenXmlCompositeElement openXmlElement ? openXmlElement.Elements() : 
      DataSource as IEnumerable<DX.OpenXmlElement>;
    set => DataSource = value;
  }

  /// <summary>
  /// If LazyLoad is enabled, this method loads the related data from the data source and disables lazy loading.
  /// </summary>
  public virtual bool TryLazyLoad()
  {
    if (IsLazyLoadEnabled)
      return TryLazyLoad(int.MaxValue);
    return IsLazyLoadEnabled;
  }

  /// <summary>
  /// If LazyLoad is enabled, this method loads the related data from the data source until the specified index.
  /// <para>
  /// If index is greater than the number of items in the source collection, it loads all items and disables lazy loading.
  /// </para>
  /// </summary>
  public virtual bool TryLazyLoad(int index)
  {
    if (IsLazyLoadEnabled)
    {
      OpenXmlModelConverter.Init();
      var sourceCollection = SourceCollection;
      if (sourceCollection is null)
        throw new ApplicationException("Can't lazy load data because the source collection is null.");
      Debug.WriteLine($"Lazy loading data for {GetType().Name}");
      int loadedIndex = 0;
      foreach (var openXmlItem in sourceCollection)
      {
        if (!AcceptSourceItem(openXmlItem))
          continue;
        if (loadedIndex > index)
          break;
        if (loadedIndex > Count)
        {
          var modelItem = OpenXmlElementConverter.ConvertFrom(openXmlItem, typeof(ItemType));
          if (modelItem is ItemType item)
          {
            Add(item);
            loadedIndex++;
          }
          else
          {
            throw new ApplicationException($"Failed to convert OpenXmlElement {openXmlItem} to {typeof(ItemType).Name}");
          }
        }
      }
      IsLazyLoadEnabled = loadedIndex < Count;
    }
    return !IsLazyLoadEnabled;
  }

  /// <summary>
  /// Checks if the specified OpenXmlElement should be accepted as a valid source item for this collection.
  /// </summary>
  /// <param name="item">The OpenXmlElement to check.</param>
  /// <returns>True if the item is accepted; otherwise, false.</returns>
  protected virtual bool AcceptSourceItem(DX.OpenXmlElement item) => true;
}