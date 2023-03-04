namespace DocumentModel.OpenXml;

/// <summary>
/// AlternateContent element converter
/// </summary>
public static class AlternateContentConverter
{
  #region AlternateContentChoice
  private static AlternateContentChoice? GetAlternateContentChoice(DX.AlternateContent openXmlElement)
  {
    return AlternateContentChoiceConverter.CreateModelElement(openXmlElement.GetFirstChild<DX.AlternateContentChoice>());
  }

  private static bool CmpAlternateContentChoice(DX.AlternateContent openXmlElement, DM.AlternateContentChoice? value, DiffList? diffs, string? objName)
  {
    return AlternateContentChoiceConverter.CompareModelElement(openXmlElement.GetFirstChild<DX.AlternateContentChoice>(), value, diffs, objName);
  }

  private static void SetAlternateContentChoice(DX.AlternateContent openXmlElement, DM.AlternateContentChoice? value)
  {
    var element = openXmlElement.GetFirstChild<DX.AlternateContentChoice>();
    if (element != null && value != null)
      AlternateContentChoiceConverter.UpdateOpenXmlElement(element, value);
    else
    {
      if (element!=null)
        element.Remove();
      if (value != null)
      {
        var newElement = AlternateContentChoiceConverter.CreateOpenXmlElement(value);
        if (newElement != null)
          openXmlElement.AddChild(newElement);
      }
    }
  }
  #endregion

  #region AlternateContentFallback
  private static AlternateContentFallback? GetAlternateContentFallback(DX.AlternateContent openXmlElement)
  {
    return AlternateContentFallbackConverter.CreateModelElement(openXmlElement.GetFirstChild<DX.AlternateContentFallback>());
  }

  private static bool CmpAlternateContentFallback(DX.AlternateContent openXmlElement, DM.AlternateContentFallback? value, DiffList? diffs, string? objName)
  {
    return AlternateContentFallbackConverter.CompareModelElement(openXmlElement.GetFirstChild<DX.AlternateContentFallback>(), value, diffs, objName);
  }

  private static void SetAlternateContentFallback(DX.AlternateContent openXmlElement, DM.AlternateContentFallback? value)
  {
    var element = openXmlElement.GetFirstChild<DX.AlternateContentFallback>();
    if (element != null && value != null)
      AlternateContentFallbackConverter.UpdateOpenXmlElement(element, value);
    else
    {
      if (element!=null)
        element.Remove();
      if (value != null)
      {
        var newElement = AlternateContentFallbackConverter.CreateOpenXmlElement(value);
        if (newElement != null)
          openXmlElement.AddChild(newElement);
      }
    }
  }
  #endregion

  #region AlternateContent element conversion
  public static DM.AlternateContent? CreateModelElement(DX.AlternateContent? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DM.AlternateContent();
      value.Choice = GetAlternateContentChoice(openXmlElement);
      //value.Fallback = GetAlternateContentFallback(openXmlElement);
      return value;
    }
    return null;
  }

  public static bool CompareModelElement(DX.AlternateContent? openXmlElement, DM.AlternateContent? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAlternateContentChoice(openXmlElement, value.Choice, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  public static DX.AlternateContent CreateOpenXmlElement(DM.AlternateContent value)
  {
    var openXmlElement = new DX.AlternateContent();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }

  public static void UpdateOpenXmlElement(DX.AlternateContent openXmlElement, DM.AlternateContent value)
  {
    SetAlternateContentChoice(openXmlElement, value.Choice);
  }
  #endregion
}
