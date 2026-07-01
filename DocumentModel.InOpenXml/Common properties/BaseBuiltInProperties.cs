namespace DocumentModel;
/// <summary>
/// Collection of all document properties;
/// </summary>
[XmlRoot("DocumentProperties", Namespace = "DocumentModel")]
public partial class BaseBuiltInProperties : ModelElement<DX.OpenXmlElement>
{
  private BaseBuiltInPropertiesCollection _propertiesCollection;

  /// <summary>
  /// Default constructor needed by XmlSerializer
  /// </summary>
  protected BaseBuiltInProperties()
  {
    _propertiesCollection = new();
  }

  /// <summary>
  /// Initializes a new instance of the DocumentProperties class with the specified known properties.
  /// </summary>
  /// <param name="knownProperties"></param>
  protected BaseBuiltInProperties(KnownProperties knownProperties)
  {
    _propertiesCollection = new BaseBuiltInPropertiesCollection(this, knownProperties);
  }

  /// <summary>
  /// Attempt to add a property to this instance. The property is added by setting the value of the property to the value of the item parameter. If the property does not exist, an exception is thrown.
  /// </summary>
  /// <param name="item">The document property to add.</param>
  /// <returns>True if the property was added successfully; otherwise, false.</returns>
  public bool TryAdd(BuiltInProperty item)
    => _propertiesCollection.TryAdd(item);

  /// <summary>
  /// Adds a property to this instance by setting the value of the property to the value of the item parameter. If the property does not exist, an exception is thrown.
  /// </summary>
  /// <param name="item">The document property to add.</param>
  /// <exception cref="ArgumentException">Thrown when the document property does not exist or the name is null.</exception>
  public void Add(BuiltInProperty item)
    => _propertiesCollection.Add(item);


  /// <summary>
  ///  Clears all property values in this instance by setting them to null. 
  /// </summary>
  public void Clear()
    => _propertiesCollection.Clear();

  /// <summary>
  /// Determines whether known properties of this instance contain a property with the same name as the specified property name.
  /// It does not consider the value of the property when determining if it exists in this instance.
  /// </summary>
  /// <param name="propertyName">The name of the property to check for existence.</param>
  /// <returns>True if the property exists; otherwise, false.</returns>
  public bool ContainsPropertyName(string propertyName)
    => _propertiesCollection.ContainsPropertyName(propertyName);

  /// <summary>
  /// Determines whether known properties of this instance contain a property with the same name as the specified item.
  /// The value of the property should not be null for the property to be considered as existing in this instance.
  /// </summary>
  /// <param name="item">The document property to check for existence.</param>
  /// <returns>True if the property exists; otherwise, false.</returns>
  public bool ContainsNotNull(BuiltInProperty item)
    => _propertiesCollection.ContainsNotNull(item);

  /// <summary>
  /// Determines whether known properties of this instance contain a property with the same name as the specified item.
  /// The value of the property should be the same as the specified item for the property to be considered as existing in this instance.
  /// </summary>
  /// <param name="item">The document property to check for existence.</param>
  /// <returns>True if the property exists; otherwise, false.</returns>
  public bool Contains(BuiltInProperty item)
    => _propertiesCollection.Contains(item);

  /// <summary>
  /// Removes the property with the same name as the specified item from this instance by setting its value to null.
  /// The value of the property is not considered when determining if it exists in this instance.
  /// </summary>
  /// <param name="item">The document property to remove.</param>
  /// <returns>True if the property was removed successfully; otherwise, false.</returns>
  public bool Remove(BuiltInProperty item)
    => _propertiesCollection.Remove(item);

  /// <summary>
  ///  Counts all property values in this instance that are not null. 
  /// </summary>
  public int Count => _propertiesCollection.Count;

  /// <summary>
  /// Returns an enumerator that iterates through the collection of document properties.
  /// The enumerator includes only the properties that have non-null values.
  /// </summary>
  /// <returns>An enumerator that can be used to iterate through the collection of document properties.</returns>
  public IEnumerator<BuiltInProperty> GetEnumerator()
    => _propertiesCollection.GetEnumerator();

  /// <summary>
  /// Event that is raised when the collection of document properties changes.
  /// The event is triggered when a property is added, removed, or when the collection is cleared.
  /// The event handlers receive information about the type of change that occurred and the properties involved in the change
  /// through the NotifyCollectionChangedEventArgs parameter.
  /// </summary>
  public event NotifyCollectionChangedEventHandler? CollectionChanged
  {
    add => _propertiesCollection.CollectionChanged += value;
    remove => _propertiesCollection.CollectionChanged -= value;
  }

  /// <summary>
  /// Copies the elements of the collection of document properties to an array, starting at a particular array index.
  /// </summary>
  /// <param name="array">The destination array.</param>
  /// <param name="arrayIndex">The zero-based index in the array at which copying begins.</param>
  public void CopyTo(BuiltInProperty[] array, int arrayIndex)
    => _propertiesCollection.CopyTo(array, arrayIndex);

  /// <summary>
  /// Tries to get a property from this instance by its name.
  /// If the property exists, it is returned in the builtInProperty parameter and the method returns true;
  /// otherwise, the method returns false and the builtInProperty parameter is set to null.
  /// </summary>
  /// <param name="propertyName">The name of the property to get.</param>
  /// <param name="builtInProperty">When this method returns, contains the property if found; otherwise, null.</param>
  /// <returns>True if the property was found; otherwise, false.</returns>
  public bool TryGetProperty(string propertyName, out BuiltInProperty builtInProperty) 
    => _propertiesCollection.TryGetProperty(propertyName, out builtInProperty);

  /// <summary>
  /// Tries to set a property in this instance by its name.
  /// </summary>
  /// <param name="propertyName">The name of the property to set.</param>
  /// <param name="builtInProperty">The property value to set.</param>
  /// <returns>True if the property was set; otherwise, false.</returns>
  public bool TrySetProperty(string propertyName, BuiltInProperty builtInProperty) 
    => _propertiesCollection.TrySetProperty(propertyName, builtInProperty);

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
    get => _propertiesCollection[propertyName];
    set => _propertiesCollection[propertyName] = value;
  }

  /// <summary>
  /// Returns an enumerable collection of the document properties in this instance. The collection includes only the properties that have non-null values.
  /// </summary>
  /// <returns>An enumerable collection of <see cref="BuiltInProperty"/> objects.</returns>
  public IEnumerable<BuiltInProperty> AsQueryable() => _propertiesCollection.AsQueryable();
}