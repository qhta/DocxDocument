namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the NonVisualInkContentPartProperties Class.
/// </summary>
public static class NonVisualInkContentPartPropertiesConverter
{
  /// <summary>
  /// isComment, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetIsComment(DXO10DCD.NonVisualInkContentPartProperties openXmlElement)
  {
    return openXmlElement?.IsComment?.Value;
  }
  
  private static bool CmpIsComment(DXO10DCD.NonVisualInkContentPartProperties openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.IsComment?.Value == value) return true;
    diffs?.Add(objName, "IsComment", openXmlElement?.IsComment?.Value, value);
    return false;
  }
  
  private static void SetIsComment(DXO10DCD.NonVisualInkContentPartProperties openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.IsComment = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.IsComment = null;
  }
  
  /// <summary>
  /// ContentPartLocks.
  /// </summary>
  private static DMD.ContentPartLocks? GetContentPartLocks(DXO10DCD.NonVisualInkContentPartProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10D.ContentPartLocks>();
    if (element != null)
      return DMXD.ContentPartLocksConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpContentPartLocks(DXO10DCD.NonVisualInkContentPartProperties openXmlElement, DMD.ContentPartLocks? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ContentPartLocksConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10D.ContentPartLocks>(), value, diffs, objName, propName);
  }
  
  private static void SetContentPartLocks(DXO10DCD.NonVisualInkContentPartProperties openXmlElement, DMD.ContentPartLocks? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10D.ContentPartLocks>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ContentPartLocksConverter.CreateOpenXmlElement<DXO10D.ContentPartLocks>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  private static DMD.OfficeArtExtensionList2? GetOfficeArtExtensionList(DXO10DCD.NonVisualInkContentPartProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10D.OfficeArtExtensionList>();
    if (element != null)
      return DMXD.OfficeArtExtensionList2Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOfficeArtExtensionList(DXO10DCD.NonVisualInkContentPartProperties openXmlElement, DMD.OfficeArtExtensionList2? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.OfficeArtExtensionList2Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO10D.OfficeArtExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetOfficeArtExtensionList(DXO10DCD.NonVisualInkContentPartProperties openXmlElement, DMD.OfficeArtExtensionList2? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10D.OfficeArtExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.OfficeArtExtensionList2Converter.CreateOpenXmlElement<DXO10D.OfficeArtExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.NonVisualInkContentPartProperties? CreateModelElement(DXO10DCD.NonVisualInkContentPartProperties? openXmlElement)
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
  
  public static bool CompareModelElement(DXO10DCD.NonVisualInkContentPartProperties? openXmlElement, DMDCDs.NonVisualInkContentPartProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpIsComment(openXmlElement, value.IsComment, diffs, objName, propName))
        ok = false;
      if (!CmpContentPartLocks(openXmlElement, value.ContentPartLocks, diffs, objName, propName))
        ok = false;
      if (!CmpOfficeArtExtensionList(openXmlElement, value.OfficeArtExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.NonVisualInkContentPartProperties value)
    where OpenXmlElementType: DXO10DCD.NonVisualInkContentPartProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10DCD.NonVisualInkContentPartProperties openXmlElement, DMDCDs.NonVisualInkContentPartProperties value)
  {
    SetIsComment(openXmlElement, value?.IsComment);
    SetContentPartLocks(openXmlElement, value?.ContentPartLocks);
    SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
  }
}
