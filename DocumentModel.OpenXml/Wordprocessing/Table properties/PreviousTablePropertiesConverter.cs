namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.PreviousTableProperties"/> class from/to OpenXml converter.
/// </summary>
public static class PreviousTablePropertiesConverter
{
  public static DMW.PreviousTableProperties? CreateModelElement(DX.OpenXmlCompositeElement? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.PreviousTableProperties();
      ExtBaseTablePropertiesConverter.UpdateModelElement(value, openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DX.OpenXmlCompositeElement? openXmlElement, DMW.PreviousTableProperties? value, DiffList? diffs, string? objName)
  {
    return ExtBaseTablePropertiesConverter.CompareModelElement(openXmlElement, value, diffs, objName);
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.PreviousTableProperties value)
    where OpenXmlElementType: DXW.PreviousTableProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DX.OpenXmlCompositeElement openXmlElement, DMW.PreviousTableProperties value)
  {
    ExtBaseTablePropertiesConverter.UpdateOpenXmlElement(openXmlElement, value);
  }
}
