namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the CommentEx Class.
/// </summary>
public static class CommentExConverter
{
  /// <summary>
  /// paraId, this property is only available in Office 2013 and later.
  /// </summary>
  private static UInt32? GetParaId(DXO2013W.CommentEx openXmlElement)
  {
    if (openXmlElement.ParaId?.Value != null)
      return UInt32.Parse(openXmlElement.ParaId.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static void SetParaId(DXO2013W.CommentEx openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.ParaId = ((UInt32)value).ToString("X8");
      else
        openXmlElement.ParaId = null;
  }
  
  /// <summary>
  /// paraIdParent, this property is only available in Office 2013 and later.
  /// </summary>
  private static UInt32? GetParaIdParent(DXO2013W.CommentEx openXmlElement)
  {
    if (openXmlElement.ParaIdParent?.Value != null)
      return UInt32.Parse(openXmlElement.ParaIdParent.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static void SetParaIdParent(DXO2013W.CommentEx openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.ParaIdParent = ((UInt32)value).ToString("X8");
      else
        openXmlElement.ParaIdParent = null;
  }
  
  /// <summary>
  /// done, this property is only available in Office 2013 and later.
  /// </summary>
  private static Boolean? GetDone(DXO2013W.CommentEx openXmlElement)
  {
    return openXmlElement?.Done?.Value;
  }
  
  private static void SetDone(DXO2013W.CommentEx openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Done = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.Done = null;
  }
  
  public static DMW.CommentEx? CreateModelElement(DXO2013W.CommentEx? openXmlElement)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.CommentEx? value)
    where OpenXmlElementType: DXO2013W.CommentEx, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetParaId(openXmlElement, value?.ParaId);
      SetParaIdParent(openXmlElement, value?.ParaIdParent);
      SetDone(openXmlElement, value?.Done);
      return openXmlElement;
    }
    return default;
  }
}
