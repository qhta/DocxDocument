namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the CommentEx Class.
/// </summary>
public static class CommentExConverter
{
  /// <summary>
  /// paraId, this property is only available in Office 2013 and later.
  /// </summary>
  private static DM.HexInt? GetParaId(DXO2013W.CommentEx openXmlElement)
  {
    if (openXmlElement?.ParaId?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.ParaId.Value);
    return null;
  }
  
  private static bool CmpParaId(DXO2013W.CommentEx openXmlElement, DM.HexInt? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ParaId?.Value != null)
      if (HexIntConverter.GetValue(openXmlElement.ParaId.Value) == value)
        return true;
    if (openXmlElement == null && openXmlElement?.ParaId?.Value == null && value == null) return true;
    diffs?.Add(objName, "ParaId", openXmlElement?.ParaId?.Value, value);
    return false;
  }
  
  private static void SetParaId(DXO2013W.CommentEx openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.ParaId = value.ToString();
    else
      openXmlElement.ParaId = null;
  }
  
  /// <summary>
  /// paraIdParent, this property is only available in Office 2013 and later.
  /// </summary>
  private static DM.HexInt? GetParaIdParent(DXO2013W.CommentEx openXmlElement)
  {
    if (openXmlElement?.ParaIdParent?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.ParaIdParent.Value);
    return null;
  }
  
  private static bool CmpParaIdParent(DXO2013W.CommentEx openXmlElement, DM.HexInt? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ParaIdParent?.Value != null)
      if (HexIntConverter.GetValue(openXmlElement.ParaIdParent.Value) == value)
        return true;
    if (openXmlElement == null && openXmlElement?.ParaIdParent?.Value == null && value == null) return true;
    diffs?.Add(objName, "ParaIdParent", openXmlElement?.ParaIdParent?.Value, value);
    return false;
  }
  
  private static void SetParaIdParent(DXO2013W.CommentEx openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.ParaIdParent = value.ToString();
    else
      openXmlElement.ParaIdParent = null;
  }
  
  /// <summary>
  /// done, this property is only available in Office 2013 and later.
  /// </summary>
  private static Boolean? GetDone(DXO2013W.CommentEx openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.Done);
  }
  
  private static bool CmpDone(DXO2013W.CommentEx openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.Done, value, diffs, objName, "Done");
  }
  
  private static void SetDone(DXO2013W.CommentEx openXmlElement, Boolean? value)
  {
    openXmlElement.Done = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  public static DocumentModel.Wordprocessing.CommentEx? CreateModelElement(DXO2013W.CommentEx? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.CommentEx();
      value.ParaId = GetParaId(openXmlElement);
      value.ParaIdParent = GetParaIdParent(openXmlElement);
      value.Done = GetDone(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2013W.CommentEx? openXmlElement, DMW.CommentEx? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpParaId(openXmlElement, value.ParaId, diffs, objName))
        ok = false;
      if (!CmpParaIdParent(openXmlElement, value.ParaIdParent, diffs, objName))
        ok = false;
      if (!CmpDone(openXmlElement, value.Done, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.CommentEx value)
    where OpenXmlElementType: DXO2013W.CommentEx, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2013W.CommentEx openXmlElement, DMW.CommentEx value)
  {
    SetParaId(openXmlElement, value?.ParaId);
    SetParaIdParent(openXmlElement, value?.ParaIdParent);
    SetDone(openXmlElement, value?.Done);
  }
}
