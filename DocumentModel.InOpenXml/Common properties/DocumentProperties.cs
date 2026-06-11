namespace DocumentModel;

/// <summary>
/// Collection of all document properties;
/// </summary>
[XmlRoot("DocumentProperties", Namespace = "DocumentModel")]
public abstract partial class DocumentProperties<OpenXmlElementType, DocumentPropertyType>: 
  ModelElement<OpenXmlElementType>, IDocumentProperties<DocumentPropertyType>
where OpenXmlElementType: DX.OpenXmlElement
where DocumentPropertyType: DocumentProperty
{
  /// <summary>
  /// Attempts to add a document property to the collection.
  /// </summary>
  /// <param name="item">The document property to add.</param>
  /// <returns>True if the property was added successfully; otherwise, false.</returns>
  public abstract bool TryAdd(DocumentPropertyType item);

  /// <summary>
  /// Returns an enumerator that iterates through the collection of document properties.  
  /// </summary>
  /// <returns>An enumerator that can be used to iterate through the collection.</returns>
  public abstract IEnumerator<DocumentPropertyType> GetEnumerator();

  //IEnumerator IEnumerable.GetEnumerator()
  //{
  //  return GetEnumerator();
  //}

  /// <summary>
  /// Adds a document property to the collection. If a property with the same name already exists, it will be replaced.
  /// </summary>
  /// <param name="item">The document property to add.</param>
  public abstract void Add(DocumentPropertyType item);

  /// <summary>
  /// Removes all document properties from the collection by setting their values to null. The properties themselves are not removed from the collection, but their values are cleared, effectively resetting the collection to an empty state.
  /// </summary>
  public abstract void Clear();
  /// <summary>
  /// Determines whether the collection contains a specific document property.
  /// </summary>
  /// <param name="item">The document property to locate in the collection.</param>
  /// <returns>True if the property is found; otherwise, false.</returns> 
  public abstract bool Contains(DocumentPropertyType item);

  ///// <summary>
  ///// Copies the elements of the collection to an array, starting at a particular array index.
  ///// The method copies the document properties from the collection into the specified array, beginning at the specified index.
  ///// This allows for efficient copying of the collection's contents into an array for further processing or manipulation.
  ///// </summary>
  ///// <param name="array">The destination array.</param>
  ///// <param name="arrayIndex">The zero-based index in the array at which copying begins.</param>
  //public abstract void CopyTo(DocumentPropertyType[] array, int arrayIndex);

  /// <summary>
  /// Removes a specific document property from the collection.
  /// The method searches for the specified property in the collection and removes it if found.
  /// If the property is successfully removed, the method returns true;
  /// otherwise, it returns false, indicating that the property was not found in the collection.
  /// </summary>
  /// <param name="item">The document property to remove from the collection.</param>
  /// <returns>True if the property was successfully removed; otherwise, false.</returns>
  public abstract bool Remove(DocumentPropertyType item);
  /// <summary>
  /// Gets the number of document properties in the collection.
  /// </summary>
  public abstract int Count { get; }

  /// <summary>
  /// Indicates whether the collection of document properties is read-only.
  /// A read-only collection does not allow adding, removing, or modifying properties.
  /// If this property returns true, any attempt to modify the collection will result in an exception.
  /// If it returns false, the collection can be modified freely.
  /// </summary>
  public abstract bool IsReadOnly { get; }

  /// <summary>
  /// Occurs when a property value in the collection changes, or when properties are added or removed from the collection.
  /// </summary>
  public abstract event NotifyCollectionChangedEventHandler? CollectionChanged;
}