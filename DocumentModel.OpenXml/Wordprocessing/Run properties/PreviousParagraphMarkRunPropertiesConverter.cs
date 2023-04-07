namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.PreviousParagraphMarkRunProperties"/> class from/to OpenXml converter.
/// </summary>
public static class PreviousParagraphMarkRunPropertiesConverter
{
  #region PreviousParagraphMarkRunProperties model conversion,
  public static DMW.PreviousParagraphMarkRunProperties? CreateModelElement(DXW.PreviousParagraphMarkRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.PreviousParagraphMarkRunProperties();
      ExtBaseRunPropertiesConverter.UpdateModelElement(value, openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.PreviousParagraphMarkRunProperties? openXmlElement, DMW.PreviousParagraphMarkRunProperties? value, DiffList? diffs, string? objName)
  {
    return ExtBaseRunPropertiesConverter.CompareModelElement(openXmlElement, value, diffs, objName);
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.PreviousParagraphMarkRunProperties value)
    where OpenXmlElementType: DXW.PreviousParagraphMarkRunProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.PreviousParagraphMarkRunProperties value)
  {
    ExtBaseRunPropertiesConverter.UpdateOpenXmlElement(openXmlElement, value);
  }
  #endregion
}
