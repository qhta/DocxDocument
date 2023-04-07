namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.PreviousRunProperties"/> class from/to OpenXml converter.
/// </summary>
public static class PreviousRunPropertiesConverter
{
  #region PreviousRunProperties model conversion.
  public static DMW.PreviousRunProperties? CreateModelElement(DXW.PreviousRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.PreviousRunProperties();
      ExtBaseRunPropertiesConverter.UpdateModelElement(value, openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.PreviousRunProperties? openXmlElement, DMW.PreviousRunProperties? value, DiffList? diffs, string? objName)
  {
    return ExtBaseRunPropertiesConverter.CompareModelElement(openXmlElement, value, diffs, objName);
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.PreviousRunProperties value)
    where OpenXmlElementType: DXW.PreviousRunProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.PreviousRunProperties openXmlElement, DMW.PreviousRunProperties value)
  {
    ExtBaseRunPropertiesConverter.UpdateOpenXmlElement(openXmlElement, value);
  }
  #endregion
}
