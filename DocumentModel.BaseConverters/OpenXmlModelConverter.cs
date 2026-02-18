namespace DocumentModel.OpenXml;

/// <summary>
/// Provides conversion methods for complex types between model objects and Open XML types.
/// </summary>
public static partial class OpenXmlModelConverter
{
  /// <summary>
  /// Represents a collection of delegates to convert a type from OpenXml.
  /// </summary>
  public static readonly Dictionary<Type, ConvertFromOpenXml> ConvertFromOpenDelegates = new();

  /// <summary>
  /// Represents a collection of delegates to convert a type to OpenXml.
  /// </summary>
  public static readonly Dictionary<Type, ConvertToOpenXml> ConvertToOpenDelegates = new();

  /// <summary>
  /// Converts a model object to an Open XML element of the specified type.
  /// </summary>
  /// <param name="modelObject">The model object to convert.</param>
  /// <param name="openXmlType">The target Open XML type.</param>
  /// <remarks>This method creates a new instance of the specified Open XML type and populates it with data from the model object.</remarks>
  /// <returns>The created Open XML element, or null if the input is null.</returns>
  public static object? ConvertTo(object? modelObject, Type openXmlType)
  {
    if (modelObject == null)
      return null;

    if (openXmlType.Name == "DigitalSignature") Debug.Assert(true);
    var modelType = modelObject.GetType().GetNotNullableType();
    if (modelType == openXmlType)
      return modelObject;
    if (ConvertToOpenDelegates.TryGetValue(modelType, out var convertToOpenXml) ||
        ConvertToOpenDelegates.TryGetValue(openXmlType, out convertToOpenXml))
      return convertToOpenXml(modelObject, openXmlType);
    if (openXmlType.IsEqualOrSubclassOf(typeof(DX.OpenXmlElement)))
      return OpenXmlElementConverter.ConvertTo(modelObject, openXmlType);
    if (SimpleValueConverter.TryConvertTo(modelObject, openXmlType, out var result))
      return result;

    var openXmlElement = Activator.CreateInstance(openXmlType)!;
    UpdateData(modelObject, openXmlElement, openXmlType);
    return openXmlElement;
  }

  /// <summary>
  /// Converts an OpenXML element to an instance of the specified model type.
  /// </summary>
  /// <remarks>The returned object is created using the default constructor of the specified model type. Ensure
  /// that <paramref name="modelType"/> has a public parameterless constructor and is compatible with the data in
  /// <paramref name="openXmlObject"/>.</remarks>
  /// <param name="openXmlObject">The OpenXML element to convert. Can be null.</param>
  /// <param name="modelType">The type of the model object to create and populate from the OpenXML element. Must not be null.</param>
  /// <returns>An object of the specified model type populated with data from the OpenXML element, or null if <paramref
  /// name="openXmlObject"/> is null.</returns>
  public static object? ConvertFrom(object? openXmlObject, Type modelType)
  {
    if (openXmlObject == null)
      return null;

    var openXmlType = openXmlObject.GetType().GetNotNullableType();
    if (modelType == openXmlType)
      return openXmlObject;
    if (modelType.IsAssignableFrom(openXmlObject.GetType()!))
      return openXmlObject;
    if (ConvertFromOpenDelegates.TryGetValue(modelType, out var convertFromOpenXml) ||
        ConvertFromOpenDelegates.TryGetValue(openXmlType, out convertFromOpenXml))
      return convertFromOpenXml(openXmlObject, modelType);
    if (SimpleValueConverter.TryConvertFrom(openXmlObject, modelType, out var result))
      return result;

    //if (openXmlObject is DX.OpenXmlElement openXmlElement)
    //  return OpenXmlElementConverter.ConvertFrom(openXmlElement, modelType);
    //if (openXmlObject is DX.OpenXmlSimpleType openXmlSimpleType)
    //  return SimpleValueConverter.ConvertFrom(openXmlSimpleType, modelType);
    var modelObject = Activator.CreateInstance(modelType)!;
    if (openXmlObject is DX.OpenXmlElement openXmlElement)
      LoadData(modelObject, openXmlElement, modelType);
    return modelObject;
  }

  /// <summary>
  /// Updates the properties of the specified model object by synchronizing their values with the corresponding Open XML
  /// element properties.
  /// </summary>
  /// <remarks>This method iterates through all public instance properties of the model object and updates each
  /// property using the provided Open XML element and type. All properties are processed individually. Ensure that the
  /// model object and Open XML element are compatible for synchronization.</remarks>
  /// <param name="modelObject">The model object whose properties will be updated based on the Open XML element. Cannot be null.</param>
  /// <param name="openXmlObject">The Open XML element or other object containing the data to synchronize with the model object. Cannot be null.</param>
  /// <param name="openXmlType">The type of the Open XML element used to determine property mapping.
  /// If null then type of <paramref name="openXmlObject"/> will be used.</param>
  public static void UpdateData(object modelObject, object openXmlObject, Type? openXmlType = null)
  {
    if (openXmlType == null)
      openXmlType = openXmlObject.GetType();
    var modelType = modelObject.GetType();
    var updateMethod = modelType.GetCustomAttribute<OpenXmlUpdateDataAttribute>()?.MethodName;
    if (updateMethod != null)
    {
      var methodInfo = modelType.GetMethod(updateMethod, [openXmlType]);
      if (methodInfo == null)
        throw new InvalidOperationException($"Update method {updateMethod} not found in type {modelType}");

      methodInfo.Invoke(modelObject, [openXmlObject]);
    }
    foreach (var modelProperty in modelType.GetModelProperties())
    {
      if (modelProperty.Name == "DigitalSignature") Debug.Assert(true);
      UpdateData(modelObject, modelProperty, openXmlObject, openXmlType);
    }
    if (openXmlObject is DX.OpenXmlElement openXmlElement &&
        modelType.GetCustomAttribute<OpenXmlItemAttribute>() != null)
    {
      UpdateElementCollection(modelObject, openXmlElement);
    }
  }

  /// <summary>
  /// Updates the value of a property on an Open XML element to match the value of a corresponding property on a model
  /// object.
  /// </summary>
  /// <param name="modelObject">The source object containing the property value to copy. Cannot be null.</param>
  /// <param name="modelProperty">The property on the model object whose value will be read and applied to the Open XML element. Cannot be null.</param>
  /// <param name="openXmlObject">The Open XML element or other object whose property will be updated. Cannot be null.</param>
  /// <param name="openXmlProperty">The property on the Open XML element to update. Cannot be null.</param>
  public static void UpdateOpenXmlProperty
    (object modelObject, PropertyInfo modelProperty, object openXmlObject, PropertyInfo openXmlProperty)
  {
    var openXmlType = openXmlObject.GetType();
    UpdateData(modelObject, modelProperty, openXmlObject, openXmlType);
  }

  /// <summary>
  /// Updates an Open XML element's property with the value from a model object's property.
  /// </summary>
  /// <param name="modelObject">The source model object.</param>
  /// <param name="modelProperty">The property from the model object.</param>
  /// <param name="openXmlObject">The target Open XML element or other object.</param>
  /// <param name="openXmlType">The type of the Open XML element.</param>
  public static void UpdateData(object modelObject, PropertyInfo modelProperty, object openXmlObject, Type openXmlType)
  {
    if (modelProperty.GetCustomAttribute<NotMappedAttribute>() != null)
      return;

    if (modelProperty.Name == "DigitalSignature") Debug.Assert(true);
    var openXmlProperty = OpenXmlPropertyMap.GetOpenXmlProperty(modelProperty, openXmlType);
    if (openXmlProperty is not null && openXmlProperty.CanWrite)
    {
      var modelValue = modelProperty.GetValue(modelObject);
      object? openXmlValue = null;
      if (modelValue != null && !openXmlProperty.PropertyType.IsInstanceOfType(modelValue))
      {
        openXmlValue = ConvertTo(modelValue, openXmlProperty.PropertyType);
      }
      openXmlProperty.SetValue(openXmlObject, openXmlValue);
      if (modelValue is IUpdatable updatable)
      {
        updatable.SetUpdatableElement(openXmlValue);
        if (openXmlValue != null)
          updatable.UpdateData(openXmlValue);
      }
      return;
    }
    if (modelProperty.Name == "LatentStyles") Debug.Assert(true);
    var updateDataMethod = OpenXmlPropertyMap.GetUpdateDataMethod(modelProperty, openXmlType);
    if (updateDataMethod != null)
    {
      var targetParameters = updateDataMethod.GetParameters();
      if (targetParameters.Length == 1)
      {
        //var value = modelProperty.ConvertToBool(modelObject);
        //if (value != null && !targetParameters[0].ParameterType.IsInstanceOfType(value))
        //{
        //  value = ConvertValue(value, targetParameters[0].ParameterType);
        //}
        updateDataMethod.Invoke(modelObject, [openXmlObject]);
        return;
      }
      throw new InvalidOperationException(
        $"Invalid number of parameters in method {updateDataMethod.DeclaringType}.{updateDataMethod.Name}");
    }
    if (modelProperty.Name == "LatentStyles") Debug.Assert(true);
    var openXmlElementAttribute = modelProperty.GetCustomAttribute<OpenXmlElementAttribute>();
    if (openXmlElementAttribute != null)
    {
      UpdateChildElement(modelObject, modelProperty, (DX.OpenXmlElement)openXmlObject, openXmlType,
        openXmlElementAttribute.OpenXmlType);
      return;
    }
    var openXmlElementCollectionAttribute = modelProperty.GetCustomAttribute<OpenXmlElementCollectionAttribute>();
    if (openXmlElementCollectionAttribute != null)
    {
      UpdateChildElementCollection(modelObject, modelProperty, (DX.OpenXmlElement)openXmlObject, openXmlType);
      return;
    }
  }

  /// <summary>
  /// Updates a child element of an Open XML element based on the value of a model object's property.
  /// </summary>
  /// <param name="modelObject">The source model object.</param>
  /// <param name="modelProperty">The property from the model object.</param>
  /// <param name="openXmlElement">The target Open XML element.</param>
  /// <param name="openXmlType">The type of the Open XML element.</param>
  /// <param name="openXmlChildType">The type of the Open XML child element.</param>
  /// <exception cref="InvalidOperationException">Thrown if the update fails.</exception>
  public static void UpdateChildElement
  (object modelObject, PropertyInfo modelProperty, DX.OpenXmlElement openXmlElement, Type openXmlType,
    Type? openXmlChildType)
  {
    if (openXmlChildType == null)
    {
      var modelPropertyType = modelProperty.PropertyType.GetNotNullableType();

      // If no specific openXmlChildType is provided, use the model property's type to determine the Open XML type.
      openXmlChildType = OpenXmlTypeMap.GetOpenXmlTypeForModelType(modelPropertyType);
      if (openXmlChildType == null)
        throw new InvalidOperationException($"No Open XML type mapping found " +
                                            $"for model property {modelProperty.Name} of type {modelPropertyType}");
    }
    var children = openXmlElement.ChildElements.Where(item => item.GetType() == openXmlChildType).ToArray();
    if (children.Length > 1)
      throw new InvalidOperationException($"Multiple child elements of type {openXmlChildType} " +
                                          $"found in Open XML element {openXmlType} for model property {modelProperty.Name}");

    foreach (var child in children)
      openXmlElement.RemoveChild(child);
    var modelValue = modelProperty.GetValue(modelObject);
    if (modelValue == null)
      return;
    if (openXmlChildType.IsSubclassOf(typeof(DXW.EmptyType)) && !modelValue.Equals(true))
      return;

    var openXmlChildElement = ConvertTo(modelValue, openXmlChildType);
    if (openXmlChildElement is not DX.OpenXmlElement o)
      throw new InvalidOperationException($"Converted Open XML child element " +
                                          $"is not of type DX.OpenXmlElement for model property {modelProperty.Name}");

    openXmlElement.AddChildUsingSchemaOrder(o);
    UpdateData(modelValue, openXmlChildElement);
  }

  /// <summary>
  /// You can use this method to update a collection of child elements in an Open XML element based on the values of a model object's property.
  /// </summary>
  /// <param name="modelObject">The source model object.</param>
  /// <param name="modelProperty">The property from the model object.</param>
  /// <param name="openXmlElement">The target Open XML element.</param>
  /// <param name="openXmlType">The type of the Open XML element.</param>
  /// <exception cref="InvalidOperationException">Thrown if the update fails.</exception>
  public static void UpdateChildElementCollection
    (object modelObject, PropertyInfo modelProperty, DX.OpenXmlElement openXmlElement, Type openXmlType)
  {
    var modelValue = modelProperty.GetValue(modelObject);
    if (modelValue == null)
      return;

    var modelPropertyType = modelProperty.PropertyType.GetNotNullableType();
    var collectionInterface = modelPropertyType.GetInterfaces()
      .FirstOrDefault(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(ICollection<>));
    if (collectionInterface == null)
      throw new InvalidOperationException($"Model property {modelProperty.Name} must be a collection of known type.");

    var modelItemType = collectionInterface.GetGenericArguments().FirstOrDefault();
    if (modelItemType == null)
      throw new InvalidOperationException($"No item type declared in {modelPropertyType}.");

    var openXmlChildType = OpenXmlTypeMap.GetOpenXmlTypeForModelType(modelItemType);
    if (openXmlChildType == null)
      throw new InvalidOperationException($"No Open XML type mapping found for type {modelItemType}");

    var children = openXmlElement.ChildElements.Where(item => item.GetType() == openXmlChildType).ToArray();
    foreach (var child in children)
      openXmlElement.RemoveChild(child);
    var modelElementsCollection = (IEnumerable<object>)modelValue;
    foreach (var modelElement in modelElementsCollection)
    {
      var openXmlChildElement = ConvertTo(modelElement, openXmlChildType);
      if (openXmlChildElement is not DX.OpenXmlElement o)
        throw new InvalidOperationException($"Converted Open XML child element is not of type DX.OpenXmlElement " +
                                            $"for model property {modelProperty.Name}");

      openXmlElement.AddChildUsingSchemaOrder(o);
    }
  }

  /// <summary>
  /// This method to updates a collection of child elements in an Open XML element
  /// based on the model object items. 
  /// </summary>
  /// <param name="modelObject">The source model object.</param>
  /// <param name="openXmlElement">The target Open XML element.</param>
  /// <exception cref="InvalidOperationException">Thrown if the update fails.</exception>
  public static void UpdateElementCollection(object modelObject, DX.OpenXmlElement openXmlElement)
  {
    var modelType = modelObject.GetType();
    var openXmlType = openXmlElement.GetType();
    var collectionInterface = modelType.GetInterfaces()
      .FirstOrDefault(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(ICollection<>));
    if (collectionInterface == null)
      throw new InvalidOperationException($"{modelType} must be a collection of known type.");

    var modelItemType = collectionInterface.GetGenericArguments().FirstOrDefault();
    if (modelItemType == null)
      throw new InvalidOperationException($"No item type declared in {modelType}.");

    var openXmlChildType = OpenXmlTypeMap.GetOpenXmlTypeForModelType(modelItemType) ??
                           modelType.GetCustomAttribute<OpenXmlItemAttribute>()?.Type;
    if (openXmlChildType == null)
      throw new InvalidOperationException($"No Open XML type mapping found for type {modelItemType}");

    var children = openXmlElement.ChildElements.Where(item => item.GetType() == openXmlChildType).ToArray();
    foreach (var child in children)
      openXmlElement.RemoveChild(child);
    var modelElementsCollection = (IEnumerable<object>)modelObject;
    foreach (var modelElement in modelElementsCollection)
    {
      var openXmlChildElement = ConvertTo(modelElement, openXmlChildType);
      if (openXmlChildElement is not DX.OpenXmlElement o)
        throw new InvalidOperationException($"Converted Open XML child element is not of a DX.OpenXmlElement");

      openXmlElement.AddChildUsingSchemaOrder(o);
    }
  }

  /// <summary>
  /// This dictionary defines the order of child elements for each Open XML element type,
  /// mapping parent types to their child types and the corresponding order index.
  /// </summary>
  private static readonly Dictionary<Type, Dictionary<Type, int>> ChildrenOrder = new();

  /// <summary>
  /// Registers the order of child elements for a given Open XML element type.
  /// </summary>
  /// <param name="openXmlType"></param>
  /// <param name="childTypes"></param>
  public static void RegisterChildrenOrder(Type openXmlType, Type[] childTypes)
  {
    if (!ChildrenOrder.ContainsKey(openXmlType))
    {
      var childOrders = new Dictionary<Type, int>();
      int propOrder = 0;
      foreach (var childType in childTypes)
      {
        childOrders[childType] = propOrder;
      }
      ChildrenOrder[openXmlType] = childOrders;
    }
  }

  ///// <summary>
  ///// Appends a child element to a parent Open XML element
  ///// while maintaining the correct order of child elements as defined in the Open XML schema.
  ///// </summary>
  ///// <param name="parentElement">The parent Open XML element.</param>
  ///// <param name="child">The child Open XML element to append.</param>
  //public static void AppendChildUsingOrder(this DX.OpenXmlElement parentElement, DX.OpenXmlElement child)
  //{
  //  if (child is DXW.DecimalSymbol) Debug.Assert(true);
  //  if (ChildrenOrder.TryGetValue(parentElement.GetType(), out var childOrders) &&
  //      childOrders.TryGetValue(child.GetType(), out var childOrder) && childOrder > 0)
  //  {
  //    var existingChild = parentElement.ChildElements.FirstOrDefault(c =>
  //    {
  //      var cType = c.GetType();
  //      if (child is DXW.DecimalSymbol && cType == typeof(DXO13W.ChartTrackingRefBased)) Debug.Assert(true);

  //      if (childOrders.TryGetValue(cType, out var order))
  //      {
  //        return order > childOrder;
  //      }
  //      return true;
  //    });
  //    if (existingChild != null)
  //    {
  //      parentElement.InsertBefore(child, existingChild);
  //      return;
  //    }
  //  }
  //  parentElement.AppendChild(child);
  //}

  /// <summary>
  /// Converts an Open XML element to a model object of the specified type.
  /// </summary>
  /// <param name="openXmlObject">The Open XML element or other object to convert from.</param>
  /// <param name="modelType">The target model type.</param>
  /// <returns>The created model object, or null if the input is null.</returns>
  public static object? ConvertFromOpenXml(object? openXmlObject, Type modelType)
  {
    if (openXmlObject == null)
      return null;

    var openXmlType = openXmlObject.GetType();
    var modelObject = Activator.CreateInstance(modelType)!;
    LoadData(modelObject, openXmlObject, modelType);
    return modelObject;
  }

  /// <summary>
  /// Populates the properties of a model object with data from an Open XML element using the specified model type.
  /// </summary>
  /// <remarks>This method iterates over all public, writable properties of the specified model type and
  /// attempts to load corresponding data from the Open XML element into the model object. Only properties that can be
  /// written to are affected.</remarks>
  /// <param name="modelObject">The instance of the model object whose properties are to be populated. Must not be null.</param>
  /// <param name="openXmlObject">The Open XML element or other object that provides the source data. Must not be null.</param>
  /// <param name="modelType">The type that defines the properties to be populated on the model object. Must not be null and should match the
  /// type of modelObject.</param>
  public static void LoadData(object modelObject, object openXmlObject, Type modelType)
  {
    var openXmlType = openXmlObject.GetType();
    foreach (var modelProperty in modelType.GetModelProperties())
    {
      LoadData(modelObject, modelProperty, openXmlObject, openXmlType);
    }
    if (openXmlObject is DX.OpenXmlElement openXmlElement &&
        modelType.GetCustomAttribute<OpenXmlItemAttribute>() != null)
    {
      LoadElementCollection(modelObject, openXmlElement, openXmlType);
    }
  }

  /// <summary>
  /// Loads data from an Open XML element into a model object's property.
  /// </summary>
  /// <param name="modelObject">The target model object.</param>
  /// <param name="modelProperty">The property to set on the model object.</param>
  /// <param name="openXmlObject">The source Open XML element or other object.</param>
  /// <param name="openXmlType">The type of the Open XML element.</param>
  public static void LoadData(object modelObject, PropertyInfo modelProperty, object openXmlObject, Type openXmlType)
  {
    if (modelProperty.Name == "HeadingPairs") Debug.Assert(true);
    var openXmlProperty = OpenXmlPropertyMap.GetOpenXmlProperty(modelProperty, openXmlType);
    if (openXmlProperty is not null && openXmlProperty.CanRead)
    {
      var openXmlValue = openXmlProperty.GetValue(openXmlObject);
      if (openXmlValue != null && !modelProperty.PropertyType.IsInstanceOfType(openXmlValue))
      {
        var modelPropertyType = modelProperty.PropertyType.GetNotNullableType();
        var modelValue = ConvertFrom(openXmlValue, modelPropertyType);
        if (modelValue != null && !modelPropertyType.IsInstanceOfType(modelValue))
        {
          modelValue = SimpleValueConverter.ConvertFrom(modelValue, modelPropertyType);
        }
        modelValue = ConvertValue(modelValue, modelPropertyType);
        modelProperty.SetValue(modelObject, modelValue);
      }
      return;
    }
    var getMappedMethod = OpenXmlPropertyMap.GetLoadDataMethod(modelProperty, openXmlType);
    if (getMappedMethod != null)
    {
      var targetParameters = getMappedMethod.GetParameters();
      if (getMappedMethod.DeclaringType == modelObject.GetType() ||
          modelObject.GetType().IsEqualOrSubclassOf(getMappedMethod.DeclaringType!))
      {
        getMappedMethod.Invoke(modelObject, [openXmlObject]);
      }
      return;
    }
    var openXmlElementAttribute = modelProperty.GetCustomAttribute<OpenXmlElementAttribute>();
    if (openXmlElementAttribute != null)
    {
      LoadChildElement(modelObject, modelProperty, (DX.OpenXmlElement)openXmlObject, openXmlType,
        openXmlElementAttribute.OpenXmlType);
      return;
    }
    var openXmlElementCollectionAttribute = modelProperty.GetCustomAttribute<OpenXmlElementCollectionAttribute>();
    if (openXmlElementCollectionAttribute != null)
    {
      LoadChildElementCollection(modelObject, modelProperty, (DX.OpenXmlElement)openXmlObject, openXmlType);
      return;
    }
  }

  /// <summary>
  /// Loads a child element from an Open XML element into a model object's property, based on the specified Open XML type and child type.
  /// </summary>
  /// <param name="modelObject">The model object to load the child element into.</param>
  /// <param name="modelProperty">The model property to set the value of.</param>
  /// <param name="openXmlElement">The Open XML element to load the child element from.</param>
  /// <param name="openXmlType">The Open XML type of the element.</param>
  /// <param name="openXmlChildType">The Open XML child type of the element.</param>
  /// <exception cref="InvalidOperationException"></exception>
  public static void LoadChildElement
  (object modelObject, PropertyInfo modelProperty, DX.OpenXmlElement openXmlElement, Type openXmlType,
    Type? openXmlChildType)
  {
    var modelPropertyType = modelProperty.PropertyType.GetNotNullableType();
    if (openXmlChildType == null)
    {
      // If no specific openXmlChildType is provided, use the model property's type to determine the Open XML type.
      openXmlChildType = OpenXmlTypeMap.GetOpenXmlTypeForModelType(modelPropertyType);
      if (openXmlChildType == null)
        throw new InvalidOperationException($"No Open XML type mapping found " +
                                            $"for model property {modelProperty.Name} of type {modelPropertyType}");
    }
    var children = openXmlElement.ChildElements.Where(item => item.GetType() == openXmlChildType).ToArray();
    if (children.Length > 1)
      throw new InvalidOperationException($"Multiple child elements of type {openXmlChildType} " +
                                          $"found in Open XML element {openXmlType} for model property {modelProperty.Name}");

    foreach (var childElement in children)
    {
      var modelValue = ConvertFrom(childElement, modelPropertyType);
      if (modelValue != null && !modelPropertyType.IsInstanceOfType(modelValue))
        throw new InvalidOperationException(
          $"Converted value {modelValue} is not of type {modelPropertyType} for model property {modelProperty.Name}");

      modelProperty.SetValue(modelObject, modelValue);
      return;
    }
  }

  /// <summary>
  /// Loads a collection of child elements from an Open XML element into a model object's property, based on the specified Open XML type.
  /// </summary>
  /// <param name="modelObject">The model object to load the child elements into.</param>
  /// <param name="modelProperty">The model property to set the value of.</param>
  /// <param name="openXmlElement">The Open XML element to load the child elements from.</param>
  /// <param name="openXmlType">The Open XML type of the element.</param>
  /// <exception cref="InvalidOperationException"></exception>
  public static void LoadChildElementCollection
    (object modelObject, PropertyInfo modelProperty, DX.OpenXmlElement openXmlElement, Type openXmlType)
  {
    var modelPropertyType = modelProperty.PropertyType.GetNotNullableType();
    var collectionInterface = modelPropertyType.GetInterfaces()
      .FirstOrDefault(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(ICollection<>));
    if (collectionInterface == null)
      throw new InvalidOperationException($"Model property {modelProperty.Name} is not a collection.");

    var modelItemType = collectionInterface.GetGenericArguments().FirstOrDefault();
    if (modelItemType == null)
      throw new InvalidOperationException($"No item type declared in {modelPropertyType}.");

    var openXmlChildType = OpenXmlTypeMap.GetOpenXmlTypeForModelType(modelItemType);
    if (openXmlChildType == null)
      throw new InvalidOperationException($"No Open XML type mapping found for type {modelItemType}");

    var modelAddMethod = modelPropertyType.GetMethod("Add", [modelItemType]);
    if (modelAddMethod == null)
      throw new InvalidOperationException($"No Add method found in collection type {modelPropertyType}");

    var modelClearMethod = modelPropertyType.GetMethod("Clear", []);
    if (modelClearMethod == null)
      throw new InvalidOperationException($"No Clear method found in collection type {modelPropertyType}");

    object? modelValue = modelProperty.GetValue(modelObject);
    if (modelValue != null)
      modelClearMethod.Invoke(modelValue, []);
    if (modelProperty.Name == "AttachedSchemas") Debug.Assert(true);
    var children = openXmlElement.ChildElements.Where(item => item.GetType() == openXmlChildType).ToArray();
    foreach (var openXmlChildElement in children)
    {
      var modelItem = ConvertFrom(openXmlChildElement, modelItemType);
      if (modelItem != null && !modelItemType.IsInstanceOfType(modelItem))
        throw new InvalidOperationException($"Converted model Item is not compatible to {modelItemType}");

      if (modelValue == null)
        modelValue = Activator.CreateInstance(modelPropertyType)!;
      modelAddMethod.Invoke(modelValue, [modelItem]);
    }
    if (modelValue != null)
      modelProperty.SetValue(modelObject, modelValue);
  }

  /// <summary>
  /// Loads a collection of child elements from an Open XML element into a model object,
  /// based on the specified Open XML type.
  /// </summary>
  /// <param name="modelObject">The model object to load the child elements into.</param>
  /// <param name="openXmlElement">The Open XML element to load the child elements from.</param>
  /// <param name="openXmlType">The Open XML type of the element.</param>
  /// <exception cref="InvalidOperationException"></exception>
  public static void LoadElementCollection(object modelObject, DX.OpenXmlElement openXmlElement, Type openXmlType)
  {
    var modelType = modelObject.GetType();
    var collectionInterface = modelType.GetInterfaces()
      .FirstOrDefault(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(ICollection<>));
    if (collectionInterface == null)
      throw new InvalidOperationException($"{modelType} must be a collection of known type.");

    var modelItemType = collectionInterface.GetGenericArguments().FirstOrDefault();
    if (modelItemType == null)
      throw new InvalidOperationException($"No item type declared in {modelType}.");

    var openXmlChildType = OpenXmlTypeMap.GetOpenXmlTypeForModelType(modelItemType) ??
                           modelType.GetCustomAttribute<OpenXmlItemAttribute>()?.Type;
    if (openXmlChildType == null)
      throw new InvalidOperationException($"No Open XML type mapping found for type {modelItemType}");

    var modelAddMethod = modelType.GetMethod("Add", [modelItemType]);
    if (modelAddMethod == null)
      throw new InvalidOperationException($"No Add method found in collection type {modelType}");

    var modelClearMethod = modelType.GetMethod("Clear", []);
    if (modelClearMethod == null)
      throw new InvalidOperationException($"No Clear method found in collection type {modelType}");

    modelClearMethod.Invoke(modelObject, []);
    var children = openXmlElement.ChildElements.Where(item => item.GetType() == openXmlChildType).ToArray();
    foreach (var openXmlChildElement in children)
    {
      var modelItem = ConvertFrom(openXmlChildElement, modelItemType);
      if (modelItem != null && !modelItemType.IsInstanceOfType(modelItem))
        throw new InvalidOperationException($"Converted model Item is not compatible to {modelItemType}");

      modelAddMethod.Invoke(modelObject, [modelItem]);
    }
  }

  /// <summary>
  /// Converts a value to the specified target type, handling special cases such as Guid and string.
  /// </summary>
  /// <param name="value">The value to convert.</param>
  /// <param name="targetType">The target type.</param>
  /// <returns>The converted value, or the original value if already compatible.</returns>
  public static object? ConvertValue(object? value, Type targetType)
  {
    targetType = targetType.GetNotNullableType();
    if (value != null && !value.GetType().IsAssignableFrom(targetType))
    {
      if (value is string stringValue)
      {
        if (targetType == typeof(Guid))
        {
          if (Guid.TryParse(stringValue, out var guidValue))
          {
            return guidValue;
          }
          else
          {
            throw new FormatException($"Invalid GUID format: {stringValue}");
          }
        }
      }
      if (value is Variant variant && targetType == typeof(DX.OpenXmlElement))
        return VariantConverter.CreateOpenXmlElement(variant);
      if (value is DX.OpenXmlElement openXmlVariant && targetType == typeof(Variant))
        return VariantConverter.GetVariant(openXmlVariant);
      if (value is string uriString && targetType == typeof(Uri))
        return new Uri(uriString);
      if (value is Uri uri && targetType == typeof(string))
        return uri.ToString();

      return Convert.ChangeType(value, targetType);
    }
    return value;
  }

  /// <summary>
  /// Gets the writable model properties of the specified OpenXML type.
  /// </summary>
  /// <param name="modelType">The model type to search for properties</param>
  /// <returns>Array of writable model properties</returns>
  /// <remarks>Properties with NotMappedAttribute will be ignored</remarks>
  public static PropertyInfo[] GetModelProperties(this Type modelType)
  {
    return modelType.GetProperties(BindingFlags.Public | BindingFlags.Instance).Where(prop =>
      prop.GetIndexParameters().Length == 0 && prop.CanWrite &&
      !prop.GetCustomAttributes(typeof(NotMappedAttribute), true).Any()).ToArray();
  }

  /// <summary>
  /// Gets the writable OpenXML properties of the specified OpenXML type.
  /// </summary>
  /// <param name="openXmlType">The OpenXML type to search for properties</param>
  /// <returns>Array of writable OpenXML properties</returns>
  /// <remarks>Properties declared in DX.OpenXmlElement are ignored</remarks>
  public static PropertyInfo[] GetOpenXmlProperties(this Type openXmlType)
  {
    return openXmlType.GetProperties(BindingFlags.Public | BindingFlags.Instance).Where(prop =>
        prop.GetIndexParameters().Length == 0 && prop.CanWrite && prop.DeclaringType != typeof(DX.OpenXmlElement))
      .ToArray();
  }
}