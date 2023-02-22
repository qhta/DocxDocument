namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the CommentId Class.
/// </summary>
public static class CommentIdConverter
{
  /// <summary>
  /// paraId, this property is only available in Office 2019 and later.
  /// </summary>
  private static DM.HexInt? GetParaId(DXO2019WCid.CommentId openXmlElement)
  {
    if (openXmlElement?.ParaId?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.ParaId.Value);
    return null;
  }
  
  private static bool CmpParaId(DXO2019WCid.CommentId openXmlElement, DM.HexInt? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ParaId?.Value != null)
      if (HexIntConverter.GetValue(openXmlElement.ParaId.Value) == value)
        return true;
    if (openXmlElement == null && openXmlElement?.ParaId?.Value == null && value == null) return true;
    diffs?.Add(objName, "ParaId", openXmlElement?.ParaId?.Value, value);
    return false;
  }
  
  private static void SetParaId(DXO2019WCid.CommentId openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.ParaId = value.ToString();
    else
      openXmlElement.ParaId = null;
  }
  
  /// <summary>
  /// durableId, this property is only available in Office 2019 and later.
  /// </summary>
  private static DM.HexInt? GetDurableId(DXO2019WCid.CommentId openXmlElement)
  {
    if (openXmlElement?.DurableId?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.DurableId.Value);
    return null;
  }
  
  private static bool CmpDurableId(DXO2019WCid.CommentId openXmlElement, DM.HexInt? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.DurableId?.Value != null)
      if (HexIntConverter.GetValue(openXmlElement.DurableId.Value) == value)
        return true;
    if (openXmlElement == null && openXmlElement?.DurableId?.Value == null && value == null) return true;
    diffs?.Add(objName, "DurableId", openXmlElement?.DurableId?.Value, value);
    return false;
  }
  
  private static void SetDurableId(DXO2019WCid.CommentId openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.DurableId = value.ToString();
    else
      openXmlElement.DurableId = null;
  }
  
  public static DocumentModel.Wordprocessing.CommentId? CreateModelElement(DXO2019WCid.CommentId? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.CommentId();
      value.ParaId = GetParaId(openXmlElement);
      value.DurableId = GetDurableId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2019WCid.CommentId? openXmlElement, DMW.CommentId? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpParaId(openXmlElement, value.ParaId, diffs, objName))
        ok = false;
      if (!CmpDurableId(openXmlElement, value.DurableId, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.CommentId value)
    where OpenXmlElementType: DXO2019WCid.CommentId, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2019WCid.CommentId openXmlElement, DMW.CommentId value)
  {
    SetParaId(openXmlElement, value?.ParaId);
    SetDurableId(openXmlElement, value?.DurableId);
  }
}
