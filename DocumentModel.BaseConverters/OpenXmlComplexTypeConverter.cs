using System.ComponentModel.DataAnnotations.Schema;

namespace DocumentModel.OpenXml;

/// <summary>
/// Provides conversion methods for complex types between model objects and Open XML types.
/// </summary>
public static class OpenXmlComplexTypeConverter
{
  /// <summary>
  /// Converts a model object to an Open XML element of the specified type.
  /// </summary>
  /// <param name="modelObject">The model object to convert.</param>
  /// <param name="openXmlType">The target Open XML type.</param>
  /// <returns>The created Open XML element, or null if the input is null.</returns>
  public static object? ConvertObjectToOpenXml(object? modelObject, Type openXmlType)
  {
    if (modelObject == null)
      return null;
    var currentType = modelObject.GetType();
    var openXmlElement = Activator.CreateInstance(openXmlType)!;
    UpdateData(modelObject, openXmlElement, openXmlType);
    return openXmlElement;
  }

  /// <summary>
  /// Updates the properties of the specified model object by synchronizing their values with the corresponding Open XML
  /// element properties.
  /// </summary>
  /// <remarks>This method iterates through all public instance properties of the model object and updates each
  /// property using the provided Open XML element and type. All properties are processed individually. Ensure that the
  /// model object and Open XML element are compatible for synchronization.</remarks>
  /// <param name="modelObject">The model object whose properties will be updated based on the Open XML element. Cannot be null.</param>
  /// <param name="openXmlElement">The Open XML element containing the data to synchronize with the model object. Cannot be null.</param>
  /// <param name="openXmlType">The type of the Open XML element used to determine property mapping. Cannot be null.</param>
  public static void UpdateData(object modelObject, object openXmlElement, Type openXmlType)
  {
    var currentType = modelObject.GetType();
    foreach (var modelProperty in currentType.GetProperties(BindingFlags.Public | BindingFlags.Instance))
    {
      //if (modelProperty.Name=="Title") Debug.Assert(true);
      UpdateData(modelObject, modelProperty, openXmlElement, openXmlType);
    }
  }

  /// <summary>
  /// Updates the value of a property on an Open XML element to match the value of a corresponding property on a model
  /// object.
  /// </summary>
  /// <param name="modelObject">The source object containing the property value to copy. Cannot be null.</param>
  /// <param name="modelProperty">The property on the model object whose value will be read and applied to the Open XML element. Cannot be null.</param>
  /// <param name="openXmlElement">The Open XML element whose property will be updated. Cannot be null.</param>
  /// <param name="openXmlProperty">The property on the Open XML element to update. Cannot be null.</param>
  public static void UpdateOpenXmlProperty(object modelObject, PropertyInfo modelProperty,
    object openXmlElement, PropertyInfo openXmlProperty)
  {

    var openXmlType = openXmlElement.GetType();
    UpdateData(modelObject, modelProperty, openXmlElement, openXmlType);

  }

  /// <summary>
  /// Updates an Open XML element's property with the value from a model object's property.
  /// </summary>
  /// <param name="modelObject">The source model object.</param>
  /// <param name="modelProperty">The property from the model object.</param>
  /// <param name="openXmlElement">The target Open XML element.</param>
  /// <param name="openXmlType">The type of the Open XML element.</param>
  public static void UpdateData(object modelObject, PropertyInfo modelProperty, object openXmlElement, Type openXmlType)
  {

    if (modelProperty.GetCustomAttribute<NotMappedAttribute>() != null)
      return;
    //if (modelProperty.Name == "Title") Debug.Assert(true);

    var openXmlProperty = OpenXmlPropertyMap.GetOpenXmlPropertyForModelElementProperty(modelProperty, openXmlType);
    if (openXmlProperty is not null && openXmlProperty.CanWrite)
    {
      var modelValue = modelProperty.GetValue(modelObject);
      if (modelValue != null && !openXmlProperty.PropertyType.IsInstanceOfType(modelValue))
      {
        modelValue = ConvertValueToOpenXml(modelValue, openXmlProperty.PropertyType);
      }
      openXmlProperty.SetValue(openXmlElement, modelValue);
      return;
    }
    var setMappedMethod = OpenXmlPropertyMap.GetSetMethod(modelProperty, openXmlType);
    if (setMappedMethod != null)
    {
      var targetParameters = setMappedMethod.GetParameters();
      if (targetParameters.Length == 1)
      {
        var value = modelProperty.GetValue(modelObject);
        if (value != null && !targetParameters[0].ParameterType.IsInstanceOfType(value))
        {
          value = Convert.ChangeType(value, targetParameters[0].ParameterType);
        }
        if (setMappedMethod.DeclaringType == openXmlElement.GetType())
        {
          setMappedMethod.Invoke(openXmlElement, [value]);
          return;
        }
        else if (setMappedMethod.DeclaringType == modelObject.GetType()
                 || modelObject.GetType().IsSubclassOf(setMappedMethod.DeclaringType!))
        {
          setMappedMethod.Invoke(modelObject, [value]);
          return;
        }
      }
    }
    var openXmlElementAttribute = modelProperty.GetCustomAttribute<OpenXmlElementAttribute>();
    if (openXmlElementAttribute != null)
    {
      return;
    }
    var convertedValue = OpenXmlConverter.ConvertFromOpenXml(openXmlElement, modelProperty.PropertyType);
    if (convertedValue != null)
    {
      modelProperty.SetValue(modelObject, convertedValue);
      return;
    }
    throw new InvalidOperationException($"Failed to update Open XML element {openXmlType} " +
                                        $"property {modelProperty.Name} from model element {modelObject.GetType()}");
  }

  /// <summary>
  /// Converts an Open XML element to a model object of the specified type.
  /// </summary>
  /// <param name="openXmlElement">The Open XML element to convert from.</param>
  /// <param name="modelType">The target model type.</param>
  /// <returns>The created model object, or null if the input is null.</returns>
  public static object? ConvertFromOpenXml(object? openXmlElement, Type modelType)
  {
    if (openXmlElement == null)
      return null;
    var openXmlType = openXmlElement.GetType();
    var modelObject = Activator.CreateInstance(modelType)!;
    LoadData(modelObject, openXmlElement, modelType);
    return modelObject;
  }

  /// <summary>
  /// Populates the properties of a model object with data from an Open XML element using the specified model type.
  /// </summary>
  /// <remarks>This method iterates over all public, writable properties of the specified model type and
  /// attempts to load corresponding data from the Open XML element into the model object. Only properties that can be
  /// written to are affected.</remarks>
  /// <param name="modelObject">The instance of the model object whose properties are to be populated. Must not be null.</param>
  /// <param name="openXmlElement">The Open XML element that provides the source data. Must not be null.</param>
  /// <param name="modelType">The type that defines the properties to be populated on the model object. Must not be null and should match the
  /// type of modelObject.</param>
  public static void LoadData(object modelObject, object openXmlElement, Type modelType)
  {
    var openXmlType = openXmlElement.GetType();
    foreach (var modelProperty in modelType.GetProperties(BindingFlags.Public | BindingFlags.Instance))
    {
      if (modelProperty.CanWrite)
      {
        LoadData(modelObject, modelProperty, openXmlElement, openXmlType);
      }
    }
  }

  /// <summary>
  /// Loads data from an Open XML element into a model object's property.
  /// </summary>
  /// <param name="modelObject">The target model object.</param>
  /// <param name="modelProperty">The property to set on the model object.</param>
  /// <param name="openXmlElement">The source Open XML element.</param>
  /// <param name="openXmlType">The type of the Open XML element.</param>
  public static void LoadData(object modelObject, PropertyInfo modelProperty, object openXmlElement, Type openXmlType)
  {
    if (modelProperty.GetCustomAttribute<NotMappedAttribute>() != null)
      return;
    var openXmlProperty = OpenXmlPropertyMap.GetOpenXmlPropertyForModelElementProperty(modelProperty, openXmlType);
    if (openXmlProperty is not null && openXmlProperty.CanRead)
    {
      var openXmlValue = openXmlProperty.GetValue(openXmlElement);
      if (openXmlValue != null && !modelProperty.PropertyType.IsInstanceOfType(openXmlValue))
      {
        var modelPropertyType = modelProperty.PropertyType.GetNotNullableType();
        var modelValue = ConvertValueFromOpenXml(openXmlValue, modelPropertyType);
        if (modelValue != null && !modelPropertyType.IsInstanceOfType(modelValue))
        {
          modelValue = Convert.ChangeType(modelValue, modelPropertyType);
        }
        modelValue = ConvertValue(modelValue, modelPropertyType);
        modelProperty.SetValue(modelObject, modelValue);
      }
      return;
    }
    var getMappedMethod = OpenXmlPropertyMap.GetGetMethod(modelProperty, openXmlType);
    if (getMappedMethod != null)
    {
      var targetParameters = getMappedMethod.GetParameters();
      bool valueRetrieved = false;
      object? value = null;
      if (getMappedMethod.DeclaringType == openXmlElement.GetType())
      {
        value = getMappedMethod.Invoke(openXmlElement, []);
        valueRetrieved = true;

      }
      else if (getMappedMethod.DeclaringType == modelObject.GetType() || modelObject.GetType().IsSubclassOf(getMappedMethod.DeclaringType!))
      {
        value = getMappedMethod.Invoke(modelObject, []);
        valueRetrieved = true;
      }

      if (valueRetrieved)
      {
        if (value != null && !modelProperty.PropertyType.IsInstanceOfType(value))
        {
          value = Convert.ChangeType(value, modelProperty.PropertyType);
        }
        modelProperty.SetValue(modelObject, value);
      }
    }
  }

  /// <summary>
  /// Converts a value to the specified Open XML type using the OpenXmlConverter.
  /// </summary>
  /// <param name="value">The value to convert.</param>
  /// <param name="targetType">The target Open XML type.</param>
  /// <returns>The converted value, or null if the input is null.</returns>
  public static object? ConvertValueToOpenXml(object? value, Type targetType)
  {
    if (value == null)
      return null;
    return OpenXmlConverter.ConvertToOpenXml(value, targetType);
  }

  /// <summary>
  /// Converts a value from an Open XML type to the specified model type using the OpenXmlConverter.
  /// </summary>
  /// <param name="value">The value to convert.</param>
  /// <param name="targetType">The target model type.</param>
  /// <returns>The converted value, or null if the input is null.</returns>
  public static object? ConvertValueFromOpenXml(object? value, Type targetType)
  {
    if (value == null)
      return null;
    return OpenXmlConverter.ConvertFromOpenXml(value, targetType);
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
            value = guidValue;
          }
          else
          {
            throw new FormatException($"Invalid GUID format: {stringValue}");
          }

        }
      }
      value = Convert.ChangeType(value, targetType);
    }
    return value;
  }

}