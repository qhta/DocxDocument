namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the MarkupType Class.
/// </summary>
public static class MarkupTypeConverter
{
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  private static String? GetId(DXW.MarkupType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXW.MarkupType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXW.MarkupType openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  public static ElementType? CreateModelElement<ElementType>(DXW.MarkupType? openXmlElement)
    where ElementType: DMW.MarkupType, new()
  {
    if (openXmlElement != null)
    {
      var value = new ElementType();
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static DMW.CustomXmlMoveFromRangeEnd? CreateModelElement(DXW.CustomXmlMoveFromRangeEnd? openXmlElement)
    => CreateModelElement<DMW.CustomXmlMoveFromRangeEnd>(openXmlElement);

  public static DMW.CustomXmlMoveToRangeEnd? CreateModelElement(DXW.CustomXmlMoveToRangeEnd? openXmlElement)
    => CreateModelElement<DMW.CustomXmlMoveToRangeEnd>(openXmlElement);

  public static DMW.CustomXmlInsRangeEnd? CreateModelElement(DXW.CustomXmlInsRangeEnd? openXmlElement)
  => CreateModelElement<DMW.CustomXmlInsRangeEnd>(openXmlElement);

  public static DMW.CustomXmlDelRangeEnd? CreateModelElement(DXW.CustomXmlDelRangeEnd? openXmlElement)
  => CreateModelElement<DMW.CustomXmlDelRangeEnd>(openXmlElement);

  public static DMW.CommentReference? CreateModelElement(DXW.CommentReference? openXmlElement)
  => CreateModelElement<DMW.CommentReference>(openXmlElement);

  public static bool CompareModelElement(DXW.MarkupType? openXmlElement, DMW.MarkupType? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.MarkupType value)
    where OpenXmlElementType: DXW.MarkupType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static DXW.CustomXmlMoveFromRangeEnd CreateOpenXmlElement(DMW.CustomXmlMoveFromRangeEnd value)
    => CreateOpenXmlElement<DXW.CustomXmlMoveFromRangeEnd>(value);
  
  public static DXW.CustomXmlMoveToRangeEnd CreateOpenXmlElement(DMW.CustomXmlMoveToRangeEnd value)
    => CreateOpenXmlElement<DXW.CustomXmlMoveToRangeEnd>(value);
  
  public static DXW.CustomXmlInsRangeEnd CreateOpenXmlElement(DMW.CustomXmlInsRangeEnd value)
    => CreateOpenXmlElement<DXW.CustomXmlInsRangeEnd>(value);
  
  public static DXW.CustomXmlDelRangeEnd CreateOpenXmlElement(DMW.CustomXmlDelRangeEnd value)
    => CreateOpenXmlElement<DXW.CustomXmlDelRangeEnd>(value);

  public static DXW.CommentReference CreateOpenXmlElement(DMW.CommentReference value)
    => CreateOpenXmlElement<DXW.CommentReference>(value);

  public static bool UpdateOpenXmlElement(DXW.MarkupType openXmlElement, DMW.MarkupType value)
  {
    SetId(openXmlElement, value?.Id);
    return true;
  }
}
