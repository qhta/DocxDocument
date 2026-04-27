using DocumentModel;

using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace DocumentModel;
/// <summary>
///   Represents a collection of model elements associated with an OpenXml element, which loads separate elements on demand.
/// </summary>
[XmlRoot("ContentItemsCollection", Namespace = "DocumentModel")]
[LazyLoad]
public abstract partial class ContentItemsCollection<ItemType> : ModelElementCollection<ItemType>,
  ILazyLoadable,
  IFilteringCollection
  where ItemType : ModelElement
{
  /// <summary>
  /// Default constructor for the ContentItemsCollection class, initializing a new instance of the ContentItemsCollection class.
  /// </summary>
  protected ContentItemsCollection() : base()
  {
  }

  /// <summary>
  /// Initializes a new instance of the ContentItemsCollection class with the specified parent element. 
  /// </summary>
  /// <param name="parent">The parent ModelElement that owns this collection. Cannot be null.</param>
  protected ContentItemsCollection(ModelElement parent) : base(parent)
  {
  }

  /// <summary>
  /// Initializes a new instance of the ContentItemsCollection class with the specified OpenXmlCompositeElement.
  /// </summary>
  /// <param name="openXmlElement">The OpenXmlCompositeElement to be wrapped by the collection. Cannot be null.</param>
  protected ContentItemsCollection(DX.OpenXmlCompositeElement openXmlElement) : base(openXmlElement)
  {

  }

  /// <summary>
  /// Initializes a new instance of the ContentItemsCollection class with the specified parent model element and Open
  /// XML composite element.
  /// </summary>
  /// <param name="parent">The parent ModelElement that owns this collection. Cannot be null.</param>
  /// <param name="openXmlElement">The underlying OpenXmlCompositeElement that provides the XML structure for the collection. Cannot be null.</param>
  protected ContentItemsCollection(ModelElement parent, DX.OpenXmlCompositeElement openXmlElement) : base(parent, openXmlElement)
  {
  }

  /// <summary>
  /// Adds an item to the collection.
  /// </summary>
  /// <param name = "item">The item to add.</param>
  public new void Add(ItemType item)
  {
    while (!IsSynchronized)
      Task.Delay(1).Wait();
    Items.Add(item);
  }

  /// <summary>
  /// Removes all items from the collection.
  /// </summary>
  public override void Clear()
  {
    while (!IsSynchronized)
      Task.Delay(1).Wait();
    Items.Clear();
  }

  /// <summary>
  /// Determines whether the collection contains a specific item.
  /// </summary>
  /// <param name = "item">The item to locate.</param>
  /// <returns>True if found; otherwise, false.</returns>
  public override bool Contains(ItemType item)
  {
    while (!IsSynchronized)
      Task.Delay(1).Wait();
    return Items.Contains(item);
  }

  /// <summary>
  /// Copies the elements of the collection to an array, starting at a particular array index.
  /// </summary>
  /// <param name = "array">The destination array.</param>
  /// <param name = "arrayIndex">The zero-based index at which copying begins.</param>
  public override void CopyTo(ItemType[] array, int arrayIndex)
  {
    while (!IsSynchronized)
      Task.Delay(1).Wait();
    Items.CopyTo(array, arrayIndex);
  }

  /// <summary>
  /// Removes the first occurrence of a specific item from the collection.
  /// </summary>
  /// <param name = "item">The item to remove.</param>
  /// <returns>True if removed; otherwise, false.</returns>
  public override bool Remove(ItemType item)
  {
    while (!IsSynchronized)
      Task.Delay(1).Wait();
    return Items.Remove(item);
  }

  /// <summary>
  /// Inserts an item at the specified index.
  /// </summary>
  /// <param name = "index">The zero-based index at which to insert.</param>
  /// <param name = "item">The item to insert.</param>
  public override void Insert(int index, ItemType item)
  {
    while (!IsSynchronized)
      Task.Delay(1).Wait();
    Items.Insert(index, item);
  }

  /// <summary>
  /// Removes the item at the specified index.
  /// </summary>
  /// <param name = "index">The zero-based index of the item to remove.</param>
  public override void RemoveAt(int index)
  {
    while (!IsSynchronized)
      Task.Delay(1).Wait();
    Items.RemoveAt(index);
  }

  /// <summary>
  /// Copies the elements of the collection to a specified one-dimensional array, starting at the given index in the
  /// target array.
  /// </summary>
  /// <param name = "array">The one-dimensional array that is the destination of the elements copied from the collection. The array must have
  /// zero-based indexing and sufficient space to accommodate the copied elements.</param>
  /// <param name = "index">The zero-based index in the destination array at which copying begins.</param>
  public override void CopyTo(Array array, int index)
  {
    while (!IsSynchronized)
      Task.Delay(1).Wait();
    ((ICollection)Items).CopyTo(array, index);
  }

  /// <summary>
  /// Gets a value indicating whether access to the collection is synchronized (thread-safe).
  /// </summary>
  /// <remarks>If this property returns <see langword="true"/>, access to the collection is thread-safe and can
  /// be shared among multiple threads without additional synchronization. If <see langword="false"/>, callers must
  /// implement their own synchronization to ensure thread safety when accessing the collection concurrently.</remarks>
  public new bool IsSynchronized { get; set; }

  /// <summary>
  /// Gets an object that can be used to synchronize access to the collection.
  /// </summary>
  /// <remarks>Use the returned object with a lock statement to ensure thread safety when accessing the
  /// collection from multiple threads. Synchronizing access using this object helps prevent race conditions and data
  /// corruption in multithreaded scenarios.</remarks>
  public new object SyncRoot => Items;

  /// <summary>
  /// Returns the number of items in the collection.
  /// </summary>
  public override int Count
  {
    get
    {
      if (DataSource is DX.OpenXmlCompositeElement openXmlElement)
      {
        if (HasDirectAccess)
        {
          return openXmlElement.ChildElements.Count(AcceptItem);
        }
        while (!IsSynchronized)
          Task.Delay(1).Wait();
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
    if (DataSource is DX.OpenXmlCompositeElement openXmlElement)
    {
      if (HasDirectAccess)
        return !openXmlElement.ChildElements.Any(AcceptItem);
      while (!IsSynchronized)
        Task.Delay(1).Wait();
    }
    return base.IsEmpty();
  }

  /// <summary>
  /// If LazyLoad is enabled, this method loads the related data from the data source and disables lazy loading.
  /// </summary>
  public override void TryLazyLoad()
  {
    if (HasDirectAccess)
      return;
    if (IsLazyLoadEnabled)
    {
      IsLazyLoadEnabled = false;
      if (DataSource is DX.OpenXmlCompositeElement openXmlElement)
      {
        //Debug.WriteLine($"Lazy loading data for {GetType().Name} from OpenXmlCompositeElement: {openXmlElement.LocalName}");
        LoadData(openXmlElement);
        Task.Run(() =>
        {
          //Debug.WriteLine($"Loading collection children for {GetType().Name} from OpenXmlCompositeElement: {openXmlElement.LocalName}");
          LoadCollectionChildren(openXmlElement);
          //Debug.WriteLine($"Finished loading collection children for {GetType().Name}. Total items loaded: {Items.Count}");
          IsSynchronized = true;
          DataSource = null;
        });
      }
    }
  }

  /// <summary>
  /// Checks if the specified item is acceptable for this collection.
  /// </summary>
  /// <param name="item">The item to check.</param>
  /// <returns>True if the item is acceptable; otherwise, false.</returns>
  public virtual bool AcceptItem(object item)
  {
    return true;
  }

  /// <summary>
  /// Mapping from OpenXml element types to model element types. This mapping is used to determine the appropriate model element type for a given OpenXml element type when loading data into the collection.
  /// </summary>
  public abstract BiDiDictionary<Type, Type> ModelElementTypeMapping { get; }

  /// <summary>
  /// Loads and appends child elements from the specified OpenXml composite element into the collection, converting each
  /// to the appropriate model type.  
  /// </summary>
  /// <remarks>Only child elements accepted by the AcceptItem method are processed. The method ensures thread
  /// safety when appending items to the collection.</remarks>
  /// <param name="openXmlElement">The OpenXml composite element whose child elements are to be loaded and converted.</param>
  /// <exception cref="InvalidOperationException">Thrown if a model element type mapping cannot be found for a child OpenXml element, or if the converted model item
  /// is not compatible with the expected type.</exception>
  private void LoadCollectionChildren(DX.OpenXmlCompositeElement openXmlElement)
  {
    var children = openXmlElement.Elements().ToArray();
    //Debug.WriteLine($"Loading {children.Length} child elements for {GetType().Name} from OpenXmlCompositeElement: {openXmlElement.LocalName}");
    foreach (var openXmlChildElement in children)
    {
      if (!AcceptItem(openXmlChildElement))
        continue;
      if (ModelElementTypeMapping.TryGetValue(openXmlChildElement.GetType(), out var modelItemType) == false)
        throw new InvalidOperationException($"No model element type mapping found for OpenXml element type {openXmlChildElement.GetType()}");
      var modelItem = OpenXmlModelConverter.ConvertFrom(openXmlChildElement, modelItemType);
      if (modelItem != null && !modelItemType.IsInstanceOfType(modelItem))
        throw new InvalidOperationException($"Converted model Item is not compatible to {modelItemType}");
      lock (SyncRoot)
        Append((ItemType)modelItem!);
    }
  }

  /// <summary>
  /// Adds an item to the collection without waiting for synchronization. This method is intended for internal use when loading data from the data source, and it bypasses the synchronization checks to allow for efficient population of the collection.
  /// </summary>
  /// <param name="item">The item to add to the collection.</param>
  private void Append(ItemType item)
  {
    Items.Add(item);
  }

  /// <summary>
  /// Returns or assigns the item at the specified index.
  /// </summary>
  /// <param name = "index">The zero-based index.</param>
  public override ItemType this[int index]
  {
    get
    {
      if (DataSource is DX.OpenXmlCompositeElement openXmlElement)
      {
        if (HasDirectAccess)
        {
          var childElements = openXmlElement.Elements().Where(AcceptItem).ToArray();
          if (index < 0 || index >= childElements.Length)
            throw new ArgumentOutOfRangeException(nameof(index),
              $"Index {index} is out of range for the collection with {childElements.Length} items.");

          var openXmlChildElement = childElements[index];
          if (ModelElementTypeMapping.TryGetValue(openXmlChildElement.GetType(), out var modelItemType) == false)
            throw new InvalidOperationException(
              $"No model element type mapping found for OpenXml element type {openXmlChildElement.GetType()}");

          var modelItem = OpenXmlModelConverter.ConvertFrom(openXmlChildElement, modelItemType);
          if (modelItem != null && !modelItemType.IsInstanceOfType(modelItem))
            throw new InvalidOperationException($"Converted model Item is not compatible to {modelItemType}");

          return (ItemType)modelItem!;
        }

        while (!IsSynchronized && index > Items.Count - 1)
        {
          //Debug.WriteLine($"Waiting for synchronization to access item at index {index}  in {GetType().Name}. Current count: {Items.Count}");
          Task.Delay(1).Wait();
        }
      }
      return Items[index];
    }
    set
    {
      while (!IsSynchronized)
        Task.Delay(1).Wait();
      Items[index] = value;
    }
  }
}