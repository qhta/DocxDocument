namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the CommentId Class.
/// </summary>
public static class CommentIdConverter
{
  #region ParaId conversion.
  private static DM.HexInt? GetParaId(DXO19WCid.CommentId openXmlElement)
  {
    if (openXmlElement?.ParaId?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.ParaId.Value);
    return null;
  }
  
  private static bool CmpParaId(DXO19WCid.CommentId openXmlElement, DM.HexInt? value, DiffList? diffs, string? objName)
  {
    return HexIntConverter.CmpValue(openXmlElement?.ParaId?.Value, value, diffs, objName, "ParaId");
  }
  
  private static void SetParaId(DXO19WCid.CommentId openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.ParaId = value.ToString();
    else
      openXmlElement.ParaId = null;
  }
  #endregion

  #region DurableId conversion.
  private static DM.HexInt? GetDurableId(DXO19WCid.CommentId openXmlElement)
  {
    if (openXmlElement?.DurableId?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.DurableId.Value);
    return null;
  }
  
  private static bool CmpDurableId(DXO19WCid.CommentId openXmlElement, DM.HexInt? value, DiffList? diffs, string? objName)
  {
    return HexIntConverter.CmpValue(openXmlElement?.DurableId?.Value, value, diffs, objName, "DurableId");
  }
  
  private static void SetDurableId(DXO19WCid.CommentId openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.DurableId = value.ToString();
    else
      openXmlElement.DurableId = null;
  }

  public static DMW.CommentId? CreateModelElement(DXO19WCid.CommentId? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.CommentId();
      value.ParaId = GetParaId(openXmlElement);
      value.DurableId = GetDurableId(openXmlElement);
      return value;
    }
    return null;
  }

  public static bool CompareModelElement(DXO19WCid.CommentId? openXmlElement, DMW.CommentId? value, DiffList? diffs, string? objName)
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
    where OpenXmlElementType : DXO19WCid.CommentId, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }

  public static void UpdateOpenXmlElement(DXO19WCid.CommentId openXmlElement, DMW.CommentId value)
  {
    SetParaId(openXmlElement, value?.ParaId);
    SetDurableId(openXmlElement, value?.DurableId);
  }
  #endregion
}
