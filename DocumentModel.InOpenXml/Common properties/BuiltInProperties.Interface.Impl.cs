namespace DocumentModel;

public partial class BuiltInProperties : IDocumentProperties, IModelCollection<DocumentProperty>
{


  IEnumerator<DocumentProperty> IEnumerable<DocumentProperty>.GetEnumerator() => this.GetEnumerator();


  DocumentProperty IModelCollection<DocumentProperty>.this[object index]
  {
    get
    {
      if (index is string propertyName)
        if (propertyNameMapping.TryGetValue1(propertyName, out var mappedName))
          index = mappedName;
      return this[(string)index];
    }

    set
    {
      if (index is string propertyName)
        if (propertyNameMapping.TryGetValue1(propertyName, out var mappedName))
          index = mappedName;
      this[(string)index] = (BuiltInProperty)value;
    }
  }
  private static readonly BiDiDictionary<string, string> propertyNameMapping = new()
  {
    {
      "Title",
      "Title"
    },
    {
      "Subject",
      "Subject"
    },
    {
      "Creator",
      "Author"
    },
    {
      "Keywords",
      "Keywords"
    },
    {
      "Description",
      "Comments"
    },
    {
      "LastModifiedBy",
      "LastAuthor"
    },
    {
      "Revision",
      "RevisionNumber"
    },
    {
      "Created",
      "CreationDate"
    },
    {
      "Modified",
      "ModificationDate"
    },
  };

  /// <summary>
  /// Tries to add a property to the collection. Returns false if the property is not supported or already exists.
  /// </summary>
  /// <param name="item">The property to add.</param>
  /// <returns>True if the property was added successfully; otherwise, false.</returns>
  /// <exception cref="NotImplementedException"></exception>
  public bool TryAdd(DocumentProperty item)
  {
    throw new NotImplementedException();
  }

  /// <summary>
  /// Adds a property to the collection. Throws an exception if the property is not supported or already exists.  
  /// </summary>
  /// <param name="item"></param>
  /// <exception cref="NotImplementedException"></exception>
  public void Add(DocumentProperty item)
  {
    throw new NotImplementedException();
  }
  /// <summary>
  /// Determines whether the collection contains a specific property.
  /// </summary>
  /// <param name="item">The property to locate in the collection.</param>
  /// <returns>True if the property is found; otherwise, false.</returns>
  /// <exception cref="NotImplementedException"></exception>
  public bool Contains(DocumentProperty item)
  {
    throw new NotImplementedException();
  }
  /// <summary>
  /// Copies the elements of the collection to an array, starting at a particular array index.
  /// </summary>
  /// <param name="array">The destination array.</param>
  /// <param name="arrayIndex">The zero-based index in the array at which copying begins.</param>
  /// <exception cref="NotImplementedException"></exception>
  public void CopyTo(DocumentProperty[] array, int arrayIndex)
  {
    throw new NotImplementedException();
  }
  /// <summary>
  /// Removes a specific property from the collection.
  /// </summary>
  /// <param name="item">The property to remove.</param>
  /// <returns>True if the property was successfully removed; otherwise, false.</returns>
  /// <exception cref="NotImplementedException"></exception>
  public bool Remove(DocumentProperty item)
  {
    throw new NotImplementedException();
  }
}
