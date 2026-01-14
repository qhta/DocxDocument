namespace DocumentModel.OpenXml;

public static class OpenXmlElementConverter
{
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
}