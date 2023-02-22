namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Visibility of Annotation Types.
/// </summary>
public static class RevisionViewConverter
{
  /// <summary>
  /// Display Visual Indicator Of Markup Area
  /// </summary>
  private static Boolean? GetMarkup(DXW.RevisionView openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.Markup);
  }
  
  private static bool CmpMarkup(DXW.RevisionView openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.Markup, value, diffs, objName, "Markup");
  }
  
  private static void SetMarkup(DXW.RevisionView openXmlElement, Boolean? value)
  {
    openXmlElement.Markup = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// Display Comments
  /// </summary>
  private static Boolean? GetComments(DXW.RevisionView openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.Comments);
  }
  
  private static bool CmpComments(DXW.RevisionView openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.Comments, value, diffs, objName, "Comments");
  }
  
  private static void SetComments(DXW.RevisionView openXmlElement, Boolean? value)
  {
    openXmlElement.Comments = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// Display Content Revisions
  /// </summary>
  private static Boolean? GetDisplayRevision(DXW.RevisionView openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.DisplayRevision);
  }
  
  private static bool CmpDisplayRevision(DXW.RevisionView openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.DisplayRevision, value, diffs, objName, "DisplayRevision");
  }
  
  private static void SetDisplayRevision(DXW.RevisionView openXmlElement, Boolean? value)
  {
    openXmlElement.DisplayRevision = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// Display Formatting Revisions
  /// </summary>
  private static Boolean? GetFormatting(DXW.RevisionView openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.Formatting);
  }
  
  private static bool CmpFormatting(DXW.RevisionView openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.Formatting, value, diffs, objName, "Formatting");
  }
  
  private static void SetFormatting(DXW.RevisionView openXmlElement, Boolean? value)
  {
    openXmlElement.Formatting = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// Display Ink Annotations
  /// </summary>
  private static Boolean? GetInkAnnotations(DXW.RevisionView openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.InkAnnotations);
  }
  
  private static bool CmpInkAnnotations(DXW.RevisionView openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.InkAnnotations, value, diffs, objName, "InkAnnotations");
  }
  
  private static void SetInkAnnotations(DXW.RevisionView openXmlElement, Boolean? value)
  {
    openXmlElement.InkAnnotations = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  public static DocumentModel.Wordprocessing.RevisionView? CreateModelElement(DXW.RevisionView? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.RevisionView();
      value.Markup = GetMarkup(openXmlElement);
      value.Comments = GetComments(openXmlElement);
      value.DisplayRevision = GetDisplayRevision(openXmlElement);
      value.Formatting = GetFormatting(openXmlElement);
      value.InkAnnotations = GetInkAnnotations(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.RevisionView? openXmlElement, DMW.RevisionView? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpMarkup(openXmlElement, value.Markup, diffs, objName))
        ok = false;
      if (!CmpComments(openXmlElement, value.Comments, diffs, objName))
        ok = false;
      if (!CmpDisplayRevision(openXmlElement, value.DisplayRevision, diffs, objName))
        ok = false;
      if (!CmpFormatting(openXmlElement, value.Formatting, diffs, objName))
        ok = false;
      if (!CmpInkAnnotations(openXmlElement, value.InkAnnotations, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.RevisionView value)
    where OpenXmlElementType: DXW.RevisionView, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.RevisionView openXmlElement, DMW.RevisionView value)
  {
    SetMarkup(openXmlElement, value?.Markup);
    SetComments(openXmlElement, value?.Comments);
    SetDisplayRevision(openXmlElement, value?.DisplayRevision);
    SetFormatting(openXmlElement, value?.Formatting);
    SetInkAnnotations(openXmlElement, value?.InkAnnotations);
    }
  }
