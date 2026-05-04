namespace DocumentModel.OpenXml;

/// <summary>
/// Provides conversion methods for complex types between model objects and Open XML types.
/// </summary>
public static partial class OpenXmlModelConverter
{

  /// <summary>
  /// Represents a collection of delegates to convert a type from OpenXml.
  /// </summary>
  public static readonly Dictionary<Type, ConvertFromOpenXml> ConvertFromOpenXmlDelegates = new();

  /// <summary>
  /// Represents a collection of delegates to convert a type to OpenXml.
  /// </summary>
  public static readonly Dictionary<Type, ConvertToOpenXml> ConvertToOpenXmlDelegates = new();

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

    if (openXmlType == typeof(DXD.Dark1Color)) Debug.Assert(true);
    var modelType = modelObject.GetType().GetNotNullableType();
    if (modelType == openXmlType)
      return modelObject;

    if (ConvertToOpenXmlDelegates.TryGetValue(modelType, out var convertToOpenXml) ||
        ConvertToOpenXmlDelegates.TryGetValue(openXmlType, out convertToOpenXml))
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
  /// Generic version of ConvertTo that converts a model object to an Open XML element of the specified type.
  /// </summary>
  /// <typeparam name="ModelElementType"></typeparam>
  /// <typeparam name="OpenXmlElementType"></typeparam>
  /// <param name="modelObject"></param>
  /// <returns></returns>
  public static OpenXmlElementType? ConvertTo<ModelElementType, OpenXmlElementType>(ModelElementType? modelObject) 
  {
    if (modelObject == null)
      return default;

    var modelType = typeof(ModelElementType).GetNotNullableType();
    var openXmlType = typeof(OpenXmlElementType).GetNotNullableType();

    if (ConvertToOpenXmlDelegates.TryGetValue(modelType, out var convertToOpenXml) ||
        ConvertToOpenXmlDelegates.TryGetValue(openXmlType, out convertToOpenXml))
      return (OpenXmlElementType?)convertToOpenXml(modelObject, openXmlType);

    if (SimpleValueConverter.TryConvertTo(modelObject, openXmlType, out var result))
      return (OpenXmlElementType?)result;

    var openXmlElement = Activator.CreateInstance(openXmlType)!;
    UpdateData(modelObject, openXmlElement, openXmlType);
    return (OpenXmlElementType?)openXmlElement;
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

    modelType = modelType.GetNotNullableType();

    var openXmlType = openXmlObject.GetType().GetNotNullableType();
    if (modelType == openXmlType)
      return openXmlObject;

    if (modelType.IsAssignableFrom(openXmlObject.GetType()!))
      return openXmlObject;

    if (ConvertFromOpenXmlDelegates.TryGetValue(modelType, out var convertFromOpenXml) ||
        ConvertFromOpenXmlDelegates.TryGetValue(openXmlType, out convertFromOpenXml))
      return convertFromOpenXml(openXmlObject, modelType);

    if (SimpleValueConverter.TryConvertFrom(openXmlObject, modelType, out var result))
      return result;

    if (modelType.GetCustomAttribute<DirectAccessAttribute>() is {} directAccess && directAccess.IsEnabled
        && modelType.GetConstructor([typeof(DX.OpenXmlCompositeElement)])!=null)
    {
      var modelObject = Activator.CreateInstance(modelType, openXmlObject)!;
      return modelObject;
    }
    else
    {
      var modelObject = Activator.CreateInstance(modelType)!;
      if (openXmlObject is DX.OpenXmlElement openXmlElement)
        LoadData(modelObject, openXmlElement);
      return modelObject;
    }
  }

  /// <summary>
  /// Generic version of ConvertFrom that converts an OpenXML element to an instance of the specified model type.
  /// </summary>
  /// <typeparam name="ModelElementType"></typeparam>
  /// <typeparam name="OpenXmlElementType"></typeparam>
  /// <param name="openXmlObject"></param>
  /// <returns></returns>
  public static ModelElementType? ConvertFrom<ModelElementType, OpenXmlElementType>(OpenXmlElementType? openXmlObject)
  {
    var modelType = typeof(ModelElementType).GetNotNullableType();
    var openXmlType = typeof(OpenXmlElementType).GetNotNullableType();

    if (ConvertFromOpenXmlDelegates.TryGetValue(modelType, out var convertFromOpenXml) ||
        ConvertFromOpenXmlDelegates.TryGetValue(openXmlType, out convertFromOpenXml))
      return (ModelElementType?)convertFromOpenXml(openXmlObject, modelType);

    if (SimpleValueConverter.TryConvertFrom<ModelElementType, OpenXmlElementType>(openXmlObject, out var result))
      return result;

    var modelObject = Activator.CreateInstance(modelType)!;
    if (openXmlObject is DX.OpenXmlElement openXmlElement)
      LoadData(modelObject, openXmlElement);
    return (ModelElementType?)modelObject;
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
    if (TryUpdateUsingTypeUpdateDataMethod(modelObject, openXmlObject, openXmlType, modelType)) return;

    TryUpdateModelProperties(modelObject, openXmlObject, openXmlType, modelType);
    TryUpdateUsingItemAttribute(modelObject, openXmlObject, modelType);
  }

  /// <summary>
  /// Attempts to update the specified Open XML element using the provided model object if the model type is decorated
  /// with the OpenXmlItemAttribute.
  /// </summary>
  /// <remarks>This method performs the update only if the openXmlObject is of type DX.OpenXmlElement and the
  /// modelType has the OpenXmlItemAttribute applied.</remarks>
  /// <param name="modelObject">The model object that contains the data to update the Open XML element.</param>
  /// <param name="openXmlObject">The Open XML element to be updated based on the model object.</param>
  /// <param name="modelType">The type of the model object, which is checked for the presence of the OpenXmlItemAttribute.</param>
  public static void TryUpdateUsingItemAttribute(object modelObject, object openXmlObject, Type modelType)
  {
    if (openXmlObject is DX.OpenXmlElement openXmlElement &&
        modelType.GetCustomAttribute<OpenXmlItemAttribute>() != null)
    {
      UpdateElementCollection(modelObject, openXmlElement);
    }
  }

  /// <summary>
  /// Attempts to update the properties of a model object by synchronizing them with the corresponding properties of an Open XML
  /// </summary>
  /// <param name="modelObject">The model object whose properties will be updated based on the Open XML element. Cannot be null.</param>
  /// <param name="openXmlObject">The Open XML element or other object containing the data to synchronize with the model object. Cannot be null.</param>
  /// <param name="openXmlType">The type of the Open XML element used to determine property mapping.
  /// If null then type of <paramref name="openXmlObject"/> will be used.</param>
  /// <param name="modelType">The type of the model object, used to retrieve the corresponding update method.</param>
  /// <returns>true if any properties were successfully updated; otherwise, false.</returns>
  public static bool TryUpdateModelProperties
    (object modelObject, object openXmlObject, Type openXmlType, Type modelType)
  {
    bool updated = false;
    foreach (var modelProperty in modelType.GetModelProperties())
    {
      if (UpdateData(modelObject, modelProperty, openXmlObject, openXmlType)) updated = true;
    }
    return updated;
  }

  /// <summary>
  /// Attempts to update the specified model object using data from the provided Open XML object, based on the given
  /// types.
  /// </summary>
  /// <remarks>This method locates an update method for the specified types and invokes it if available. The
  /// update method is expected to accept a single parameter representing the Open XML object.</remarks>
  /// <param name="modelObject">The model object to be updated with data from the Open XML object. Must not be null.</param>
  /// <param name="openXmlObject">The Open XML object containing the data to update the model object. Must not be null.</param>
  /// <param name="openXmlType">The type of the Open XML object, used to determine the appropriate update method.</param>
  /// <param name="modelType">The type of the model object, used to retrieve the corresponding update method.</param>
  /// <returns>true if the model object was successfully updated using the corresponding update method; otherwise, false.</returns>
  public static bool TryUpdateUsingTypeUpdateDataMethod
    (object modelObject, object openXmlObject, Type openXmlType, Type modelType)
  {
    var updateMethod = OpenXmlTypeMap.GetUpdateDataMethod(modelType, openXmlType);
    if (updateMethod != null)
    {
      Debug.Assert(updateMethod.GetParameters().Length == 1,
        $"Update method {updateMethod} should have exactly one parameter");
      updateMethod.Invoke(modelObject, [openXmlObject]);
      return true;
    }
    return false;
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
  public static bool UpdateData(object modelObject, PropertyInfo modelProperty, object openXmlObject, Type openXmlType)
  {
    if (modelProperty.GetCustomAttribute<NotMappedAttribute>() != null)
      return false;
    if (modelProperty.Name == "AlignBorderAndEdges") Debug.Assert(true);
    if (TryUpdateUsingPropertyUpdateDataMethod(modelObject, modelProperty, openXmlObject, openXmlType)) return true;
    if (TryUpdateUsingTypeUpdateDataMethod(modelObject, modelProperty, openXmlObject, openXmlType)) return true;
    if (TryUpdateUsingElementAttribute(modelObject, modelProperty, openXmlObject, openXmlType)) return true;
    if (TryUpdateUsingElementCollectionAttribute(modelObject, modelProperty, openXmlObject, openXmlType)) return true;
    if (TryUpdateUsingPropertyMapping(modelObject, modelProperty, openXmlObject, openXmlType)) return true;

    return false;
  }

  /// <summary>
  /// Attempts to update the specified Open XML object by mapping and transferring the value from a property of the
  /// provided model object.
  /// </summary>
  /// <remarks>This method performs type conversion if the model property value is not directly assignable to
  /// the Open XML property type. If the property value implements IUpdatable, additional update logic is applied to
  /// synchronize data. The method returns false if the property mapping is not found or the Open XML property cannot be
  /// written.</remarks>
  /// <param name="modelObject">The source object containing the property value to be mapped to the Open XML object. Cannot be null.</param>
  /// <param name="modelProperty">The property information from the model object whose value will be used for the update. Must be a valid property
  /// of the model object.</param>
  /// <param name="openXmlObject">The target Open XML object to be updated with the mapped property value. Cannot be null.</param>
  /// <param name="openXmlType">The type of the Open XML object, used to determine the appropriate property mapping.</param>
  /// <returns>true if the Open XML object was successfully updated with the mapped property value; otherwise, false.</returns>
  public static bool TryUpdateUsingPropertyMapping
    (object modelObject, PropertyInfo modelProperty, object openXmlObject, Type openXmlType)
  {
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
      if (modelValue is IUpdatable updatable && openXmlValue is DX.OpenXmlElement)
      {
        updatable.SetUpdatableElement(openXmlValue);
        updatable.UpdateData(openXmlValue);
      }
      return true;
    }
    return false;
  }

  /// <summary>
  /// Attempts to update the specified model property using the OpenXmlElementCollectionAttribute, if present on the
  /// property.
  /// </summary>
  /// <remarks>This method checks for the OpenXmlElementCollectionAttribute on the specified property and, if
  /// found, updates the child element collection accordingly. Use this method to apply attribute-driven updates to
  /// model properties that represent Open XML element collections.</remarks>
  /// <param name="modelObject">The object containing the property to be updated.</param>
  /// <param name="modelProperty">The property information for the model property that may be updated.</param>
  /// <param name="openXmlObject">The OpenXmlElement representing the current state of the Open XML object.</param>
  /// <param name="openXmlType">The type of the Open XML object being processed.</param>
  /// <returns>true if the property was updated using the OpenXmlElementCollectionAttribute; otherwise, false.</returns>
  public static bool TryUpdateUsingElementCollectionAttribute
    (object modelObject, PropertyInfo modelProperty, object openXmlObject, Type openXmlType)
  {
    var openXmlElementCollectionAttribute = modelProperty.GetCustomAttribute<OpenXmlElementCollectionAttribute>();
    if (openXmlElementCollectionAttribute != null)
    {
      UpdateChildElementCollection(modelObject, modelProperty, (DX.OpenXmlElement)openXmlObject, openXmlType);
      return true;
    }
    return false;
  }

  /// <summary>
  /// Attempts to update the specified property of a model object using data from an OpenXml element, if the property is
  /// decorated with an OpenXmlElementAttribute.
  /// </summary>
  /// <remarks>This method checks for the presence of an OpenXmlElementAttribute on the specified property. If
  /// the attribute is found, the property is updated using the corresponding OpenXml element type.</remarks>
  /// <param name="modelObject">The object whose property is to be updated with data from the OpenXml element.</param>
  /// <param name="modelProperty">The property of the model object to update. Must be decorated with OpenXmlElementAttribute to be processed.</param>
  /// <param name="openXmlObject">The OpenXml element containing the data to update the model property.</param>
  /// <param name="openXmlType">The type of the OpenXml element being processed.</param>
  /// <returns>true if the property was updated using the OpenXml element; otherwise, false.</returns>
  public static bool TryUpdateUsingElementAttribute
    (object modelObject, PropertyInfo modelProperty, object openXmlObject, Type openXmlType)
  {
    var openXmlElementAttribute = modelProperty.GetCustomAttribute<OpenXmlElementAttribute>();
    if (openXmlElementAttribute != null)
    {
      UpdateChildElement(modelObject, modelProperty, (DX.OpenXmlElement)openXmlObject, openXmlType,
        openXmlElementAttribute.OpenXmlType);
      return true;
    }
    return false;
  }

  /// <summary>
  /// Attempts to update the specified property of a model object using data from the provided Open XML object and type.
  /// Returns a value indicating whether the update was successful.
  /// </summary>
  /// <remarks>This method locates and invokes an update method based on the property type and the Open XML
  /// type. The update method must accept a single parameter corresponding to the Open XML object.</remarks>
  /// <param name="modelObject">The instance of the model object whose property is to be updated.</param>
  /// <param name="modelProperty">The property of the model object to update. Must be a valid PropertyInfo representing a writable property.</param>
  /// <param name="openXmlObject">The Open XML object containing the data to use for the update operation.</param>
  /// <param name="openXmlType">The type of the Open XML object, used to determine the appropriate update method.</param>
  /// <returns>true if the property was successfully updated using the corresponding update method; otherwise, false.</returns>
  /// <exception cref="InvalidOperationException">Thrown if the update method for the specified property does not accept exactly one parameter.</exception>
  public static bool TryUpdateUsingTypeUpdateDataMethod
    (object modelObject, PropertyInfo modelProperty, object openXmlObject, Type openXmlType)
  {
    var updateTypeMethod = OpenXmlTypeMap.GetUpdateDataMethod(modelProperty.PropertyType, openXmlType);
    if (updateTypeMethod != null)
    {
      var targetParameters = updateTypeMethod.GetParameters();
      if (targetParameters.Length == 1)
      {
        var propertyValue = modelProperty.GetValue(modelObject);
        updateTypeMethod.Invoke(propertyValue, [openXmlObject]);
        return true;
      }
      throw new InvalidOperationException(
        $"Invalid number of parameters in method {modelProperty.PropertyType}.{updateTypeMethod.Name}");
    }
    return false;
  }

  /// <summary>
  /// Attempts to update a property of the specified model object using the provided Open XML object, if a suitable
  /// update method is available.
  /// </summary>
  /// <remarks>This method relies on the OpenXmlPropertyMap to retrieve the appropriate update method for the
  /// specified property. It is important that the update method accepts exactly one parameter.</remarks>
  /// <param name="modelObject">The object that contains the property to be updated.</param>
  /// <param name="modelProperty">The property information of the model object that is to be updated.</param>
  /// <param name="openXmlObject">The Open XML object that contains the data to update the model property.</param>
  /// <param name="openXmlType">The type of the Open XML object, used to determine the appropriate update method.</param>
  /// <returns>true if the property was successfully updated; otherwise, false.</returns>
  /// <exception cref="InvalidOperationException">Thrown if the update method has an invalid number of parameters.</exception>
  public static bool TryUpdateUsingPropertyUpdateDataMethod
    (object modelObject, PropertyInfo modelProperty, object openXmlObject, Type openXmlType)
  {
    var updatePropertyMethod = OpenXmlPropertyMap.GetUpdateDataMethod(modelProperty, openXmlType);
    if (updatePropertyMethod != null)
    {
      var targetParameters = updatePropertyMethod.GetParameters();
      if (targetParameters.Length == 1)
      {
        if (openXmlObject is DXD.Dark1Color) Debug.Assert(true);
        updatePropertyMethod.Invoke(modelObject, [openXmlObject]);
        return true;
      }
      throw new InvalidOperationException(
        $"Invalid number of parameters in method {updatePropertyMethod.DeclaringType}.{updatePropertyMethod.Name}");
    }
    return false;
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

    //if (openXmlChildType == typeof(DXW.StylePaneSortMethods)) Debug.Assert(true);
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
  /// <returns></returns>
  /// <exception cref="InvalidOperationException">Thrown if the update fails.</exception>
  public static bool UpdateChildElementCollection
    (object modelObject, PropertyInfo modelProperty, DX.OpenXmlElement openXmlElement, Type openXmlType)
  {
    var modelValue = modelProperty.GetValue(modelObject);
    if (modelValue == null)
      return true;

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
    bool updated = false;
    foreach (var modelElement in modelElementsCollection)
    {
      var openXmlChildElement = ConvertTo(modelElement, openXmlChildType);
      if (openXmlChildElement is not DX.OpenXmlElement o)
        throw new InvalidOperationException($"Converted Open XML child element is not of type DX.OpenXmlElement " +
                                            $"for model property {modelProperty.Name}");

      openXmlElement.AddChildUsingSchemaOrder(o);
      updated = true;
    }
    return updated;
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
  /// Loads data to model object from OpenXml object. This method will try to find a load method for the specified types and invoke it if available.
  /// </summary>
  /// <param name="modelObject">The target model object that will receive the loaded data.</param>
  /// <param name="openXmlObject">The Open XML object containing the data to be loaded into the model object.</param>
  public static void LoadData(object modelObject, object openXmlObject)
  {
    if (modelObject.GetType().Name == "Body") Debug.Assert(true);
    (modelObject as ILoadable)?.SetLoading(true);
    var modelType = modelObject.GetType();
    var openXmlType = openXmlObject.GetType();
    if (TryLoadUsingTypeLoadDataMethod(modelObject, openXmlObject, openXmlType)) return;
    TryLoadModelProperties(modelObject, openXmlObject, modelType, openXmlType);
    TryLoadUsingItemAttribute(modelObject, openXmlObject, modelType);
    (modelObject as ILoadable)?.SetLoading(false);
  }

  /// <summary>
  /// Attempts to load data into the specified model object by invoking a corresponding load method for the given Open
  /// XML type.
  /// </summary>
  /// <remarks>This method uses reflection to locate and invoke a load method on the model object that matches
  /// the provided Open XML type. The load method must accept exactly one parameter of the Open XML object's type. If no
  /// suitable method is found, the operation returns false.</remarks>
  /// <param name="modelObject">The target model object that will receive the loaded data. This object must define a load method compatible with
  /// the specified Open XML type.</param>
  /// <param name="openXmlObject">The Open XML object containing the data to be loaded into the model object.</param>
  /// <param name="openXmlType">The type of the Open XML object, used to identify the appropriate load method on the model object.</param>
  /// <returns>true if the data was successfully loaded into the model object; otherwise, false.</returns>
  public static bool TryLoadUsingTypeLoadDataMethod
    (object modelObject, object openXmlObject, Type openXmlType)
  {
    var loadTypeMethod = OpenXmlTypeMap.GetLoadDataMethod(modelObject.GetType(), openXmlType);
    if (loadTypeMethod != null)
    {
      Debug.Assert(loadTypeMethod.GetParameters().Length == 1,
        $"Load method {loadTypeMethod} should have exactly one parameter");
      loadTypeMethod.Invoke(modelObject, [openXmlObject]);
      return true;
    }
    return false;
  }
  /// <summary>
  /// Attempts to load data from an Open XML element into a model object if the model type is decorated with the
  /// OpenXmlItemAttribute.
  /// </summary>
  /// <remarks>This method performs the loading operation only if the provided Open XML object is a
  /// DX.OpenXmlElement and the model type is decorated with the OpenXmlItemAttribute. No action is taken if these
  /// conditions are not met.</remarks>
  /// <param name="modelObject">The model object that receives data loaded from the Open XML element.</param>
  /// <param name="openXmlObject">The Open XML object to be loaded into the model object. Must be of type DX.OpenXmlElement.</param>
  /// <param name="modelType">The type of the model object, used to determine if the OpenXmlItemAttribute is present.</param>
  public static void TryLoadUsingItemAttribute(object modelObject, object openXmlObject, Type modelType)
  {
    if (openXmlObject is DX.OpenXmlCompositeElement openXmlElement &&
        modelType.GetCustomAttribute<OpenXmlItemAttribute>() != null)
    {
      LoadCollectionChildren(modelObject, openXmlElement);
    }
  }

  /// <summary>
  /// Attempts to load writable properties from the specified Open XML object into the provided model object, based on
  /// the given types.
  /// </summary>
  /// <remarks>Only properties that are writable and not marked with the NotMapped attribute are considered for
  /// loading. This method iterates through the model's properties and attempts to assign values from the Open XML
  /// object where applicable.</remarks>
  /// <param name="modelObject">The target model object whose properties will be populated.</param>
  /// <param name="openXmlObject">The Open XML object containing the data to be loaded into the model properties.</param>
  /// <param name="modelType">The type of the model object, used to identify which properties can be set.</param>
  /// <param name="openXmlType">The type of the Open XML object, used to determine how to extract data for the model properties.</param>
  /// <returns>true if at least one property was successfully loaded; otherwise, false.</returns>
  public static bool TryLoadModelProperties(object modelObject, object openXmlObject, Type modelType, Type openXmlType)
  {
    bool loaded = false;
    foreach (var modelProperty in modelType.GetModelProperties())
    {
      if (modelProperty.CanWrite && modelProperty.GetCustomAttribute<NotMappedAttribute>() == null)
      {
        if (LoadProperty(modelObject, modelProperty, openXmlObject)) loaded = true;
      }
    }
    return loaded;
  }

  /// <summary>
  /// Loads data from an Open XML element into a model object's property.
  /// </summary>
  /// <param name="modelObject">The target model object.</param>
  /// <param name="modelProperty">The property to set on the model object.</param>
  /// <param name="openXmlObject">The source Open XML element or other object.</param>
  /// <returns>true if the property was successfully loaded; otherwise, false.</returns>
  public static bool LoadProperty(object modelObject, PropertyInfo modelProperty, object openXmlObject)
  {
    //Debug.WriteLine($"Loading property {modelProperty.Name} of type {modelProperty.PropertyType} " +
    //                $"from Open XML type {openXmlType} into model type {modelObject.GetType()}");

    var propertyType = modelProperty.PropertyType.GetNotNullableType();
    if (modelProperty.Name == "LatentStyles") Debug.Assert(true);

    if (modelProperty.Name == "DefinedStyles") Debug.Assert(true);
    if (propertyType.Implements(typeof(ILazyLoadable)) && openXmlObject is DX.OpenXmlCompositeElement openXmlCompositeElement)
    {
      var propertyValue = modelProperty.GetValue(modelObject);
      if (propertyValue == null)
      {
        propertyValue = Activator.CreateInstance(propertyType)!;
        modelProperty.SetValue(modelObject, propertyValue);
      }
      TryRegisterLazyLoad(propertyValue, openXmlCompositeElement);
      return true;
    }
    if (TryLoadUsingPropertyLoadDataMethod(modelObject, modelProperty, openXmlObject)) return true;
    if (TryLoadUsingTypeLoadDataMethod(modelObject, modelProperty, openXmlObject)) return true;
    if (TryLoadUsingElementAttribute(modelObject, modelProperty, openXmlObject)) return true;
    if (TryLoadUsingElementCollectionAttribute(modelObject, modelProperty, openXmlObject)) return true;
    if (TryLoadUsingPropertyMapping(modelObject, modelProperty, openXmlObject)) return true;

    return false;
  }

  /// <summary>
  /// Attempts to load a value from an Open XML object into a specified property of a model object using property mapping.
  /// </summary>
  /// <remarks>This method supports both simple and complex property types, converting or instantiating values
  /// as necessary to match the model property's type. The conversion process ensures compatibility between Open XML
  /// values and the model's expected types.</remarks>
  /// <param name="modelObject">The target object whose property will be set with the value retrieved from the Open XML object.</param>
  /// <param name="modelProperty">The property information of the model object that is to be assigned a value from the Open XML object.</param>
  /// <param name="openXmlObject">The Open XML object from which the value is extracted for mapping to the model property.</param>
  /// <returns>true if the value was successfully loaded and assigned to the model property; otherwise, false.</returns>
  public static bool TryLoadUsingPropertyMapping(object modelObject, PropertyInfo modelProperty, object openXmlObject)
  {
    var openXmlPropertyAttribute = modelProperty.GetCustomAttribute<OpenXmlPropertyAttribute>();
    if (openXmlPropertyAttribute != null && openXmlPropertyAttribute.DirectAccess)
      return false;
    var openXmlType = openXmlObject.GetType();
    if (modelProperty.Name == "EastAsia") Debug.Assert(true);
    var openXmlProperty = OpenXmlPropertyMap.GetOpenXmlProperty(modelProperty, openXmlType);
    if (openXmlProperty is not null && openXmlProperty.CanRead)
    {
      var openXmlValue = openXmlProperty.GetValue(openXmlObject);
      if (openXmlValue != null)
      {
        var modelPropertyType = modelProperty.PropertyType.GetNotNullableType();
        if (modelPropertyType.IsSimpleValueType())
        {
          var modelValue = ConvertFrom(openXmlValue, modelPropertyType);
          if (modelValue != null && !modelPropertyType.IsInstanceOfType(modelValue))
          {
            modelValue = SimpleValueConverter.ConvertFrom(modelValue, modelPropertyType);
          }
          modelValue = ConvertValue(modelValue, modelPropertyType);
          modelProperty.SetValue(modelObject, modelValue);
          return true;
        }
        else
        {
          var modelValue = Activator.CreateInstance(modelProperty.PropertyType)!;
          LoadData(modelValue, openXmlValue);
          modelProperty.SetValue(modelObject, modelValue);
          return true;
        }
      }
    }
    return false;
  }


  /// <summary>
  /// Attempts to load child elements from an OpenXmlCompositeElement into a model object's property that is decorated
  /// with the OpenXmlElementCollectionAttribute.
  /// </summary>
  /// <remarks>This method checks for the presence of the OpenXmlElementCollectionAttribute on the specified
  /// property and attempts to load child elements only if the attribute is found and the openXmlObject is an
  /// OpenXmlCompositeElement.</remarks>
  /// <param name="modelObject">The target model object that will receive the loaded child elements.</param>
  /// <param name="modelProperty">The property of the model object that is expected to be decorated with the OpenXmlElementCollectionAttribute.</param>
  /// <param name="openXmlObject">The OpenXmlCompositeElement instance containing the child elements to be loaded.</param>
  /// <returns>true if the child elements were successfully loaded into the model object's property; otherwise, false.</returns>
  public static bool TryLoadUsingElementCollectionAttribute
    (object modelObject, PropertyInfo modelProperty, object openXmlObject)
  {
    var openXmlElementCollectionAttribute = modelProperty.GetCustomAttribute<OpenXmlElementCollectionAttribute>();
    if (openXmlElementCollectionAttribute != null &&
        openXmlObject is DX.OpenXmlCompositeElement compositeElementCollection)
    {
      LoadChildElementCollection(modelObject, modelProperty, compositeElementCollection);
      return true;
    }
    return false;
  }

  /// <summary>
  /// Attempts to load a child element from the specified Open XML object into the given model property using the
  /// property's OpenXmlElementAttribute mapping.
  /// </summary>
  /// <remarks>This method only attempts to load the child element if the model property is decorated with
  /// OpenXmlElementAttribute and the Open XML object is a composite element. No changes are made if these conditions
  /// are not met.</remarks>
  /// <param name="modelObject">The model object containing the property to be populated with data from the Open XML element.</param>
  /// <param name="modelProperty">The property of the model object that is decorated with the OpenXmlElementAttribute, indicating the mapping to the
  /// Open XML element.</param>
  /// <param name="openXmlObject">The Open XML object from which the child element is loaded. Must be an instance of DX.OpenXmlCompositeElement to
  /// succeed.</param>
  /// <returns>true if the child element was successfully loaded into the model property; otherwise, false.</returns>
  public static bool TryLoadUsingElementAttribute
    (object modelObject, PropertyInfo modelProperty, object openXmlObject)
  {
    var openXmlElementAttribute = modelProperty.GetCustomAttribute<OpenXmlElementAttribute>();
    if (openXmlElementAttribute != null && openXmlObject is DX.OpenXmlCompositeElement compositeElement)
    {
      LoadChildElement(modelObject, modelProperty, compositeElement, openXmlElementAttribute.OpenXmlType);
      return true;
    }
    return false;
  }

  /// <summary>
  /// Attempts to populate a property of a model object with data from an Open XML object using a model type loading method.
  /// </summary>
  /// <remarks>This method locates and invokes a loading method based on the property type and Open XML type.
  /// The loading method must accept exactly one parameter, which is enforced by an assertion.</remarks>
  /// <param name="modelObject">The instance of the model object containing the property to be populated.</param>
  /// <param name="modelProperty">The property information for the model property that will receive the loaded data.</param>
  /// <param name="openXmlObject">The Open XML object that provides the data to be loaded into the model property.</param>
  /// <returns>true if the data was successfully loaded into the model property; otherwise, false.</returns>
  public static bool TryLoadUsingTypeLoadDataMethod
    (object modelObject, PropertyInfo modelProperty, object openXmlObject)
  {
    Type openXmlType = openXmlObject.GetType();
    var loadTypeMethod = OpenXmlTypeMap.GetLoadDataMethod(modelProperty.PropertyType, openXmlType);
    if (loadTypeMethod != null)
    {
      Debug.Assert(loadTypeMethod.GetParameters().Length == 1,
        $"Load method {loadTypeMethod} should have exactly one parameter");
      var propertyValue = modelProperty.GetValue(modelObject);
      loadTypeMethod.Invoke(propertyValue, [openXmlObject]);
      return true;
    }
    return false;
  }

  /// <summary>
  /// Attempts to load data into a model object's property using a custom load method defined for the model property.
  /// </summary>
  /// <param name="modelObject">The model object to load data into.</param>
  /// <param name="modelProperty">The property of the model object to set.</param>
  /// <param name="openXmlObject">The Open XML object containing the data.</param>
  /// <returns>True if the data was successfully loaded using a custom load method; otherwise, false.</returns>
  public static bool TryLoadUsingPropertyLoadDataMethod
    (object modelObject, PropertyInfo modelProperty, object openXmlObject)
  {
    Type openXmlType = openXmlObject.GetType();
    var loadPropertyMethod = OpenXmlPropertyMap.GetLoadDataMethod(modelProperty, openXmlType);
    if (loadPropertyMethod != null)
    {
      Debug.Assert(loadPropertyMethod.GetParameters().Length == 1,
        $"Load method {loadPropertyMethod} should have exactly one parameter");
      loadPropertyMethod.Invoke(modelObject, [openXmlObject]);
      return true;
    }
    return false;
  }

  /// <summary>
  /// Loads a child element from an Open XML element into a model object's property, based on the specified Open XML type and child type.
  /// </summary>
  /// <param name="modelObject">The model object to load the child element into.</param>
  /// <param name="modelProperty">The model property to set the value of.</param>
  /// <param name="openXmlElement">The Open XML element to load the child element from.</param>
  /// <param name="openXmlChildType">The Open XML child type of the element.</param>
  /// <exception cref="InvalidOperationException"></exception>
  public static void LoadChildElement(object modelObject, PropertyInfo modelProperty, DX.OpenXmlCompositeElement openXmlElement,
    Type? openXmlChildType)
  {
    var modelPropertyType = modelProperty.PropertyType.GetNotNullableType();
    var openXmlType = openXmlElement.GetType();
    if (openXmlChildType == null)
    {
      // If no specific openXmlChildType is provided, use the model property's type to determine the Open XML type.
      openXmlChildType = OpenXmlTypeMap.GetOpenXmlTypeForModelType(modelPropertyType);
      if (openXmlChildType == null)
        throw new InvalidOperationException($"No Open XML type mapping found " +
                                            $"for model property {modelProperty.Name} of type {modelPropertyType}");
    }
    var children = openXmlElement.ElementsOfType(openXmlChildType)
      .Select(child => ResolveTypedChildElement(child, openXmlChildType)).Where(child => child != null)
      .Cast<DX.OpenXmlElement>().ToArray();
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
  /// <exception cref="InvalidOperationException"></exception>
  public static void LoadChildElementCollection
    (object modelObject, PropertyInfo modelProperty, DX.OpenXmlCompositeElement openXmlElement)
  {
    //Debug.WriteLine($"Loading child element collection for model property {modelProperty.Name} of type {modelProperty.PropertyType} " +
    //                $"from Open XML type {openXmlElement.GetType()} into model type {modelObject.GetType()}");
    var modelPropertyType = modelProperty.PropertyType.GetNotNullableType();

    object? modelValue = modelProperty.GetValue(modelObject);
    if (modelValue == null)
      modelValue = Activator.CreateInstance(modelPropertyType)!;

    LoadCollectionChildren(modelValue, openXmlElement);

    modelProperty.SetValue(modelObject, modelValue);
  }

  /// <summary>
  /// Helper method to load child elements from an Open XML element into a model object's collection property.
  /// </summary>
  /// <param name="modelCollection">The model collection to load the child elements into.</param>
  /// <param name="openXmlElement">The Open XML element to load the child elements from.</param>
  /// <exception cref="InvalidOperationException"></exception>
  public static void LoadCollectionChildren(object modelCollection, DX.OpenXmlCompositeElement openXmlElement)
  {
    //Debug.WriteLine($"Loading collection children for model collection of type {modelCollection.GetType()} " +
    //                $"from Open XML type {openXmlElement.GetType()}");
    if (TryRegisterLazyLoad(modelCollection, openXmlElement))
      return;

    var modelPropertyType = modelCollection.GetType();
    var (modelItemType, openXmlChildType) =
      GetCollectionLoadMetadata(modelPropertyType);

    var collectionType = modelCollection.GetType();
    var modelAddMethod = collectionType.GetMethod("Add", [modelItemType]);
    if (modelAddMethod == null)
      throw new InvalidOperationException($"No Add method found in collection type {collectionType}");

    var modelClearMethod = collectionType.GetMethod("Clear", []);
    if (modelClearMethod == null)
      throw new InvalidOperationException($"No Clear method found in collection type {collectionType}");

    modelClearMethod.Invoke(modelCollection, []);

    var children = GetResolvedChildElements(openXmlElement, openXmlChildType);
    foreach (var openXmlChildElement in children)
    {
      if (modelCollection is IFilteringCollection filteredCollection)
      {
        if (!filteredCollection.AcceptItem(openXmlChildElement))
          continue;
      }
      var modelItem = ConvertFrom(openXmlChildElement, modelItemType);
      if (modelItem != null && !modelItemType.IsInstanceOfType(modelItem))
        throw new InvalidOperationException($"Converted model Item is not compatible to {modelItemType}");

      modelAddMethod.Invoke(modelCollection, [modelItem]);
    }
  }

  /// <summary>
  /// Helper method to retrieve metadata required for loading a collection property from an Open XML element.
  /// </summary>
  /// <param name="collectionType"></param>
  /// <param name="fallbackOpenXmlChildType"></param>
  /// <returns></returns>
  /// <exception cref="InvalidOperationException"></exception>
  public static (Type modelItemType, Type openXmlChildType)
    GetCollectionLoadMetadata(Type collectionType, Type? fallbackOpenXmlChildType = null)
  {
    var collectionInterface = collectionType.GetInterfaces()
      .FirstOrDefault(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(ICollection<>));
    if (collectionInterface == null)
      throw new InvalidOperationException($"{collectionType} is not a collection of known type.");

    var modelItemType = collectionInterface.GetGenericArguments().FirstOrDefault();
    if (modelItemType == null)
      throw new InvalidOperationException($"No item type declared in {collectionType}.");

    var openXmlChildType = OpenXmlTypeMap.GetOpenXmlTypeForModelType(modelItemType) ?? fallbackOpenXmlChildType;
    if (openXmlChildType == null)
      throw new InvalidOperationException($"No Open XML type mapping found for type {modelItemType}");



    return (modelItemType, openXmlChildType);
  }

  /// <summary>
  /// Helper method to get resolved child elements of a specific Open XML type from a parent Open XML element.
  /// </summary>
  /// <param name="openXmlElement">The parent Open XML element.</param>
  /// <param name="openXmlChildType">The expected type of the child Open XML elements.</param>
  /// <returns>An array of resolved child elements of the specified type.</returns>
  public static DX.OpenXmlElement[] GetResolvedChildElements(DX.OpenXmlElement openXmlElement, Type openXmlChildType)
  {
    return openXmlElement.ChildElements
      .Select(child => ResolveTypedChildElement(child, openXmlChildType))
      .Where(child => child != null)
      .Cast<DX.OpenXmlElement>()
      .ToArray();
  }

  /// <summary>
  /// Resolves the specified child element to a strongly typed OpenXmlElement if it matches the expected type or can be
  /// converted from an unknown element.
  /// </summary>
  /// <remarks>If the child element is of type DX.OpenXmlUnknownElement, the method attempts to create an
  /// instance of the specified type and populate it with the data from the unknown element. Returns null if the types
  /// do not match, conversion is not possible, or an error occurs during instantiation.</remarks>
  /// <param name="childElement">The child element to resolve. Must be an instance of DX.OpenXmlElement or DX.OpenXmlUnknownElement.</param>
  /// <param name="openXmlChildType">The expected type of the OpenXmlElement to match or convert to.</param>
  /// <returns>An instance of DX.OpenXmlElement of the specified type if the child element matches or can be converted;
  /// otherwise, null.</returns>
  public static DX.OpenXmlElement? ResolveTypedChildElement(DX.OpenXmlElement childElement, Type openXmlChildType)
  {
    if (childElement.GetType() == openXmlChildType)
      return childElement;
    if (childElement is not DX.OpenXmlUnknownElement)
      return null;

    DX.OpenXmlElement? prototype = null;
    try
    {
      prototype = Activator.CreateInstance(openXmlChildType) as DX.OpenXmlElement;
    }
    catch
    {
      return null;
    }
    if (prototype == null || childElement.LocalName != prototype.LocalName ||
        childElement.NamespaceUri != prototype.NamespaceUri)
      return null;

    //prototype.Load(childElement.OuterXml);
    //var outerXmlCtor = typeof(DX.OpenXmlElement).GetConstructor([typeof(string)]);
    //if (outerXmlCtor == null)
    //  return null;
    try
    {
      var outerXmlSetter = typeof(DX.OpenXmlElement)
        .GetProperty("OuterXml", BindingFlags.Public | BindingFlags.Instance)?.GetSetMethod(true);
      if (outerXmlSetter != null)
      {
        outerXmlSetter.Invoke(prototype, [childElement.OuterXml]);
        var parseMethod = openXmlChildType.GetMethod("ParseXml", BindingFlags.NonPublic | BindingFlags.Instance);
        parseMethod?.Invoke(prototype, []);
      }
      return prototype;
    }
    catch
    {
      return null;
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


  /// <summary>
  /// Tries to registers a lazy load for a model collection from openXmlObject.
  /// </summary>
  /// <param name="modelCollection">The target model object collection.</param>
  /// <param name="openXmlObject">The source Open XML element or other object.</param>
  public static bool TryRegisterLazyLoad(object modelCollection, DX.OpenXmlCompositeElement openXmlObject)
  {
    var modelType = modelCollection.GetType();
    var lazyLoadAttribute = modelType.GetCustomAttribute<LazyLoadAttribute>();
    if (lazyLoadAttribute != null && lazyLoadAttribute.IsEnabled && modelCollection is ILazyLoadable lazyLoadable)
    {
      lazyLoadable.DataSource = openXmlObject;
      lazyLoadable.IsLazyLoadEnabled = true;
      return true;
    }
    return false;
  }

}
