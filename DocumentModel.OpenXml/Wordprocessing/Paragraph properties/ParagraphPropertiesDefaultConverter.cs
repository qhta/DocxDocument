namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// ParagraphPropertiesDefault class from/to OpenXml converter.
/// </summary>
public static class ParagraphPropertiesDefaultConverter
{
  #region ParagraphPropertiesDefault model conversion.
  public static DMW.DefaultParagraphProperties? CreateModelElement(DXW.ParagraphPropertiesDefault? openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.ParagraphPropertiesBaseStyle>();
    if (element != null)
    {
      var value = new DMW.DefaultParagraphProperties();
      ParagraphPropertiesBaseStyleConverter.UpdateModelElement(value, element);
      return value;
    }
    return null;
  }

  public static bool CompareModelElement(DXW.ParagraphPropertiesDefault? openXmlElement, DMW.DefaultParagraphProperties? value, DiffList? diffs, string? objName)
  {
    var element = openXmlElement?.GetFirstChild<DXW.ParagraphPropertiesBaseStyle>();
    if (element != null && value != null)
    {
      var ok = true;
      if (!ParagraphPropertiesBaseStyleConverter.CompareModelElement(element, value, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  public static DXW.ParagraphPropertiesDefault CreateOpenXmlElement(DMW.DefaultParagraphProperties value)
  {
    var openXmlElement = new DXW.ParagraphPropertiesDefault();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }

  public static void UpdateOpenXmlElement(DXW.ParagraphPropertiesDefault openXmlElement, DMW.DefaultParagraphProperties value)
  {
    var element = openXmlElement.GetFirstChild<DXW.ParagraphPropertiesBaseStyle>();
    if (element != null)
      ParagraphPropertiesBaseStyleConverter.UpdateOpenXmlElement(element, value);
    else
    {
      element = ParagraphPropertiesBaseStyleConverter.CreateOpenXmlElement(value);
      openXmlElement.AddChild(element);
    }
  }
  #endregion
}
