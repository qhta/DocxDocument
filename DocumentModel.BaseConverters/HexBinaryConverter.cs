namespace DocumentModel.OpenXml;

public static class HexBinaryConverter
{
  public static HexBinary? GetValue(DX.TypedOpenXmlLeafElement? openXmlElement)
  {
    var valProperty = openXmlElement?.GetType().GetProperties().FirstOrDefault(item=>item.PropertyType==typeof(HexBinaryValue));
    if (valProperty != null)
    {
      var valPropertyValue = valProperty.GetValue(openXmlElement);
      if (valPropertyValue is string valStr)
        return Convert.FromHexString(valStr);
      if (valPropertyValue is HexBinaryValue hexBinaryValue && hexBinaryValue.Value != null)
        return Convert.FromHexString(hexBinaryValue.Value);
    }
    return null;
  }

  public static HexBinary? GetValue(string? value)
  {
    if (value != null)
      return Convert.FromHexString(value);
    return null;
  }

  public static HexBinaryType? CreateValue<HexBinaryType>(HexBinary? value)
    where HexBinaryType : DX.HexBinaryValue, new()
  {
    if (value != null)
    {
      var element = new HexBinaryType();
      element.Value = Convert.ToHexString(value);
      return element;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(HexBinary? value)
    where OpenXmlElementType : DX.OpenXmlElement, new()
  {
    if (value != null)
    {
      var element = new OpenXmlElementType();
      if (value.Length > 0)
      {
        var valProperty = typeof(OpenXmlElementType).GetProperties().FirstOrDefault(item=>item.PropertyType==typeof(HexBinaryValue));
        if (valProperty != null)
          valProperty.SetValue(element, CreateValue<DX.HexBinaryValue>(value));
      }
      return element;
    }
    return null;
  }
}