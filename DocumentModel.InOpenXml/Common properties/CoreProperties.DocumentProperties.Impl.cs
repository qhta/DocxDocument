namespace DocumentModel;

#pragma warning disable CS1591

public partial class CoreProperties : IDocumentProperties
{
  /// <summary>
  /// Attempt to add a property to this instance. The property is added by setting the value of the property to the value of the item parameter. If the property does not exist, an exception is thrown.
  /// </summary>
  /// <param name="item">The document property to add.</param>
  /// <returns>True if the property was added successfully; otherwise, false.</returns>
  public bool TryAdd(DocumentProperty item)
  {
    if (item.Name != null)
    {
      if (KnownProperties.TryGetValue(item.Name, out var property))
      {
        property.SetValue(this, item.Value);
        CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, 
          new[] { item }, Array.Empty<object>()));
        return true;
      }
    }
    return false;
  }

  /// <summary>
  /// Adds a property to this instance by setting the value of the property to the value of the item parameter. If the property does not exist, an exception is thrown.
  /// </summary>
  /// <param name="item">The document property to add.</param>
  /// <exception cref="ArgumentException">Thrown when the document property does not exist or the name is null.</exception>
  public void Add(DocumentProperty item)
  {
    if (item.Name != null)
    {
      if (KnownProperties.TryGetValue(item.Name, out var property))
      {
        property.SetValue(this, item.Value);
        CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add,
          new[] { item }, Array.Empty<object>()));
      }
      else
      {
        throw new ArgumentException($"DocumentProperty with name '{item.Name}' does not exist in {GetType().Name}.");
      }
    }
    else
    {
      throw new ArgumentException("DocumentProperty name cannot be null.");
    }
  }


  /// <summary>
  ///  Clears all property values in this instance by setting them to null. 
  /// </summary>
  public void Clear()
  {
    foreach (var property in KnownProperties.Values)
    {
      property.SetValue(this, null);
    }
    CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
  }

  /// <summary>
  /// Determines whether known properties of this instance contain a property with the same name as the specified property name.
  /// It does not consider the value of the property when determining if it exists in this instance.
  /// </summary>
  /// <param name="propertyName">The name of the property to check for existence.</param>
  /// <returns>True if the property exists; otherwise, false.</returns>
  public bool ContainsPropertyName(string propertyName)
  {
    if (KnownProperties.TryGetValue(propertyName, out var property))
    {
      return true;
    }
    return false;
  }

  /// <summary>
  /// Determines whether known properties of this instance contain a property with the same name as the specified item.
  /// The value of the property should not be null for the property to be considered as existing in this instance.
  /// </summary>
  /// <param name="item">The document property to check for existence.</param>
  /// <returns>True if the property exists; otherwise, false.</returns>
  public bool ContainsNotNull(DocumentProperty item)
  {
    if (item.Name != null)
    {
      if (KnownProperties.TryGetValue(item.Name, out var property))
      {
        if (property.GetValue(this) != null)
          return true;
        else
          return false;
      }
    }
    return false;
  }

  /// <summary>
  /// Determines whether known properties of this instance contain a property with the same name as the specified item.
  /// The value of the property should be the same as the specified item for the property to be considered as existing in this instance.
  /// </summary>
  /// <param name="item">The document property to check for existence.</param>
  /// <returns>True if the property exists; otherwise, false.</returns>
  public bool Contains(DocumentProperty item)
  {
    if (item.Name != null)
    {
      if (KnownProperties.TryGetValue(item.Name, out var property))
      {
        if (property.GetValue(this) == item.Value)
          return true;
        else
          return false;
      }
    }
    return false;
  }

  /// <summary>
  /// Removes the property with the same name as the specified item from this instance by setting its value to null.
  /// The value of the property is not considered when determining if it exists in this instance.
  /// </summary>
  /// <param name="item">The document property to remove.</param>
  /// <returns>True if the property was removed successfully; otherwise, false.</returns>
  public bool Remove(DocumentProperty item)
  {
    if (item.Name != null)
    {
      if (KnownProperties.TryGetValue(item.Name, out var property))
      {
        property.SetValue(this, null);
        CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, 
          Array.Empty<object>(), new[] { item }));
        return true;
      }
    }
    return false;
  }

  /// <summary>
  ///  Clears all property values in this instance by setting them to null. 
  /// </summary>
  public int Count
  {
    get
    {
      var count = 0;
      foreach (var property in KnownProperties.Values)
      {
        if (property.GetValue(this) != null)
          count++;
      }
      return count;
    }
  }

  /// <summary>
  /// Indicates whether the collection of document properties is read-only.
  /// In this implementation, the collection is not read-only, so this property always returns false.
  /// </summary>
  public bool IsReadOnly => false;

  /// <summary>
  /// Returns an enumerator that iterates through the collection of document properties.
  /// The enumerator includes only the properties that have non-null values.
  /// </summary>
  /// <returns>An enumerator that can be used to iterate through the collection of document properties.</returns>
  public IEnumerator<DocumentProperty> GetEnumerator()
  {
    foreach (var property in KnownProperties.Values)
    {
      var value = property.GetValue(this);
      if (value != null)
      {
        yield return new BuiltInProperty{ Name = property.Name, Value = value};
      }
    }
  }

  /// <summary>
  /// Returns an enumerator that iterates through the collection of document properties.
  /// </summary>
  IEnumerator IEnumerable.GetEnumerator()
  {
    return GetEnumerator();
  }

  /// <summary>
  /// Copies the elements of the document properties collection to an array, starting at a particular array index.
  /// The method copies only the properties that have non-null values.
  /// </summary>
  /// <param name="array">The destination array.</param>
  /// <param name="arrayIndex">The zero-based index in the destination array at which copying begins.</param>
  public void CopyTo(DocumentProperty[] array, int arrayIndex)
  {
    var tempArray = this.ToArray();
    Array.Copy(array, arrayIndex, tempArray, 0, array.Length - arrayIndex);
  }

  public event NotifyCollectionChangedEventHandler? CollectionChanged;
}
