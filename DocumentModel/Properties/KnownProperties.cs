namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
/// Collection of known document properties, i.e. document properties which can be included in the document
/// </summary>
public class KnownProperties : Dictionary<string, PropertyModel>
{

  public KnownProperties(Type type)
  {
    var typeProperties = DiscoverProperties(type);
    foreach (var item in typeProperties)
    {
      Add(item);
    }
  }


  /// <summary>
  /// Provides a cache of property information for known types, organized by type and property name.
  /// </summary>
  /// <remarks>This dictionary enables efficient lookup of property metadata for types that have been previously
  /// processed. It is intended for internal use to avoid repeated reflection operations when accessing property
  /// information.</remarks>
  static readonly Dictionary<Type, Dictionary<string, PropertyModel>> _knownTypeProperties = new();

  /// <summary>
  /// Retrieves a dictionary of known public properties for the specified object instance.
  /// </summary>
  /// <param name="obj">The object whose public properties are to be retrieved. Cannot be null.</param>
  /// <returns>A dictionary mapping property names to their corresponding <see cref="PropertyModel"/> objects for the specified
  /// object's type. The dictionary is empty if the object has no public properties.</returns>
  private static Dictionary<string, PropertyModel> DiscoverProperties(object obj)
  {
    return DiscoverProperties(obj.GetType());
  }

  /// <summary>
  /// Retrieves a dictionary of public properties for the specified type, keyed by property name.
  /// </summary>
  /// <remarks>The returned dictionary is cached for each type to improve performance on subsequent calls. Only
  /// public properties are included. If the type has no public properties, the returned dictionary will be
  /// empty.</remarks>
  /// <param name="ofType">The type whose public properties are to be retrieved. Cannot be null.</param>
  /// <returns>A dictionary containing the public properties of the specified type, with property names as keys and their
  /// corresponding <see cref="PropertyModel"/> objects as values.</returns>
  private static Dictionary<string, PropertyModel> DiscoverProperties(Type ofType)
  {
    if (!_knownTypeProperties.TryGetValue(ofType, out var _properties))
    {
      _properties = ofType.GetProperties()
        .Where(item => item.Name != "Count" || item.Name != "IsReadOnly")
        .ToDictionary(item => item.Name, item => new PropertyModel(item));
      _knownTypeProperties.Add(ofType, _properties);
    }
    return _properties;
  }

  ///// <summary>
  ///// Retrieves a dictionary of property names and their corresponding <see cref="PropertyModel"/> objects for the
  ///// current instance's type.
  ///// </summary>
  ///// <returns>A dictionary containing the names and <see cref="PropertyModel"/> objects of all known properties for the current
  ///// object's type. The dictionary keys are property names.</returns>
  //public Dictionary<string, PropertyModel> GetKnownProperties()
  //{
  //  return GetKnownProperties(this.GetType());
  //}

  /// <summary>
  /// Adds the specified item to the collection if it is a supported type. Needed to implement non-generic ICollection interface.
  /// </summary>
  /// <remarks>If the specified item is not of a supported type, the method performs no action.</remarks>
  /// <param name="item">The object to add to the collection. Must be of a supported type, such as a DocumentProperty.</param>
  public void Add(object item)
  {
    if (item is DocumentProperty documentProperty)
      Add(documentProperty);
  }
}