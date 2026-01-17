namespace DocumentModel.OpenXml;

public static class OpenXmlElementConverter
{

  public static DX.OpenXmlElement ConvertToOpenXml(object? value, Type openXmlElementType)
  {
    if (openXmlElementType.IsSubclassOf(typeof(DXWP.EmptyType)))
    {
      throw new NotSupportedException($"Conversion to {openXmlElementType.Name} is not supported.");
    }
    if (openXmlElementType.IsSubclassOf(typeof(DXWP.OnOffType)))
    {
      throw new NotSupportedException($"Conversion to {openXmlElementType.Name} is not supported.");
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
      string text;
      if (value is bool boolValue)
        text = boolValue ? "true" : "false";
      else if (value is Guid guidValue)
        text = guidValue.ToString("B").ToUpperInvariant();
      else
        text =(string?)Convert.ChangeType(value, typeof(string)) ?? string.Empty;
      var constructor = openXmlElementType.GetConstructor([typeof(string)]);
      var instance = (DX.OpenXmlElement)constructor!.Invoke([text])!;
      return instance;
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
    throw new NotSupportedException($"Conversion from {element.GetType()} is not supported.");
  }

}