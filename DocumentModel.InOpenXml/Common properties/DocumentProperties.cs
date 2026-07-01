namespace DocumentModel;

/// <summary>
/// Collection of all document properties that is divided to built-in properties and custom properties.
/// </summary>
[DataContract]
[XmlRoot("DocumentProperties", Namespace = "DocumentModel")]
[JsonConverter(typeof(DocumentPropertiesJsonConverter))]
public partial class DocumentProperties : ModelElement, IWordprocessingDocumentAware,
  IElementCollection<DocumentProperty>
{

  /// <summary>
  /// Default constructor. Initializes an empty collection of built-in properties without associating it with any document.
  /// </summary>
  public DocumentProperties()
  {
    BuiltInProperties = new BuiltInProperties();
    CustomProperties = new CustomProperties();
  }

  /// <summary>
  /// Initializing constructor. Initializes the properties based on the provided document.
  /// </summary>
  /// <param name = "document">The document from which to initialize the properties.</param>
  public DocumentProperties(DMW.Document document)
  {
    BuiltInProperties = document.BuiltInProperties;
    CustomProperties = document.CustomProperties;
  }

  /// <summary>
  /// Gets the associated WordprocessingDocument.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public DXPP.WordprocessingDocument? WordprocessingDocument
  {
    [DebuggerStepThrough]
    get;
    [DebuggerStepThrough]
    private set;
  }

  /// <summary>
  /// Attaches the DocumentProperties to the provided WordprocessingDocument. This method sets the WordprocessingDocument property to the provided document, allowing the DocumentProperties to interact with the document's properties and metadata. It does not perform any loading or updating of properties; it simply establishes the association between the DocumentProperties and the WordprocessingDocument.
  /// </summary>
  /// <param name="wordprocessingDocument">The WordprocessingDocument to attach to the DocumentProperties.</param>
  public void Attach(DXPP.WordprocessingDocument wordprocessingDocument)
  {
    WordprocessingDocument = wordprocessingDocument;

  }

  /// <summary>
  /// Attaches the DocumentProperties to the provided WordprocessingDocument and loads the properties from the document. This method sets the WordprocessingDocument property to the provided document and then calls the AttachAndLoad method on both the BuiltInProperties and CustomProperties collections, allowing them to load their respective properties from the document. This establishes the association between the DocumentProperties and the WordprocessingDocument and populates the properties based on the document's current state.
  /// </summary>
  /// <param name="wordprocessingDocument">The WordprocessingDocument to attach and load the properties from.</param>
  public void AttachAndLoad(DXPP.WordprocessingDocument wordprocessingDocument)
  {
    WordprocessingDocument = wordprocessingDocument;
    BuiltInProperties.AttachAndLoad(wordprocessingDocument);
    CustomProperties.AttachAndLoad(wordprocessingDocument);
  }

  /// <summary>
  /// Attaches the DocumentProperties to the provided WordprocessingDocument and updates the properties based on the current state of the document. This method sets the WordprocessingDocument property to the provided document and then calls the AttachAndUpdate method on both the BuiltInProperties and CustomProperties collections, allowing them to update their respective properties based on any changes that may have occurred in the document since it was last loaded or attached. This ensures that the properties in the DocumentProperties collection reflect the most up-to-date information from the WordprocessingDocument.
  /// </summary>
  /// <param name="wordprocessingDocument">The WordprocessingDocument to attach and update the properties in.</param>
  void IWordprocessingDocumentAware.AttachAndUpdate(DXPP.WordprocessingDocument wordprocessingDocument)
  {
    WordprocessingDocument = wordprocessingDocument;
    BuiltInProperties.AttachAndUpdate(wordprocessingDocument);
    CustomProperties.AttachAndUpdate(wordprocessingDocument);
  }

  /// <summary>
  /// Detaches the DocumentProperties from the associated WordprocessingDocument. This method sets the WordprocessingDocument property to null, effectively breaking the association between the DocumentProperties and any WordprocessingDocument. It also calls the Detach method on both the BuiltInProperties and CustomProperties collections, allowing them to perform any necessary cleanup or disassociation from the document's properties. After calling this method, the DocumentProperties will no longer be linked to any WordprocessingDocument, and its properties will not reflect any changes in a document until it is attached again.
  /// </summary>
  void IWordprocessingDocumentAware.Detach()
  {
    WordprocessingDocument = null;
    BuiltInProperties.Detach();
    CustomProperties.Detach();
  }

  /// <summary>
  /// Provides access to the core properties of the document.
  /// </summary>
  public BuiltInProperties BuiltInProperties
  {
    [DebuggerStepThrough]
    get;
    [DebuggerStepThrough]
    private set;
  }

  /// <summary>
  /// Provides access to the custom properties of the document.
  /// </summary>
  public CustomProperties CustomProperties
  {
    [DebuggerStepThrough]
    get;
    [DebuggerStepThrough]
    private set;
  }

  /// <summary>
  /// Clears all built-in properties from the collection by clearing the core, content, and statistic properties.
  /// </summary>
  public void Clear()
  {
    BuiltInProperties.Clear();
    CustomProperties.Clear();
  }

  /// <summary>
  /// Attempts to add a document property to the collection. The method checks if the provided document property is a built-in property or a custom property and attempts to add it to the corresponding collection. If the property is successfully added, it returns true; otherwise, it returns false. This method allows for flexible addition of properties to the DocumentProperties collection while ensuring that they are categorized correctly based on their type (built-in or custom).
  /// </summary>
  /// <param name="documentProperty">The document property to add.</param>
  /// <returns>True if the property was successfully added; otherwise, false.</returns>
  public bool TryAdd(DocumentProperty documentProperty)
  {
    if (documentProperty is BuiltInProperty builtInProperty)
    {
      if (builtInProperty.Name != null)
      {
        return BuiltInProperties.TryAdd(builtInProperty);
      }
    }
    if (documentProperty is CustomProperty customProperty)
    {
      if (customProperty.Name != null)
      {
        return CustomProperties.TryAdd(customProperty);
      }
    }
    return false;
  }

  /// <summary>
  /// Adds a document property to the collection. The method checks if the provided document property is a built-in property or a custom property and adds it to the corresponding collection. If the property is a built-in property, it is added to the BuiltInProperties collection; if it is a custom property, it is added to the CustomProperties collection. If the property does not have a name or if it is not of a recognized type, an InvalidOperationException is thrown. This method ensures that properties are added to the correct collection based on their type and that they have valid names before being added to the DocumentProperties collection.
  /// </summary>
  /// <param name="documentProperty">The document property to add.</param>
  /// <exception cref="InvalidOperationException">Thrown when the document property does not have a name or is not of a recognized type.</exception>
  public void Add(DocumentProperty documentProperty)
  {
    if (documentProperty is BuiltInProperty builtInProperty)
    {
      if (builtInProperty.Name != null)
      {
        if (!BuiltInProperties.TryAdd(builtInProperty))
        {
          var newCustomProperty = new CustomProperty
          {
            Name = builtInProperty.Name,
            ValueType = builtInProperty.ValueType,
            Value = builtInProperty.Value,
          };
          CustomProperties.Add(newCustomProperty);
        }
      }
      else
        throw new InvalidOperationException($"BuiltInProperty must have a name.");
    }
    if (documentProperty is CustomProperty customProperty)
    {
      if (customProperty.Name != null)
      {
        CustomProperties.Add(customProperty);
      }
      else
        throw new InvalidOperationException($"CustomProperty must have a name.");
    }
  }

  /// <summary>
  /// Determines whether the collection contains a specific document property. The method checks if the provided document property is a built-in property or a custom property and checks for its existence in the corresponding collection. If the property is found in the appropriate collection, it returns true; otherwise, it returns false. If the property does not have a name or if it is not of a recognized type, an InvalidOperationException is thrown. This method allows for efficient checking of the presence of properties in the DocumentProperties collection while ensuring that they are categorized correctly based on their type (built-in or custom).
  /// </summary>
  /// <param name="documentProperty">The document property to check for existence in the collection.</param>
  /// <returns>True if the document property exists in the collection; otherwise, false.</returns>
  /// <exception cref="InvalidOperationException">Thrown when the document property does not have a name or is not of a recognized type.</exception>
  public bool Contains(DocumentProperty documentProperty)
  {
    if (documentProperty is BuiltInProperty builtInProperty)
    {
      if (builtInProperty.Name != null)
      {
        return BuiltInProperties.Contains(builtInProperty);
      }
      throw new InvalidOperationException($"BuiltInProperty must have a name.");
    }
    if (documentProperty is CustomProperty customProperty)
    {
      if (customProperty.Name != null)
      {
        return CustomProperties.Contains(customProperty);
      }
      throw new InvalidOperationException($"CustomProperty must have a name.");
    }
    return false;
  }

  /// <summary>
  /// Removes a specific document property from the collection. The method checks if the provided document property is a built-in property or a custom property and attempts to remove it from the corresponding collection. If the property is successfully removed, it returns true; otherwise, it returns false. If the property does not have a name or if it is not of a recognized type, an InvalidOperationException is thrown. This method allows for efficient removal of properties from the DocumentProperties collection while ensuring that they are categorized correctly based on their type (built-in or custom) and that they have valid names before being removed.
  /// </summary>
  /// <param name="documentProperty">The document property to remove from the collection.</param>
  /// <returns>True if the document property was successfully removed; otherwise, false.</returns>
  /// <exception cref="InvalidOperationException">Thrown when the document property does not have a name or is not of a recognized type.</exception>
  public bool Remove(DocumentProperty documentProperty)
  {
    if (documentProperty is BuiltInProperty builtInProperty)
    {
      if (builtInProperty.Name != null)
      {
        return BuiltInProperties.Remove(builtInProperty);
      }
      throw new InvalidOperationException($"BuiltInProperty must have a name.");
    }
    if (documentProperty is CustomProperty customProperty)
    {
      if (customProperty.Name != null)
      {
        return CustomProperties.Remove(customProperty);
      }
      throw new InvalidOperationException($"CustomProperty must have a name.");
    }
    return false;
  }

  /// <summary>
  /// Gets the number of document properties in the collection. This property returns the total count of document properties by summing the counts of both built-in properties and custom properties. It provides a convenient way to determine how many properties are currently stored in the DocumentProperties collection, regardless of their type (built-in or custom).
  /// </summary>
  public int Count => BuiltInProperties.Count + CustomProperties.Count;

  /// <summary>
  /// Indicates whether the collection of built-in properties is read-only.
  /// In this implementation, the collection is not read-only, so it returns false.
  /// </summary>
  public bool IsReadOnly => false;

  /// <summary>
  /// Returns an enumerator that iterates through the collection of document properties. This method combines the built-in properties and custom properties into a single sequence and returns an enumerator that can be used to iterate through all the properties in the DocumentProperties collection. It uses yield return to lazily iterate through the properties, allowing for efficient enumeration without the need to create a separate list or array to hold all the properties at once. The enumerator will first return all the built-in properties followed by all the custom properties, providing a unified view of all document properties in the collection.
  /// </summary>
  /// <returns>An enumerator that can be used to iterate through the collection of document properties.</returns>
  public IEnumerator<DocumentProperty> GetEnumerator()
  {
    foreach (var property in BuiltInProperties)
      if (property.Value != null)
        yield return property;

    foreach (var property in CustomProperties)
      if (property.Value != null)
        yield return property;
  }

  /// <summary>
  /// Returns an enumerator that iterates through the collection of document properties. This is a non-generic version of the GetEnumerator method that allows for iteration using the non-generic IEnumerable interface. It simply calls the generic GetEnumerator method and returns its result, enabling compatibility with older code or APIs that expect a non-generic enumerator.
  /// </summary>
  /// <returns></returns>
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
      BuiltInProperties.CollectionChanged += value;
      CustomProperties.CollectionChanged += value;
    }
    remove
    {
      BuiltInProperties.CollectionChanged -= value;
      CustomProperties.CollectionChanged -= value;
    }
  }

  /// <summary>
  /// Copies the elements of the collection to an array, starting at a particular array index. This method first converts the collection of document properties into a list and checks if the destination array has sufficient space to accommodate all the properties starting from the specified index. If there is enough space, it uses Array.Copy to copy the properties from the list to the destination array. If there is not enough space in the destination array, it throws an ArgumentException indicating that the array does not have sufficient space to copy the elements. This method allows for efficient copying of the document properties into an array for further processing or manipulation.
  /// </summary>
  /// <param name="array">The destination array.</param>
  /// <param name="arrayIndex">The zero-based index in the array at which copying begins.</param>
  /// <exception cref="ArgumentException">Thrown when the destination array has insufficient space to copy the elements.</exception>
  public void CopyTo(DocumentProperty[] array, int arrayIndex)
  {
    var tempList = this.ToList();
    if (array.Length - arrayIndex < tempList.Count)
      throw new ArgumentException("The destination array has insufficient space to copy the elements.");

    Array.Copy(tempList.ToArray(), 0, array, arrayIndex, tempList.Count);
  }

  /// <summary>
  /// Provides indexed access to the document properties in the collection. The indexer allows you to get or set a document property by its name. When getting a property, it first checks if the property exists in the built-in properties collection; if found, it returns that property. If not found in the built-in properties, it checks the custom properties collection and returns it if found. If the property is not found in either collection, it throws an ArgumentException indicating that a DocumentProperty with the specified name does not exist. When setting a property, it checks if the provided value is a built-in property or a custom property and attempts to set it in the corresponding collection. If the property is successfully set, it returns; otherwise, it throws an ArgumentException indicating that a DocumentProperty with the specified name does not exist. This indexer provides a convenient way to access and modify document properties by their names while ensuring that they are categorized correctly based on their type (built-in or custom).
  /// </summary>
  /// <param name="index">The name of the document property.</param>
  /// <returns>The document property with the specified name.</returns>
  /// <exception cref="ArgumentException">Thrown when a document property with the specified name does not exist.</exception>
  public DocumentProperty this[string index]
  {
    get
    {
      if (BuiltInProperties.TryGetProperty(index, out var builtInProperty) && builtInProperty != null)
        return builtInProperty;
      if (CustomProperties.TryGetProperty(index, out var customProperty) && customProperty != null)
        return customProperty;

      throw new ArgumentException($"DocumentProperty with name '{index}' does not exist.");
    }
    set
    {
      if (value is BuiltInProperty builtInProperty)
        if (BuiltInProperties.TrySetProperty(index, builtInProperty))
          return;

      if (value is CustomProperty customProperty)
        if (CustomProperties.TrySetProperty(index, customProperty))
          return;

      throw new ArgumentException($"DocumentProperty with name '{index}' does not exist.");
    }
  }

  /// <summary>
  /// Attempts to get a document property by its name. The method first checks if a property with the specified name exists in the built-in properties collection; if found, it returns that property and true. If not found in the built-in properties, it checks the custom properties collection and returns it if found along with true. If the property is not found in either collection, it sets the output parameter to null and returns false. This method provides a safe way to access document properties by their names without throwing exceptions when a property does not exist, allowing for more flexible handling of property retrieval in the DocumentProperties collection.
  /// </summary>
  /// <param name="index">The name of the document property.</param>
  /// <param name="property">When this method returns, contains the document property with the specified name, if found; otherwise, null.</param>
  /// <returns>True if the document property with the specified name is found; otherwise, false.</returns>
  public bool TryGetProperty(string index, out DocumentProperty? property)
  {
    if (BuiltInProperties.TryGetProperty(index, out var builtInProperty) && builtInProperty != null)
    {
      property = builtInProperty;
      return true;
    }
    if (CustomProperties.TryGetProperty(index, out var customProperty) && customProperty != null)
    {
      property = customProperty;
      return true;
    }
    property = null!;
    return false;
  }

}