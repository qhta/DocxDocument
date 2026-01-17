namespace DocumentModel.OpenXml;

public static class OpenXmlElementConverter
{

  public static DX.OpenXmlElement ConvertToOpenXml(object? value, Type openXmlElementType)
  {
    if (openXmlElementType.Name == "View")
      Debug.Assert(true); ;
    if (openXmlElementType.IsSubclassOf(typeof(DXWP.EmptyType)))
    {
      throw new NotSupportedException($"Conversion to {openXmlElementType.Name} is not supported.");
    }
    if (openXmlElementType.IsSubclassOf(typeof(DXWP.OnOffType)))
    {
      var onOffValue = value as bool?;
      var onOffElement = (DXWP.OnOffType)Activator.CreateInstance(openXmlElementType)!;
      onOffElement.Val = onOffValue.HasValue ? new DX.OnOffValue(onOffValue.Value) : null;
      return onOffElement;
    }
    if (openXmlElementType.IsSubclassOf(typeof(DXWP.OnOffOnlyType)))
    {
      throw new NotSupportedException($"Conversion to {openXmlElementType.Name} is not supported.");
    }
    if (openXmlElementType.IsSubclassOf(typeof(DXWP.StringType)))
    {
      throw new NotSupportedException($"Conversion to {openXmlElementType.Name} is not supported.");
    }
    if (openXmlElementType.IsSubclassOf(typeof(DXWP.String255Type)))
    {
      throw new NotSupportedException($"Conversion to {openXmlElementType.Name} is not supported.");
    }
    if (openXmlElementType.IsSubclassOf(typeof(DX.OpenXmlLeafTextElement)))
    {
      var constructor = openXmlElementType.GetConstructor([typeof(string)]);
      var instance = (DX.OpenXmlElement)constructor!.Invoke([ConvertToText(value)])!;
      return instance;
    }
    if (openXmlElementType.IsSubclassOf(typeof(DX.OpenXmlLeafElement)))
    {
      var valProperty = openXmlElementType.GetProperty("Val");
      var constructor = openXmlElementType.GetConstructor([]);
      if (valProperty != null)
      {
        var instance = (DX.OpenXmlElement)constructor!.Invoke([])!;
        var convertedValue = ConvertTypeToOpenXml(value, valProperty.PropertyType);
        valProperty.SetValue(instance, convertedValue);
        return instance;
      }
    }
    throw new NotSupportedException($"Conversion to {openXmlElementType.Name} is not supported.");
  }

  public static object? GetObjectByOpenXmlType(this DX.OpenXmlElement element)
  {
    if (element is DXWP.EmptyType)
      return true;
    if (element is DXWP.OnOffType onOffTypeElement)
      return onOffTypeElement.Val?.GetValue();
    if (element is DXWP.OnOffOnlyType onOffOnlyTypeElement)
      return onOffOnlyTypeElement.Val?.GetValue();
    if (element is DXWP.StringType stringTypeElement)
      return stringTypeElement.Val?.Value;
    if (element is DXWP.String255Type string255TypeElement)
      return string255TypeElement.Val?.Value;
    // Add more type conversions as needed

    throw new NotSupportedException($"The OpenXmlElement type '{element.GetType().Name}' is not supported.");
  }

  public static DX.OpenXmlElement? CreateOpenXmlElementByObjectType(string propertyName, object value)
  {
    throw new NotImplementedException();
  }

  public static object? ConvertFromOpenXml(DX.OpenXmlElement element, Type modelType)
  {
    if (element is DXWP.EmptyType)
      return true;
    if (element is DXWP.OnOffType onOffTypeElement)
      return onOffTypeElement.Val?.GetValue();
    if (element is DXWP.OnOffOnlyType onOffOnlyTypeElement)
      return onOffOnlyTypeElement.Val?.GetValue();
    if (element is DXWP.StringType stringTypeElement)
      return stringTypeElement.Val?.Value;
    if (element is DXWP.String255Type string255TypeElement)
      return string255TypeElement.Val?.Value;
    if (element is DX.OpenXmlLeafTextElement leafTextElement)
    {
      var text = leafTextElement.Text;
      if (modelType.IsEnum)
        return Enum.Parse(modelType, text);
      var value = Convert.ChangeType(text, modelType);
      return value;
    }
    if (element is DX.OpenXmlLeafElement leafElement)
    {
      var openXmlElementType = element.GetType();
      var valProperty = openXmlElementType.GetProperty("Val");
      if (valProperty != null)
      {
        var value = valProperty.GetValue(element);
        var convertedValue = ConvertTypeFromOpenXml(value, modelType);
        return convertedValue;
      }

    }
    throw new NotSupportedException($"Conversion from {element.GetType()} is not supported.");
  }

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
      var result = targetType.GetConstructor([enumType])?.Invoke([enumVal]);
      return result;
    }
    return Convert.ChangeType(value, targetType);
  }

  public static object? ConvertTypeFromOpenXml(object? value, Type targetType)
  {
    //DocumentFormat.OpenXml.Wordprocessing.ViewValues
    if (value == null)
      return null;
    var sourceType = value.GetType();
    if (sourceType.Name.StartsWith("EnumValue`") && targetType.IsEnum)
    {
      //var enumType = sourceType.GenericTypeArguments[0];
      var valueStr = value.ToString()!;
      var result = Enum.Parse(targetType, valueStr, true);
      return result;
    }
    return Convert.ChangeType(value, targetType);
  }
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