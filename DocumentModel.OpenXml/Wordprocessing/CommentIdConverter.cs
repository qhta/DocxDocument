namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the CommentId Class.
/// </summary>
public static class CommentIdConverter
{
  /// <summary>
  /// paraId, this property is only available in Office 2019 and later.
  /// </summary>
  private static UInt32? GetParaId(DXO2019WCid.CommentId openXmlElement)
  {
    if (openXmlElement.ParaId?.Value != null)
      return UInt32.Parse(openXmlElement.ParaId.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static void SetParaId(DXO2019WCid.CommentId openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.ParaId = ((UInt32)value).ToString("X8");
      else
        openXmlElement.ParaId = null;
  }
  
  /// <summary>
  /// durableId, this property is only available in Office 2019 and later.
  /// </summary>
  private static UInt32? GetDurableId(DXO2019WCid.CommentId openXmlElement)
  {
    if (openXmlElement.DurableId?.Value != null)
      return UInt32.Parse(openXmlElement.DurableId.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static void SetDurableId(DXO2019WCid.CommentId openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.DurableId = ((UInt32)value).ToString("X8");
      else
        openXmlElement.DurableId = null;
  }
  
  public static DMW.CommentId? CreateModelElement(DXO2019WCid.CommentId? openXmlElement)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.CommentId? value)
    where OpenXmlElementType: DXO2019WCid.CommentId, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetParaId(openXmlElement, value?.ParaId);
      SetDurableId(openXmlElement, value?.DurableId);
      return openXmlElement;
    }
    return default;
  }
}
