namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the CommentEx Class.
/// </summary>
public static class CommentExConverter
{
  #region ParaId conversion.
  private static DM.HexInt? GetParaId(DXO13W.CommentEx openXmlElement)
  {
    if (openXmlElement?.ParaId?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.ParaId.Value);
    return null;
  }
  
  private static bool CmpParaId(DXO13W.CommentEx openXmlElement, DM.HexInt? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return HexIntConverter.CmpValue(openXmlElement?.ParaId?.Value, value, diffs, objName, "ParaId");
  }
  
  private static void SetParaId(DXO13W.CommentEx openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.ParaId = value.ToString();
    else
      openXmlElement.ParaId = null;
  }
  #endregion

  #region ParaIdParent conversion.
  private static DM.HexInt? GetParaIdParent(DXO13W.CommentEx openXmlElement)
  {
    if (openXmlElement?.ParaIdParent?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.ParaIdParent.Value);
    return null;
  }
  
  private static bool CmpParaIdParent(DXO13W.CommentEx openXmlElement, DM.HexInt? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return HexIntConverter.CmpValue(openXmlElement?.ParaIdParent?.Value, value, diffs, objName, "ParaIdParent");
  }
  
  private static void SetParaIdParent(DXO13W.CommentEx openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.ParaIdParent = value.ToString();
    else
      openXmlElement.ParaIdParent = null;
  }
  #endregion

  #region Done conversion.
  private static Boolean? GetDone(DXO13W.CommentEx openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.Done);
  }
  
  private static bool CmpDone(DXO13W.CommentEx openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.Done, value, diffs, objName, "Done");
  }
  
  private static void SetDone(DXO13W.CommentEx openXmlElement, Boolean? value)
  {
    openXmlElement.Done = BooleanValueConverter.CreateOnOffValue(value);
  }
  #endregion

  #region CommentEx model conversion.
  public static DMW.CommentEx? CreateModelElement(DXO13W.CommentEx? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.CommentEx();
      value.ParaId = GetParaId(openXmlElement);
      value.ParaIdParent = GetParaIdParent(openXmlElement);
      value.Done = GetDone(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO13W.CommentEx? openXmlElement, DMW.CommentEx? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpParaId(openXmlElement, value.ParaId, diffs, objName, propName))
        ok = false;
      if (!CmpParaIdParent(openXmlElement, value.ParaIdParent, diffs, objName, propName))
        ok = false;
      if (!CmpDone(openXmlElement, value.Done, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.CommentEx value)
    where OpenXmlElementType: DXO13W.CommentEx, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO13W.CommentEx openXmlElement, DMW.CommentEx value)
  {
    SetParaId(openXmlElement, value?.ParaId);
    SetParaIdParent(openXmlElement, value?.ParaIdParent);
    SetDone(openXmlElement, value?.Done);
  }
  #endregion
}
