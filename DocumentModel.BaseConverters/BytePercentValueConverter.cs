namespace DocumentModel.OpenXml;

public static class BytePercentValueConverter
{
  public static Percent? GetValue(DX.StringValue? element)
  {
    if (element?.Value != null)
      return Percent.FromHexString(element.Value);
    return null;
  }

  public static DX.StringValue? CreateStringValue(Percent? value)
  {
    if (value is not null) return new DX.StringValue(((Percent)value).ToHexString());
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(Percent? value)
    where OpenXmlElementType : DX.OpenXmlElement, new()
  {
    if (value is not null)
    {
      var newValue = new DX.StringValue(((Percent)value).ToHexString());
      var element = new OpenXmlElementType();
      var valProperty = typeof(OpenXmlElementType).GetProperty("Value");
      if (valProperty != null)
        valProperty.SetValue(element, newValue);
      return element;
    }
    return null;
  }
}