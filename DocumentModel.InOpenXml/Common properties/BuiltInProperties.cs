using DocumentModel.Properties;

namespace DocumentModel;
/// <summary>
/// Collection of all document properties that is divided to several parts: core properties, 
/// content properties, and statistic properties. 
/// </summary>
[XmlRoot("BuiltInProperties", Namespace = "DocumentModel")]
public partial class BuiltInProperties : ModelElement, IElementCollection<BuiltInProperty>
{
  /// <summary>
  /// Provides access to the core properties of the document.
  /// </summary>
  public CoreProperties CoreProperties { get; private set; }
  /// <summary>
  /// Provides access to the content properties of the document.
  /// </summary>
  public ContentProperties ContentProperties { get; private set; }
  /// <summary>
  /// Provides access to the statistics properties of the document.
  /// </summary>
  public StatisticProperties StatisticProperties { get; private set; }

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
    foreach (var property in CoreProperties.KnownProperties.Values)
      Attach(CoreProperties, property);
    ContentProperties = document.ContentProperties;
    foreach (var property in ContentProperties.KnownProperties.Values)
      Attach(ContentProperties, property);
    StatisticProperties = document.StatisticProperties;
    foreach (var property in StatisticProperties.KnownProperties.Values)
      Attach(StatisticProperties, property);
  }

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
      var DocumentProperty = new BuiltInProperty
      {
        BaseObject = baseObject,
        PropertyInfo = propertyInfo,
        Name = propertyInfo.Name,
        Type = DocPropertyTypeExtensions.TypeMapping.FirstOrDefault(kv => kv.Value == propertyInfo.PropertyType).Key
      };
      //if (!((DMPr.DocPropertyType)DocumentProperty.Type!).IsCompatibleWith(propertyInfo.PropertyType))
      //  throw new InvalidOperationException("Property type mismatch.");
      Add(DocumentProperty);
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
  /// </summary>
  /// <returns></returns>
  public IEnumerator<BuiltInProperty> GetEnumerator()
  {
    foreach (var property in CoreProperties.Cast<BuiltInProperty>())
      yield return property;
    foreach (var property in ContentProperties.Cast<BuiltInProperty>())
      yield return property;
    foreach (var property in StatisticProperties.Cast<BuiltInProperty>())
      yield return property;
  }

  /// <summary>
  /// Returns an enumerator that iterates through the collection of built-in properties.
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
  /// <exception cref="NotImplementedException"></exception>
  public void CopyTo(BuiltInProperty[] array, int arrayIndex)
  {
    var tempList = CoreProperties.ToList();
    tempList.AddRange(ContentProperties);
    tempList.AddRange(StatisticProperties);
    if (array.Length - arrayIndex < tempList.Count)
      throw new ArgumentException("The destination array has insufficient space to copy the elements.");
    Array.Copy(tempList.ToArray(), 0, array, arrayIndex, tempList.Count);
  }

  /// <summary>
  /// Gets or sets the built-in property with the specified name. The indexer checks for the existence of the property in the core properties, content properties, and statistic properties, and returns or updates the value accordingly. If a property with the specified name does not exist in any of the subordinate properties, it throws an ArgumentException.
  /// </summary>
  /// <param name="index">The name of the built-in property.</param>
  /// <returns>The built-in property with the specified name.</returns>
  /// <exception cref="ArgumentException"></exception>
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
}