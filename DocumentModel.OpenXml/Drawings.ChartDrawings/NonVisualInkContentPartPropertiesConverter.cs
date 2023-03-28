namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the NonVisualInkContentPartProperties Class.
/// </summary>
public static class NonVisualInkContentPartPropertiesConverter
{
  /// <summary>
  /// isComment, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetIsComment(DXO2010DrawChartDraw.NonVisualInkContentPartProperties openXmlElement)
  {
    return openXmlElement?.IsComment?.Value;
  }
  
  private static bool CmpIsComment(DXO2010DrawChartDraw.NonVisualInkContentPartProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.IsComment?.Value == value) return true;
    diffs?.Add(objName, "IsComment", openXmlElement?.IsComment?.Value, value);
    return false;
  }
  
  private static void SetIsComment(DXO2010DrawChartDraw.NonVisualInkContentPartProperties openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.IsComment = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.IsComment = null;
  }
  
  /// <summary>
  /// ContentPartLocks.
  /// </summary>
  private static DMDraws.ContentPartLocks? GetContentPartLocks(DXO2010DrawChartDraw.NonVisualInkContentPartProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010Draw.ContentPartLocks>();
    if (element != null)
      return DMXDraws.ContentPartLocksConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpContentPartLocks(DXO2010DrawChartDraw.NonVisualInkContentPartProperties openXmlElement, DMDraws.ContentPartLocks? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ContentPartLocksConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010Draw.ContentPartLocks>(), value, diffs, objName);
  }
  
  private static void SetContentPartLocks(DXO2010DrawChartDraw.NonVisualInkContentPartProperties openXmlElement, DMDraws.ContentPartLocks? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010Draw.ContentPartLocks>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ContentPartLocksConverter.CreateOpenXmlElement<DXO2010Draw.ContentPartLocks>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  private static DMDraws.OfficeArtExtensionList2? GetOfficeArtExtensionList(DXO2010DrawChartDraw.NonVisualInkContentPartProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010Draw.OfficeArtExtensionList>();
    if (element != null)
      return DMXDraws.OfficeArtExtensionList2Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOfficeArtExtensionList(DXO2010DrawChartDraw.NonVisualInkContentPartProperties openXmlElement, DMDraws.OfficeArtExtensionList2? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.OfficeArtExtensionList2Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010Draw.OfficeArtExtensionList>(), value, diffs, objName);
  }
  
  private static void SetOfficeArtExtensionList(DXO2010DrawChartDraw.NonVisualInkContentPartProperties openXmlElement, DMDraws.OfficeArtExtensionList2? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010Draw.OfficeArtExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.OfficeArtExtensionList2Converter.CreateOpenXmlElement<DXO2010Draw.OfficeArtExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.NonVisualInkContentPartProperties? CreateModelElement(DXO2010DrawChartDraw.NonVisualInkContentPartProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.NonVisualInkContentPartProperties();
      value.IsComment = GetIsComment(openXmlElement);
      value.ContentPartLocks = GetContentPartLocks(openXmlElement);
      value.OfficeArtExtensionList = GetOfficeArtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010DrawChartDraw.NonVisualInkContentPartProperties? openXmlElement, DMDrawsChartDraws.NonVisualInkContentPartProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpIsComment(openXmlElement, value.IsComment, diffs, objName))
        ok = false;
      if (!CmpContentPartLocks(openXmlElement, value.ContentPartLocks, diffs, objName))
        ok = false;
      if (!CmpOfficeArtExtensionList(openXmlElement, value.OfficeArtExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.NonVisualInkContentPartProperties value)
    where OpenXmlElementType: DXO2010DrawChartDraw.NonVisualInkContentPartProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2010DrawChartDraw.NonVisualInkContentPartProperties openXmlElement, DMDrawsChartDraws.NonVisualInkContentPartProperties value)
  {
    SetIsComment(openXmlElement, value?.IsComment);
    SetContentPartLocks(openXmlElement, value?.ContentPartLocks);
    SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
  }
}
