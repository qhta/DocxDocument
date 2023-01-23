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
    return openXmlElement?.Markup?.Value;
  }
  
  private static bool CmpMarkup(DXW.RevisionView openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Markup?.Value == value;
  }
  
  private static void SetMarkup(DXW.RevisionView openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Markup = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.Markup = null;
  }
  
  /// <summary>
  /// Display Comments
  /// </summary>
  private static Boolean? GetComments(DXW.RevisionView openXmlElement)
  {
    return openXmlElement?.Comments?.Value;
  }
  
  private static bool CmpComments(DXW.RevisionView openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Comments?.Value == value;
  }
  
  private static void SetComments(DXW.RevisionView openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Comments = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.Comments = null;
  }
  
  /// <summary>
  /// Display Content Revisions
  /// </summary>
  private static Boolean? GetDisplayRevision(DXW.RevisionView openXmlElement)
  {
    return openXmlElement?.DisplayRevision?.Value;
  }
  
  private static bool CmpDisplayRevision(DXW.RevisionView openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.DisplayRevision?.Value == value;
  }
  
  private static void SetDisplayRevision(DXW.RevisionView openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.DisplayRevision = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.DisplayRevision = null;
  }
  
  /// <summary>
  /// Display Formatting Revisions
  /// </summary>
  private static Boolean? GetFormatting(DXW.RevisionView openXmlElement)
  {
    return openXmlElement?.Formatting?.Value;
  }
  
  private static bool CmpFormatting(DXW.RevisionView openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Formatting?.Value == value;
  }
  
  private static void SetFormatting(DXW.RevisionView openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Formatting = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.Formatting = null;
  }
  
  /// <summary>
  /// Display Ink Annotations
  /// </summary>
  private static Boolean? GetInkAnnotations(DXW.RevisionView openXmlElement)
  {
    return openXmlElement?.InkAnnotations?.Value;
  }
  
  private static bool CmpInkAnnotations(DXW.RevisionView openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.InkAnnotations?.Value == value;
  }
  
  private static void SetInkAnnotations(DXW.RevisionView openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.InkAnnotations = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.InkAnnotations = null;
  }
  
  public static DMW.RevisionView? CreateModelElement(DXW.RevisionView? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.RevisionView();
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
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.RevisionView? value)
    where OpenXmlElementType: DXW.RevisionView, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetMarkup(openXmlElement, value?.Markup);
      SetComments(openXmlElement, value?.Comments);
      SetDisplayRevision(openXmlElement, value?.DisplayRevision);
      SetFormatting(openXmlElement, value?.Formatting);
      SetInkAnnotations(openXmlElement, value?.InkAnnotations);
      return openXmlElement;
    }
    return default;
  }
}
