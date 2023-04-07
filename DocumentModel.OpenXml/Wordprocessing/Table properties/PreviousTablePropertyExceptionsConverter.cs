namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.PreviousTablePropertyExceptions"/> class from/to OpenXml converter.
/// </summary>
public static class PreviousTablePropertyExceptionsConverter
{
  public static DMW.PreviousTablePropertyExceptions? CreateModelElement(DXW.PreviousTablePropertyExceptions? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.PreviousTablePropertyExceptions();
      BaseTablePropertiesConverter.UpdateModelElement(value, openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.PreviousTablePropertyExceptions? openXmlElement, DMW.PreviousTablePropertyExceptions? value, DiffList? diffs, string? objName)
  {
    return BaseTablePropertiesConverter.CompareModelElement(openXmlElement, value, diffs, objName);
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.PreviousTablePropertyExceptions value)
    where OpenXmlElementType: DXW.PreviousTablePropertyExceptions, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.PreviousTablePropertyExceptions openXmlElement, DMW.PreviousTablePropertyExceptions value)
  {
    BaseTablePropertiesConverter.UpdateOpenXmlElement(openXmlElement, value);
  }
}
