namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.DefaultParagraphProperties"/> class from/to OpenXml converter.
/// </summary>
public static class DefaultParagraphPropertiesConverter
{
  #region DefaultParagraphProperties model conversion.
  public static DMW.DefaultParagraphProperties? CreateModelElement(DXW.ParagraphPropertiesDefault? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.DefaultParagraphProperties();
      BaseParagraphPropertiesConverter.UpdateModelElement(value, openXmlElement);
      return value;
    }
    return null;
  }

  public static bool CompareModelElement(DXW.ParagraphPropertiesDefault? openXmlElement, DMW.DefaultParagraphProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!BaseParagraphPropertiesConverter.CompareModelElement(openXmlElement, value, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
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
    BaseParagraphPropertiesConverter.UpdateOpenXmlElement(openXmlElement, value);
  }
  #endregion
}
