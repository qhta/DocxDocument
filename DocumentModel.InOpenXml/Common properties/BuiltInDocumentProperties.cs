namespace DocumentModel;
/// <summary>
/// Collection of all document properties;
/// </summary>
[XmlRoot("DocumentProperties", Namespace = "DocumentModel")]
public partial class BuiltInDocumentProperties : DocumentProperties<BuiltInProperty>
{
  /// <summary>
  /// Initializes a new instance of the DocumentProperties class with the specified known properties.
  /// </summary>
  /// <param name="knownProperties"></param>
  protected BuiltInDocumentProperties(KnownProperties knownProperties)
  {
    KnownProperties = knownProperties;
  }

  /// <summary>
  /// Known properties that can be set in this instance of DocumentProperties.
  /// The known properties are defined in the derived classes of DocumentProperties
  /// and are used to determine which properties can be added, removed, or checked for existence in this instance.
  /// </summary>
  protected KnownProperties KnownProperties { get; private set; }


  /// <summary>
  /// Attempt to add a property to this instance. The property is added by setting the value of the property to the value of the item parameter. If the property does not exist, an exception is thrown.
  /// </summary>
  /// <param name="item">The document property to add.</param>
  /// <returns>True if the property was added successfully; otherwise, false.</returns>
  public override bool TryAdd(BuiltInProperty item)
  {
    if (item.Name != null)
    {
      if (KnownProperties.TryGetValue(item.Name, out var property))
      {
        var docPropertyType = property.PropertyType.ConvertToDocPropertyType();
        var valueObject = item.Value;
        property.SetValue(this, valueObject);
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
  public override void Add(BuiltInProperty item)
  {
    if (item.Name != null)
    {
      if (KnownProperties.TryGetValue(item.Name, out var property))
      {
        var docPropertyType = property.PropertyType.ConvertToDocPropertyType();
        var valueObject = item.Value;
        property.SetValue(this, valueObject);
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
  public override void Clear()
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
  public bool ContainsNotNull(BuiltInProperty item)
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
  public override bool Contains(BuiltInProperty item)
  {
    if (item.Name != null)
    {
      if (KnownProperties.TryGetValue(item.Name, out var property))
      {
        if (property.GetValue(this) == item.Value)
          return true;
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
  public override bool Remove(BuiltInProperty item)
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
  public override int Count
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
  public override bool IsReadOnly => false;

  /// <summary>
  /// Returns an enumerator that iterates through the collection of document properties.
  /// The enumerator includes only the properties that have non-null values.
  /// </summary>
  /// <returns>An enumerator that can be used to iterate through the collection of document properties.</returns>
  public override IEnumerator<BuiltInProperty> GetEnumerator()
  {
    foreach (var property in KnownProperties.Values)
    {
      var value = property.GetValue(this);
      if (value != null)
      {
        yield return new BuiltInProperty { Name = property.Name, Value = value };
      }
    }
  }

  /// <summary>
  /// Event that is raised when the collection of document properties changes.
  /// The event is triggered when a property is added, removed, or when the collection is cleared.
  /// The event handlers receive information about the type of change that occurred and the properties involved in the change
  /// through the NotifyCollectionChangedEventArgs parameter.
  /// </summary>
  public override event NotifyCollectionChangedEventHandler? CollectionChanged;

  /// <summary>
  /// Copies the elements of the collection of document properties to an array, starting at a particular array index.
  /// </summary>
  /// <param name="array">The destination array.</param>
  /// <param name="arrayIndex">The zero-based index in the array at which copying begins.</param>
  public override void CopyTo(BuiltInProperty[] array, int arrayIndex)
  {
    var tempArray = this.ToArray();
    Array.Copy(tempArray, 0, array, arrayIndex, tempArray.Length);
  }

  /// <summary>
  /// Tries to get a property from this instance by its name.
  /// If the property exists, it is returned in the builtInProperty parameter and the method returns true;
  /// otherwise, the method returns false and the builtInProperty parameter is set to null.
  /// </summary>
  /// <param name="propertyName">The name of the property to get.</param>
  /// <param name="builtInProperty">When this method returns, contains the property if found; otherwise, null.</param>
  /// <returns>True if the property was found; otherwise, false.</returns>
  public bool TryGetProperty(string propertyName, out BuiltInProperty builtInProperty)
  {
    if (KnownProperties.TryGetValue(propertyName, out var property))
    {
      var valueObject = property.GetValue(this);
      builtInProperty = new BuiltInProperty { Name = propertyName, Value = valueObject };
      return true;
    }
    builtInProperty = null!;
    return false;
  }

  /// <summary>
  /// Tries to set a property in this instance by its name.
  /// </summary>
  /// <param name="propertyName">The name of the property to set.</param>
  /// <param name="builtInProperty">The property value to set.</param>
  /// <returns>True if the property was set; otherwise, false.</returns>
  public bool TrySetProperty(string propertyName, BuiltInProperty builtInProperty)
  {
    if (KnownProperties.TryGetValue(propertyName, out var property))
    {
      var docPropertyType = property.PropertyType.ConvertToDocPropertyType();
      var valueObject = builtInProperty.Value;
      property.SetValue(this, valueObject);
      return true;
    }
    builtInProperty = null!;
    return false;
  }

  /// <summary>
  /// Gets or sets a property in this instance by its name. If the property does not exist, an exception is thrown. 
  /// </summary>
  /// <param name="propertyName">The name of the property to get or set.</param>
  /// <returns>The property with the specified name.</returns>
  /// <exception cref="ArgumentException">Thrown when the property does not exist.</exception>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public BuiltInProperty this[string propertyName]
  {
    get
    {
      if (KnownProperties.TryGetValue(propertyName, out var property))
      {
        var valueObject = property.GetValue(this);
        return new BuiltInProperty { Name = propertyName, Value = valueObject };
      }
      throw new ArgumentException($"DocumentProperty with name '{propertyName}' does not exist in {GetType().Name}.");
    }
    set
    {
      if (KnownProperties.TryGetValue(propertyName, out var property))
      {
        var valueObject = value;
        property.SetValue(this, valueObject);
        return;
      }
      throw new ArgumentException($"DocumentProperty with name '{propertyName}' does not exist in {GetType().Name}.");
    }
  }

  /// <summary>
  /// Returns an enumerable collection of the document properties in this instance. The collection includes only the properties that have non-null values.
  /// </summary>
  /// <returns>An enumerable collection of <see cref="BuiltInProperty"/> objects.</returns>
  public IEnumerable<BuiltInProperty> AsQueryable()
  {
    foreach (var item in this)
    {
      yield return item;
    }
  }
}