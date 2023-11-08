namespace DocumentModel.OpenXml;

public static class ByteArrayConverter
{
  public static byte[]? GetValue(DX.TypedOpenXmlLeafElement? element)
  {
    var valProperty = element?.GetType().GetProperty("Value");
    if (valProperty != null)
    {
      var value = (string?)valProperty.GetValue(element);
      if (value != null)
      {
        if (valProperty.PropertyType == typeof(DX.HexBinaryValue))
          return Convert.FromHexString(value);
        if (valProperty.PropertyType == typeof(DX.Base64BinaryValue))
          return Convert.FromBase64String(value);
        throw new InvalidOperationException($"ByteArrayConverter can get value only from DX.HexBinaryValue or DX.Base64BinaryValue but \"{valProperty.PropertyType}\" type occured");
      }
    }
    return null;
  }

  public static byte[]? GetValue(string? value)
  {
    if (value != null)
      return Convert.FromHexString(value);
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(byte[]? value)
    where OpenXmlElementType : DX.OpenXmlElement, new()
  {
    if (value != null)
    {
      var element = new OpenXmlElementType();
      var valProperty = typeof(OpenXmlElementType).GetProperty("Value");
      if (valProperty != null)
      {
        if (valProperty.PropertyType == typeof(DX.HexBinaryValue))
          valProperty.SetValue(element, Convert.ToHexString(value));
        else if (valProperty.PropertyType == typeof(DX.Base64BinaryValue))
          valProperty.SetValue(element, Convert.ToBase64String(value));
        else
          throw new InvalidOperationException(
            $"ByteArrayConverter can set value only to DX.HexBinaryValue or DX.Base64BinaryValue but \"{valProperty.PropertyType}\" type occured");
      }
      return element;
    }
    return null;
  }
}