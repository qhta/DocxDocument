namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the MarkupRangeType Class.
/// </summary>
public static class MarkupRangeTypeConverter
{
  /// <summary>
  ///   displacedByCustomXml
  /// </summary>
  private static DMW.DisplacedByCustomXmlKind? GetDisplacedByCustomXml(DXW.MarkupRangeType openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.DisplacedByCustomXmlValues, DMW.DisplacedByCustomXmlKind>(openXmlElement?.DisplacedByCustomXml?.Value);
  }

  private static bool CmpDisplacedByCustomXml(DXW.MarkupRangeType openXmlElement,DMW. DisplacedByCustomXmlKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DXW.DisplacedByCustomXmlValues, DMW.DisplacedByCustomXmlKind>(openXmlElement?.DisplacedByCustomXml?.Value, value, diffs, objName?.Concat2(".", openXmlElement?.GetType().Name));
  }

  private static void SetDisplacedByCustomXml(DXW.MarkupRangeType openXmlElement, DMW.DisplacedByCustomXmlKind? value)
  {
    openXmlElement.DisplacedByCustomXml = EnumValueConverter.CreateEnumValue<DXW.DisplacedByCustomXmlValues, DMW.DisplacedByCustomXmlKind>(value);
  }

  /// <summary>
  ///   Annotation Identifier
  /// </summary>
  private static String? GetId(DXW.MarkupRangeType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }

  private static bool CmpId(DXW.MarkupRangeType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "Id");
  }

  private static void SetId(DXW.MarkupRangeType openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }

  private static ElementType? CreateModelElement<ElementType>(DXW.MarkupRangeType? openXmlElement)
    where ElementType : DMW.MarkupRangeType, new()
  {
    if (openXmlElement != null)
    {
      var value = new ElementType();
      value.DisplacedByCustomXml = GetDisplacedByCustomXml(openXmlElement);
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }

  public static DMW.BookmarkEnd? CreateModelElement(DXW.BookmarkEnd? openXmlElement)
  {
    return CreateModelElement<DMW.BookmarkEnd>(openXmlElement);
  }

  public static DMW.CommentRangeStart? CreateModelElement(DXW.CommentRangeStart? openXmlElement)
  {
    return CreateModelElement<DMW.CommentRangeStart>(openXmlElement);
  }

  public static DMW.CommentRangeEnd? CreateModelElement(DXW.CommentRangeEnd? openXmlElement)
  {
    return CreateModelElement<DMW.CommentRangeEnd>(openXmlElement);
  }

  public static DMW.MoveToRangeEnd? CreateModelElement(DXW.MoveToRangeEnd? openXmlElement)
  {
    return CreateModelElement<DMW.MoveToRangeEnd>(openXmlElement);
  }

  public static DMW.MoveFromRangeEnd? CreateModelElement(DXW.MoveFromRangeEnd? openXmlElement)
  {
    return CreateModelElement<DMW.MoveFromRangeEnd>(openXmlElement);
  }

  public static bool CompareModelElement(DXW.MarkupRangeType? openXmlElement, DMW.MarkupRangeType? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDisplacedByCustomXml(openXmlElement, value.DisplacedByCustomXml, diffs, objName))
        ok = false;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.MarkupRangeType value)
    where OpenXmlElementType : DXW.MarkupRangeType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }

  public static DXW.BookmarkEnd CreateOpenXmlElement(DMW.BookmarkEnd value)
    => CreateOpenXmlElement<DXW.BookmarkEnd>(value);

  public static DXW.CommentRangeStart CreateOpenXmlElement(DMW.CommentRangeStart value)
    => CreateOpenXmlElement<DXW.CommentRangeStart>(value);

  public static DXW.CommentRangeEnd CreateOpenXmlElement(DMW.CommentRangeEnd value)
    => CreateOpenXmlElement<DXW.CommentRangeEnd>(value);

  public static DXW.MoveFromRangeEnd CreateOpenXmlElement(DMW.MoveFromRangeEnd value)
    => CreateOpenXmlElement<DXW.MoveFromRangeEnd>(value);

  public static DXW.MoveToRangeEnd CreateOpenXmlElement(DMW.MoveToRangeEnd value)
    => CreateOpenXmlElement<DXW.MoveToRangeEnd>(value);

  public static void UpdateOpenXmlElement(DXW.MarkupRangeType openXmlElement, DMW.MarkupRangeType value)
  {
    SetDisplacedByCustomXml(openXmlElement, value?.DisplacedByCustomXml);
    SetId(openXmlElement, value?.Id);
  }
}