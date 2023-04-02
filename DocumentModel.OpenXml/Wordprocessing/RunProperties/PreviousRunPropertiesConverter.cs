namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// PreviousRunProperties class from/to OpenXmlConverter
/// </summary>
public static class PreviousRunPropertiesConverter
{
  #region PreviousRunProperties model conversion
  public static DMW.PreviousRunProperties? CreateModelElement(DXW.PreviousRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.PreviousRunProperties();
      RunPropertiesBaseConverter.UpdateModelElement(value, openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.PreviousRunProperties? openXmlElement, DMW.PreviousRunProperties? value, DiffList? diffs, string? objName)
  {
    return RunPropertiesBaseConverter.CompareModelElement(openXmlElement, value, diffs, objName);
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
    RunPropertiesBaseConverter.UpdateOpenXmlElement(openXmlElement, value);
  }
  #endregion
}
