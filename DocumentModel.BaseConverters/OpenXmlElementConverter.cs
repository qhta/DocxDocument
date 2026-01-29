namespace DocumentModel.OpenXml;


/// <summary>
/// Provides conversion methods between model objects and Open XML element types.
/// </summary>
public static class OpenXmlElementConverter
{

  /// <summary>
  /// Converts a model modelValue to an Open XML element of the specified type.
  /// </summary>
  /// <param name="modelValue">The model modelValue to convert.</param>
  /// <param name="openXmlType">The target Open XML element type.</param>
  /// <returns>The converted Open XML element instance.</returns>
  /// <exception cref="NotSupportedException">Thrown if the conversion is not supported for the specified type.</exception>
  public static DX.OpenXmlElement ConvertToOpenXml(object modelValue, Type openXmlType)
  {
    //if (openXmlType.Name == "HeadingPairs") Debug.Assert(true);
    var modelType = modelValue.GetType().GetNotNullableType();
    if (OpenXmlConverter.ConvertToOpenDelegates.TryGetValue(modelType, out var convertToOpenXml)
        || OpenXmlConverter.ConvertToOpenDelegates.TryGetValue(openXmlType, out convertToOpenXml))
      return (DX.OpenXmlElement?)convertToOpenXml(modelValue, openXmlType)!;
    if (openXmlType.IsEqualOrSubclassOf(typeof(DXW.EmptyType)))
    {
      throw new NotSupportedException($"Conversion to {openXmlType.Name} is not supported.");
    }
    if (openXmlType.IsEqualOrSubclassOf(typeof(DXW.OnOffType)))
    {
      var onOffValue = modelValue as bool?;
      var onOffElement = (DXW.OnOffType)Activator.CreateInstance(openXmlType)!;
      onOffElement.Val = onOffValue.HasValue ? new DX.OnOffValue(onOffValue.Value) : null;
      return onOffElement;
    }
    if (modelValue is string stringValue)
      return (DX.OpenXmlElement)OpenXmlSimpleValueConverter.ConvertToOpenXml(stringValue, openXmlType)!;
    if (modelValue is HexBinary hexBinaryValue)
      return (DX.OpenXmlElement)HexBinaryConverter.CreateOpenXmlElement(hexBinaryValue, openXmlType)!;

    if (openXmlType.IsEqualOrSubclassOf(typeof(DX.OpenXmlLeafTextElement)))
    {
      var constructor = openXmlType.GetConstructor([typeof(string)]);
      var instance = (DX.OpenXmlElement)constructor!.Invoke([ConvertToText(modelValue)])!;
      return instance;
    }
    if (openXmlType.IsEqualOrSubclassOf(typeof(DX.OpenXmlLeafElement)))
    {
      var targetProperties = openXmlType.GetOpenXmlProperties();
      var constructor = openXmlType.GetConstructor([]);
      var instance = (DX.OpenXmlElement)constructor!.Invoke([])!;
      foreach (var prop in targetProperties)
      {
        if (prop.Name == "Val")
        {
          var convertedValue = ConvertTypeToOpenXml(modelValue, prop.PropertyType);
          if (convertedValue != null)
          {
            prop.SetValue(instance, convertedValue);
            return instance;
          }
        }
        else
        {
          var sourceProperty = modelValue!.GetType().GetProperty(prop.Name, BindingFlags.Public | BindingFlags.Instance);
          var propValue = sourceProperty?.GetValue(modelValue);
          var convertedValue = ConvertTypeToOpenXml(propValue, prop.PropertyType);
          if (convertedValue != null)
          {
            prop.SetValue(instance, convertedValue);
            return instance;
          }
        }
      }
    }
    throw new NotSupportedException($"Conversion to {openXmlType.Name} is not supported.");
  }


  /// <summary>
  /// Converts an Open XML element to a corresponding model object based on its type.
  /// </summary>
  /// <param name="element">The Open XML element to convert.</param>
  /// <returns>The corresponding model object, or throws if not supported.</returns>
  /// <exception cref="NotSupportedException">Thrown if the element type is not supported.</exception>
  public static object? GetObjectByOpenXmlType(this DX.OpenXmlElement element)
  {
    if (element is DXW.EmptyType)
      return true;

    // Add more type conversions as needed

    throw new NotSupportedException($"The OpenXmlElement type '{element.GetType().Name}' is not supported.");
  }

  /// <summary>
  /// Creates an Open XML element instance based on the property name and value.
  /// </summary>
  /// <param name="propertyName">The property name to use for mapping.</param>
  /// <param name="value">The value to convert.</param>
  /// <returns>The created Open XML element instance.</returns>
  /// <exception cref="NotImplementedException">Always thrown; not implemented.</exception>
  public static DX.OpenXmlElement? CreateOpenXmlElementByObjectType(string propertyName, object value)
  {
    throw new NotImplementedException();
  }

  /// <summary>
  /// Converts an Open XML element to a model object of the specified type.
  /// </summary>
  /// <param name="element">The Open XML element to convert from.</param>
  /// <param name="modelType">The target model type.</param>
  /// <returns>The converted model object.</returns>
  /// <exception cref="NotSupportedException">Thrown if the conversion is not supported for the element type.</exception>
  public static object? ConvertFromOpenXml(DX.OpenXmlElement element, Type modelType)
  {
    //if (element.GetType().Name == "Zoom")
    //  Debug.Assert(true);
    //if (element is DXW.EmptyType)
    //  return true;
    //if (element is DXW.OnOffType onOffTypeElement)
    //  return onOffTypeElement.Val?.ConvertToBool();
    //if (element is DXW.OnOffOnlyType onOffOnlyTypeElement)
    //  return onOffOnlyTypeElement.Val?.ConvertToBool();
    //if (element is DXW.StringType stringTypeElement)
    //  return stringTypeElement.Val?.Value;
    //if (element is DXW.String255Type string255TypeElement)
    //  return string255TypeElement.Val?.Value;
    //if (element is DX.OpenXmlLeafTextElement leafTextElement)
    //{
    //  var text = leafTextElement.Text;
    //  if (modelType.IsEnum)
    //    return Enum.Parse(modelType, text);
    //  var value = Convert.ChangeType(text, modelType);
    //  return value;
    //}
    //if (element is DX.OpenXmlLeafElement leafElement)
    //{
    //  var openXmlElementType = element.GetType();

    //  var valueProperties = modelType.GetModelProperties();
    //  if (valueProperties.Length == 0)
    //  {
    //    var openXmlProperties = openXmlElementType.GetOpenXmlProperties();
    //    foreach (var openXmlProperty in openXmlProperties)
    //    {
    //      if (openXmlProperty.Name == "Val")
    //      {
    //        var propValue = openXmlProperty.ConvertToBool(leafElement);
    //        var convertedValue = ConvertTypeFromOpenXml(propValue, modelType);
    //        return convertedValue;
    //      }
    //    }
    //  }
    //  else
    //  {
    //    var complexValue = OpenXmlComplexTypeConverter.ConvertFromOpenXml(leafElement, modelType);
    //    return complexValue;
    //  }
    //}
    throw new NotSupportedException($"Conversion from {element.GetType()} is not supported.");
  }

  /// <summary>
  /// Converts a value to the specified Open XML simple value type or enum value type.
  /// </summary>
  /// <param name="value">The value to convert.</param>
  /// <param name="targetType">The target Open XML type.</param>
  /// <returns>The converted value suitable for Open XML, or null if input is null.</returns>
  public static object? ConvertTypeToOpenXml(object? value, Type targetType)
  {
    //DocumentFormat.OpenXml.Wordprocessing.ViewValues
    if (value == null)
      return null;
    if (targetType.Name.StartsWith("EnumValue`"))
    {
      var enumType = targetType.GenericTypeArguments[0];
      var valueStr = value.ToString()!;
      var enumVal = enumType.GetProperty(valueStr, BindingFlags.Public | BindingFlags.Static)?.GetValue(null);
      if (enumVal == null)
        return null;
      //throw new InvalidOperationException($"Unable to convert '{value.GetType()}' to {enumType.Name}. Target '{valueStr}' not found");
      var result = targetType.GetConstructor([enumType])?.Invoke([enumVal]);
      return result;
    }
    return OpenXmlSimpleValueConverter.ConvertToOpenXml(value, targetType);
  }

  /// <summary>
  /// Converts a value from an Open XML simple value or enum value to the specified model type.
  /// </summary>
  /// <param name="value">The Open XML value to convert.</param>
  /// <param name="targetType">The target model type.</param>
  /// <returns>The converted model value, or null if input is null.</returns>
  public static object? ConvertTypeFromOpenXml(object? value, Type targetType)
  {
    //DocumentFormat.OpenXml.Wordprocessing.ViewValues
    if (value == null)
      return null;
    var sourceType = value.GetType();
    if (sourceType.Name.StartsWith("EnumValue`"))
    {
      //var enumType = sourceType.GenericTypeArguments[0];
      var valueStr = value.ToString()!;
      if (targetType.IsEnum)
      {
        var result = Enum.Parse(targetType, valueStr, true);
        return result;
      }
      var implicitOps = targetType.GetMethods(BindingFlags.Public | BindingFlags.Static)
        .Where(m => m.Name == "op_Implicit" && m.ReturnType == targetType).ToArray();
      foreach (var op in implicitOps)
      {
        var parameters = op.GetParameters();
        if (parameters.Length == 1 && parameters[0].ParameterType.IsEnum)
        {
          if (Enum.TryParse(parameters[0].ParameterType, valueStr, true, out var enumValue))
          {
            var result = op.Invoke(null, [enumValue]);
            return result;
          }
        }
      }
    }
    return SimpleValueOpenXmlConverter.ChangeType(value, targetType);
  }
  /// <summary>
  /// Converts a value to its string representation for Open XML text elements.
  /// </summary>
  /// <param name="value">The value to convert to text.</param>
  /// <returns>The string representation of the value.</returns>
  public static string ConvertToText(object? value)
  {
    if (value == null)
      return string.Empty;
    string text;
    if (value is bool boolValue)
      text = boolValue ? "true" : "false";
    else if (value is Guid guidValue)
      text = guidValue.ToString("B").ToUpperInvariant();
    else
      text = (string?)Convert.ChangeType(value, typeof(string)) ?? string.Empty;
    return text;
  }


}