namespace DocumentModel.OpenXml;

/// <summary>
/// Provides conversion methods for simple value types in Open XML elements.
/// </summary>
public static class OpenXmlSimpleValueConverter
{
  /// <summary>
  /// Converts a model object to an Open XML simple type.
  /// </summary>
  /// <param name="modelValue">The model object to convert.</param>
  /// <param name="openXmlType">The target Open XML simple type.</param>
  /// <returns>The converted Open XML simple type.</returns>
  public static object? ConvertToOpenXml(object modelValue, Type openXmlType)
  {
    //DXW.CharacterSpacingControl
    var modelType = modelValue.GetType();

    if (openXmlType == typeof(DX.StringValue))
    {
      string text;
      if (modelValue is bool boolValue)
        text = boolValue ? "true" : "false";
      else if (modelValue is Guid guidValue)
        text = guidValue.ToString("B").ToUpperInvariant();
      else
        text = (string?)Convert.ChangeType(modelValue, typeof(string)) ?? string.Empty;
      return new DX.StringValue(text);
    }
    if (openXmlType.IsSubclassOf(typeof(DXW.StringType)))
    {
      string text = (string?)Convert.ChangeType(modelValue, typeof(string)) ?? string.Empty;
      var stringInstance = (DXW.StringType)Activator.CreateInstance(openXmlType)!;
      stringInstance.Val = new DX.StringValue(text);
      return stringInstance;
    }
    if (openXmlType.IsSubclassOf(typeof(DXW.String253Type)))
    {
      string text = (string?)Convert.ChangeType(modelValue, typeof(string)) ?? string.Empty;
        var string253Instance = (DXW.String253Type)Activator.CreateInstance(openXmlType)!;
      string253Instance.Val = new DX.StringValue(text);
      return string253Instance;
    }
    if (openXmlType.IsSubclassOf(typeof(DX.OpenXmlLeafTextElement)))
    {
      string text = (string?)Convert.ChangeType(modelValue, typeof(string)) ?? string.Empty;
      var openXmlLeafTextElement = (DX.OpenXmlLeafTextElement)Activator.CreateInstance(openXmlType, [text])!;
      return openXmlLeafTextElement;
    }
    if (openXmlType.IsSubclassOf(typeof(DX.OpenXmlLeafElement)))
    {
      var valProperty = openXmlType.GetProperty("Val");
      if (valProperty!=null)
      {
        var openXmlLeafElement = (DX.OpenXmlLeafElement)Activator.CreateInstance(openXmlType)!;
        if (valProperty.PropertyType == typeof(DX.StringValue))
        {
          string text = (string?)Convert.ChangeType(modelValue, typeof(string)) ?? string.Empty;
          valProperty.SetValue(openXmlLeafElement, new DX.StringValue(text));
          return openXmlLeafElement;
        }
        if (valProperty.PropertyType.Name.StartsWith("EnumValue`"))
        {
          var enumValue = (Enum)modelValue;
          var enumVal = EnumValueConverter.CreateOpenXmlElement(enumValue, valProperty.PropertyType);
          valProperty.SetValue(openXmlLeafElement, enumVal);
          return openXmlLeafElement;
        }
        throw new InvalidOperationException($"Unexpected property type {valProperty.PropertyType} for Open XML element {openXmlType}");
      }
    }
    //if (openXmlType == typeof(DX.Int32Value))
    //  return new DX.Int32Value(Convert.ToInt32(modelValue));

    if (modelValue is bool boolValue2)
      return OpenXml.BooleanValueConverter.CreateOpenXmlElement(boolValue2, openXmlType);
    if (modelValue is int intValue)
      return OpenXml.IntValueConverter.CreateOpenXmlElement(intValue, openXmlType);
    if (modelValue is UInt16 uint16Value)
      return OpenXml.IntValueConverter.CreateOpenXmlElement(uint16Value, openXmlType);

    if (modelType.IsEnum)
    {
      return OpenXml.EnumValueConverter.CreateOpenXmlElement(modelValue, openXmlType);
    }

    throw new InvalidOperationException($"Cannot convert {modelValue} of type {modelType} to Open XML simple type {openXmlType}");
  }
  /// <summary>
  /// Converts an Open XML simple type to a model object.
  /// </summary>
  /// <param name="openXmlElement">The Open XML simple type to convert.</param>
  /// <param name="modelType">The target model type.</param>
  /// <returns>The converted model object.</returns>
  public static object? ConvertFromOpenXml(object openXmlElement, Type modelType)
  {
    var openXmlType = openXmlElement.GetType();
    if (openXmlElement is DX.StringValue stringValue)
      return stringValue.Value;

    if (openXmlElement is DXW.StringType stringTypeValue)
      return stringTypeValue.Val?.Value;

    if (openXmlElement is DXW.String253Type string253TypeValue)
      return string253TypeValue.Val?.Value;

    if (openXmlElement is DX.OpenXmlLeafTextElement openXmlLeafTextElement)
      return openXmlLeafTextElement.InnerText;


    if (openXmlElement is DX.OpenXmlLeafElement openXmlLeafElement)
    {
      var valProperty = openXmlType.GetProperty("Val");
      if (valProperty != null)
      {
        var value = valProperty.GetValue(openXmlLeafElement);
        if (value == null)
          return null;
        if (value is DX.StringValue valStringValue)
          return valStringValue.Value;
        if (value.GetType().Name.StartsWith("EnumValue`"))
          return EnumValueConverter.GetEnumValue(value, modelType);
        throw new InvalidOperationException($"Unexpected value type {value?.GetType()} for Open XML element {openXmlLeafElement.GetType()}");
      }
    }

    if (openXmlElement is DX.Int32Value int32Value)
      return int32Value.Value;

    if (openXmlElement is DX.UInt16Value uInt16Value)
      return uInt16Value.Value;

    if (modelType == typeof(bool))
      return openXmlElement.GetBoolValue();

    if (modelType.IsEnum)
    {
      return OpenXml.EnumValueConverter.GetEnumValue(openXmlElement, modelType);
    }
    throw new InvalidOperationException($"Cannot convert {openXmlElement} of type {openXmlType} to model type {modelType.FullName}");
  }
}