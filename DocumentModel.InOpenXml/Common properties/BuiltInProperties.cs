namespace DocumentModel;
/// <summary>
/// Collection of all document properties that is divided to three parts: core properties, 
/// content properties, and statistic properties. 
/// </summary>
[DataContract]
[XmlRoot("BuiltInProperties", Namespace = "DocumentModel")]
public partial class BuiltInProperties : ModelElement, IWordprocessingDocumentAware, IElementCollection<BuiltInProperty>
{

  /// <summary>
  /// Default constructor. Initializes an empty collection of built-in properties without associating it with any document.
  /// </summary>
  public BuiltInProperties()
  {
    CoreProperties = new CoreProperties();
    foreach (var property in CoreProperties.KnownProperties.Values)
      Attach(CoreProperties, property);
    ContentProperties = new ContentProperties();
    foreach (var property in ContentProperties.KnownProperties.Values)
      Attach(ContentProperties, property);
    StatisticProperties = new StatisticProperties();
    foreach (var property in StatisticProperties.KnownProperties.Values)
      Attach(StatisticProperties, property);
  }

  /// <summary>
  /// Initializing constructor. Initializes the properties based on the provided document.
  /// </summary>
  /// <param name = "document">The document from which to initialize the properties.</param>
  public BuiltInProperties(DMW.Document document)
  {
    CoreProperties = document.CoreProperties;
    ContentProperties = document.ContentProperties;
    StatisticProperties = document.StatisticProperties;
    if (document.WordprocessingDocument != null)
    {
      CoreProperties.AttachAndLoad(document.WordprocessingDocument);
      ContentProperties.AttachAndLoad(document.WordprocessingDocument);
      StatisticProperties.AttachAndLoad(document.WordprocessingDocument);
    }
    foreach (var property in CoreProperties.KnownProperties.Values)
      Attach(CoreProperties, property);
    foreach (var property in ContentProperties.KnownProperties.Values)
      Attach(ContentProperties, property);
    foreach (var property in StatisticProperties.KnownProperties.Values)
      Attach(StatisticProperties, property);
  }
  /// <summary>
  /// Gets the associated WordprocessingDocument.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public DXPP.WordprocessingDocument? WordprocessingDocument { [DebuggerStepThrough] get; [DebuggerStepThrough] private set; }

  /// <summary>
  /// Attaches the collection of built-in properties to the provided WordprocessingDocument. This method sets the WordprocessingDocument property of the collection to the provided document, allowing the collection to interact with the document's properties. It does not load or update any property values; it simply establishes the association between the collection and the document. To load or update property values, use the AttachAndLoad or AttachAndUpdate methods, respectively.
  /// </summary>
  /// <param name="wordprocessingDocument">The WordprocessingDocument to attach to the collection.</param>
  public void Attach(DXPP.WordprocessingDocument wordprocessingDocument)
  {
    WordprocessingDocument = wordprocessingDocument;
  }

  /// <summary>
  /// Attaches the collection of built-in properties to the provided WordprocessingDocument and loads the property values from the document. This method sets the WordprocessingDocument property of the collection to the provided document and then calls the AttachAndLoad method on each of the subordinate properties (core, content, and statistic) to load their values from the document. This allows the collection to be populated with the current property values from the associated WordprocessingDocument.
  /// </summary>
  /// <param name="wordprocessingDocument">The WordprocessingDocument to attach and load the properties from.</param>
  public void AttachAndLoad(DXPP.WordprocessingDocument wordprocessingDocument)
  {
    WordprocessingDocument = wordprocessingDocument;
    CoreProperties.AttachAndLoad(wordprocessingDocument);
    ContentProperties.AttachAndLoad(wordprocessingDocument);
    StatisticProperties.AttachAndLoad(wordprocessingDocument);
  }

  /// <summary>
  /// Attaches the collection of built-in properties to the provided WordprocessingDocument and updates the property values in the document based on the current state of the collection. This method sets the WordprocessingDocument property of the collection to the provided document and then calls the AttachAndUpdate method on each of the subordinate properties (core, content, and statistic) to update their values in the document based on the current values in the collection. This allows any changes made to the properties in the collection to be reflected in the associated WordprocessingDocument.
  /// </summary>
  /// <param name="wordprocessingDocument">The WordprocessingDocument to attach and update the properties in.</param>
  public void AttachAndUpdate(DXPP.WordprocessingDocument wordprocessingDocument)
  {
    WordprocessingDocument = wordprocessingDocument;
    CoreProperties.AttachAndUpdate(wordprocessingDocument);
    ContentProperties.AttachAndUpdate(wordprocessingDocument);
    StatisticProperties.AttachAndUpdate(wordprocessingDocument);
  }

  /// <summary>
  /// Detaches the collection of built-in properties from the associated WordprocessingDocument. This method sets the WordprocessingDocument property of the collection to null and calls the Detach method on each of the subordinate properties (core, content, and statistic) to clear their associations with the document. After calling this method, the collection will no longer be associated with any WordprocessingDocument, and any changes made to the properties in the collection will not affect any document until it is attached again.
  /// </summary>
  public void Detach()
  {
    WordprocessingDocument = null;
    CoreProperties.Detach();
    ContentProperties.Detach();
    StatisticProperties.Detach();
  }

  /// <summary>
  /// Provides access to the core properties of the document.
  /// </summary>
  public CoreProperties CoreProperties { [DebuggerStepThrough] get; [DebuggerStepThrough] private set; }
  /// <summary>
  /// Provides access to the content properties of the document.
  /// </summary>
  public ContentProperties ContentProperties { [DebuggerStepThrough] get; [DebuggerStepThrough] private set; }
  /// <summary>
  /// Provides access to the statistics properties of the document.
  /// </summary>
  public StatisticProperties StatisticProperties { [DebuggerStepThrough] get; [DebuggerStepThrough] private set; }

  /// <summary>
  /// Adds a new built-in document property to the collection based on the provided known property model.
  /// </summary>
  /// <param name = "baseObject">The object that contains the property.</param>
  /// <param name = "knownPropertyModel">The known property model to attach.</param>
  private void Attach(object baseObject, PropertyModel knownPropertyModel)
  {
    var propertyInfo = knownPropertyModel.PropertyInfo;
    var builtInAttribute = propertyInfo.GetCustomAttribute<BuiltInPropertyAttribute>();
    if (builtInAttribute != null)
    {
      if (TryGetProperty(propertyInfo.Name, out var existingProperty) && existingProperty != null)
      {
        var valueObject = existingProperty.Value;
        existingProperty.BaseObject = baseObject;
        existingProperty.PropertyInfo = propertyInfo;
        var value0 = existingProperty.GetAttachedPropertyInfo();
        existingProperty.ExpectedType = propertyInfo.PropertyType.ConvertToDocumentPropertyType();
        existingProperty.ValueType = propertyInfo.PropertyType; 
        if (valueObject!=value0)
          existingProperty.SetAttachedPropertyValue(valueObject);
      }
      else
      {
        var DocumentProperty = new BuiltInProperty
        {
          BaseObject = baseObject,
          PropertyInfo = propertyInfo,
          Name = propertyInfo.Name,
          ValueType = propertyInfo.PropertyType,
          ExpectedType = propertyInfo.PropertyType.ConvertToDocumentPropertyType()
        };

        Add(DocumentProperty);
      }
    }
  }

  /// <summary>
  /// Clears all built-in properties from the collection by clearing the core, content, and statistic properties.
  /// </summary>
  public void Clear()
  {
    CoreProperties.Clear();
    ContentProperties.Clear();
    StatisticProperties.Clear();
  }

  /// <summary>
  /// Tries to add a new built-in property to the collection.
  /// The method tries to add the property to the core properties, content properties, or statistic properties.
  /// </summary>
  /// <param name="builtInProperty">The built-in property to add.</param>
  /// <returns>True if the property was successfully added; otherwise, false.</returns>
  public bool TryAdd(BuiltInProperty builtInProperty)
  {
    if (builtInProperty.Name != null)
    {
      return CoreProperties.TryAdd(builtInProperty) || ContentProperties.TryAdd(builtInProperty) || StatisticProperties.TryAdd(builtInProperty);
    }
    return false;
  }

  /// <summary>
  /// Adds a new built-in property to the collection.
  /// The method checks if the property name exists in the known properties of the core properties, content properties, or statistic properties.
  /// If it does, it updates the value of the existing property in the subordinate properties with the value of the provided built-in property.
  /// </summary>
  /// <param name="builtInProperty">The built-in property to add.</param>
  /// <exception cref="InvalidOperationException">Thrown when the built-in property is not found in known properties or built-in property name is null.</exception>

  public void Add(BuiltInProperty builtInProperty)
  {
    if (builtInProperty.Name != null)
    {
      if (builtInProperty.Name == "TitlesOfParts")
      {
        ContentProperties.TryAdd(builtInProperty);
        return;
      }

      if (CoreProperties.TryAdd(builtInProperty) || ContentProperties.TryAdd(builtInProperty) || StatisticProperties.TryAdd(builtInProperty))
        return;
      throw new InvalidOperationException($"BuiltInProperty {builtInProperty.Name} not found in known properties.");
    }
    else throw new InvalidOperationException($"BuiltInProperty must have a name.");
  }

  /// <summary>
  /// Checks if a built-in property with the same name as the provided built-in property exists in the collection and has a non-null value.
  /// </summary>
  /// <param name="builtInProperty">The built-in property to check for existence and non-null value.</param>
  /// <returns>True if the built-in property exists and has a non-null value; otherwise, false.</returns>
  /// <exception cref="InvalidOperationException">Thrown when the built-in property is not found in known properties.</exception>
  public bool Contains(BuiltInProperty builtInProperty)
  {
    if (builtInProperty.Name != null)
    {
      return CoreProperties.Contains(builtInProperty) || ContentProperties.Contains(builtInProperty) || StatisticProperties.Contains(builtInProperty);
    }
    return false;
  }


  /// <summary>
  /// Removes a built-in property from the collection by setting its value to null in the corresponding subordinate properties (core, content, or statistic) based on the property name.
  /// </summary>
  /// <param name="builtInProperty">The built-in property to remove.</param>
  /// <returns>True if the built-in property was found and removed; otherwise, false.</returns>
  /// <exception cref="InvalidOperationException">Thrown when the built-in property is not found in known properties or built-in property name is null.</exception>
  public bool Remove(BuiltInProperty builtInProperty)
  {
    if (builtInProperty.Name != null)
    {
      return CoreProperties.Remove(builtInProperty) || ContentProperties.Remove(builtInProperty) || StatisticProperties.Remove(builtInProperty);
    }
    throw new InvalidOperationException($"BuiltInProperty must have a name.");
  }

  /// <summary>
  /// Gets the total count of built-in properties in the collection
  /// by summing the counts of core properties, content properties, and statistic properties.
  /// </summary>
  public int Count => CoreProperties.Count + ContentProperties.Count + StatisticProperties.Count;

  /// <summary>
  /// Indicates whether the collection of built-in properties is read-only.
  /// In this implementation, the collection is not read-only, so it returns false.
  /// </summary>
  public bool IsReadOnly => false;

  /// <summary>
  /// Returns an enumerator that iterates through the collection of built-in properties.
  /// First, it iterates through the core properties, then the content properties, and finally the statistic properties, yielding each built-in property as it goes. This allows for enumeration of all built-in properties in a single sequence, regardless of their categorization in the subordinate properties.
  /// </summary>
  /// <returns>An enumerator that can be used to iterate through the collection.</returns>
  public IEnumerator<BuiltInProperty> GetEnumerator()
  {
    foreach (var property in CoreProperties)
      yield return new BuiltInProperty { Name = property.Name, Value = property.Value };
    foreach (var property in ContentProperties)
      yield return new BuiltInProperty { Name = property.Name, Value = property.Value };
    foreach (var property in StatisticProperties)
      yield return new BuiltInProperty { Name = property.Name, Value = property.Value };
  }

  /// <summary>
  /// Returns an enumerator that iterates through the collection of built-in properties.
  /// </summary>
  /// <returns>An enumerator that can be used to iterate through the collection.</returns>
  IEnumerator IEnumerable.GetEnumerator()
  {
    return GetEnumerator();
  }

  /// <summary>
  /// Occurs when a property value in the collection changes, or when properties are added or removed from the collection.
  /// </summary>
  public event NotifyCollectionChangedEventHandler? CollectionChanged
  {
    add
    {
      CoreProperties.CollectionChanged += value;
      ContentProperties.CollectionChanged += value;
      StatisticProperties.CollectionChanged += value;
    }
    remove
    {
      CoreProperties.CollectionChanged -= value;
      ContentProperties.CollectionChanged -= value;
      StatisticProperties.CollectionChanged -= value;
    }
  }

  /// <summary>
  /// Copies the built-in properties from the collection to an array, starting at a particular array index.
  /// </summary>
  /// <param name="array">The destination array.</param>
  /// <param name="arrayIndex">The zero-based index in the array at which copying begins.</param>
  /// <exception cref="ArgumentException">Thrown when the destination array has insufficient space to copy the elements.</exception>
  public void CopyTo(BuiltInProperty[] array, int arrayIndex)
  {
    var tempList = new List<BuiltInProperty>();
    tempList.AddRange(CoreProperties.AsQueryable());
    tempList.AddRange(ContentProperties.AsQueryable());
    tempList.AddRange(StatisticProperties.AsQueryable());
    if (array.Length - arrayIndex < tempList.Count)
      throw new ArgumentException("The destination array has insufficient space to copy the elements.");
    Array.Copy(tempList.ToArray(), 0, array, arrayIndex, tempList.Count);
  }

  /// <summary>
  /// Gets or sets the built-in property with the specified name. The indexer checks for the existence of the property in the core properties, content properties, and statistic properties, and returns or updates the value accordingly. If a property with the specified name does not exist in any of the subordinate properties, it throws an ArgumentException.
  /// </summary>
  /// <param name="index">The name of the built-in property.</param>
  /// <returns>The built-in property with the specified name.</returns>
  /// <exception cref="ArgumentException">Thrown when a built-in property with the specified name does not exist.</exception>
  public BuiltInProperty this[string index]
  {
    get
    {
      if (CoreProperties.TryGetProperty(index, out var property))
        return property;
      if (ContentProperties.TryGetProperty(index, out property))
        return property;
      if (StatisticProperties.TryGetProperty(index, out property))
        return property;
      throw new ArgumentException($"BuiltInProperty with name '{index}' does not exist.");
    }
    set
    {
      if (ContentProperties.TrySetProperty(index, value))
        return;
      if (CoreProperties.TrySetProperty(index, value))
        return;
      if (StatisticProperties.TrySetProperty(index, value))
        return;
      throw new ArgumentException($"BuiltInProperty with name '{index}' does not exist.");
    }
  }

  /// <summary>
  /// Attempts to get the built-in property with the specified name. The method checks for the existence of the property in the core properties, content properties, and statistic properties, and returns true if found, along with the property value in the out parameter. If a property with the specified name does not exist in any of the subordinate properties, it returns false and sets the out parameter to null.
  /// </summary>
  /// <param name="index">The name of the built-in property.</param>
  /// <param name="property">When this method returns, contains the built-in property with the specified name, if found; otherwise, null.</param>
  /// <returns>True if the built-in property with the specified name is found; otherwise, false.</returns>
  public bool TryGetProperty(string index, out BuiltInProperty? property)
  {
    if (CoreProperties.TryGetProperty(index, out property))
      return true;
    if (ContentProperties.TryGetProperty(index, out property))
      return true;
    if (StatisticProperties.TryGetProperty(index, out property))
      return true;
    property = null!;
    return false;
  }

  /// <summary>
  /// Attempts to set the built-in property with the specified name. The method checks for the existence of the property in the core properties, content properties, and statistic properties, and updates the value if found, returning true. If a property with the specified name does not exist in any of the subordinate properties, it returns false.
  /// </summary>
  /// <param name="index">The name of the built-in property.</param>
  /// <param name="property">The built-in property to set.</param>
  /// <returns>True if the built-in property with the specified name is found and updated; otherwise, false.</returns>
  public bool TrySetProperty(string index, BuiltInProperty property)
  {
    if (CoreProperties.TrySetProperty(index, property))
      return true;
    if (ContentProperties.TrySetProperty(index, property))
      return true;
    if (StatisticProperties.TrySetProperty(index, property))
      return true;
    return false;
  }
}