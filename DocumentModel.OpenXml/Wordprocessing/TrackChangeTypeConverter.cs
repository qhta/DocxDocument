namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the TrackChangeType Class converter from/to OpenXml.
///</summary>
public static class TrackChangeTypeConverter
{
  /// <summary>
  /// author
  /// </summary>
  private static String? GetAuthor(DXW.TrackChangeType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Author);
  }
  
  private static bool CmpAuthor(DXW.TrackChangeType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Author, value, diffs, objName, "Author");
  }
  
  private static void SetAuthor(DXW.TrackChangeType openXmlElement, String? value)
  {
    openXmlElement.Author = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// date
  /// </summary>
  private static DateTime? GetDate(DXW.TrackChangeType openXmlElement)
  {
    return openXmlElement?.Date?.Value;
  }
  
  private static bool CmpDate(DXW.TrackChangeType openXmlElement, DateTime? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Date?.Value == value) return true;
    diffs?.Add(objName, "Date", openXmlElement?.Date?.Value, value);
    return false;
  }
  
  private static void SetDate(DXW.TrackChangeType openXmlElement, DateTime? value)
  {
    openXmlElement.Date = value;
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  private static String? GetId(DXW.TrackChangeType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXW.TrackChangeType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "Id");
  }
  
  private static void SetId(DXW.TrackChangeType openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  private static ElementType? CreateModelElement<ElementType>(DXW.TrackChangeType? openXmlElement)
    where ElementType: DMW.TrackChangeType, new()
  {
    if (openXmlElement != null)
    {
      var value = new ElementType();
      value.Author = GetAuthor(openXmlElement);
      value.Date = GetDate(openXmlElement);
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static DMW.CustomXmlInsRangeStart? CreateModelElement(DXW.CustomXmlInsRangeStart? openXmlElement)
  {
    return CreateModelElement<DMW.CustomXmlInsRangeStart>(openXmlElement);
  }

  public static DMW.CustomXmlDelRangeStart? CreateModelElement(DXW.CustomXmlDelRangeStart? openXmlElement)
  {
    return CreateModelElement<DMW.CustomXmlDelRangeStart>(openXmlElement);
  }

  public static DMW.CustomXmlMoveFromRangeStart? CreateModelElement(DXW.CustomXmlMoveFromRangeStart? openXmlElement)
  {
    return CreateModelElement<DMW.CustomXmlMoveFromRangeStart>(openXmlElement);
  }

  public static DMW.CustomXmlMoveToRangeStart? CreateModelElement(DXW.CustomXmlMoveToRangeStart? openXmlElement)
  {
    return CreateModelElement<DMW.CustomXmlMoveToRangeStart>(openXmlElement);
  }

  public static DMW.Inserted? CreateModelElement(DXW.Inserted? openXmlElement)
  {
    return CreateModelElement<DMW.Inserted>(openXmlElement);
  }

  public static DMW.Deleted? CreateModelElement(DXW.Deleted? openXmlElement)
  {
    return CreateModelElement<DMW.Deleted>(openXmlElement);
  }

  public static DMW.MoveFrom? CreateModelElement(DXW.MoveFrom? openXmlElement)
  {
    return CreateModelElement<DMW.MoveFrom>(openXmlElement);
  }

  public static DMW.MoveTo? CreateModelElement(DXW.MoveTo? openXmlElement)
  {
    return CreateModelElement<DMW.MoveTo>(openXmlElement);
  }

  public static DMW.CellInsertion? CreateModelElement(DXW.CellInsertion? openXmlElement)
  {
    return CreateModelElement<DMW.CellInsertion>(openXmlElement);
  }

  public static DMW.CellDeletion? CreateModelElement(DXW.CellDeletion? openXmlElement)
  {
    return CreateModelElement<DMW.CellDeletion>(openXmlElement);
  }

  public static bool CompareModelElement(DXW.TrackChangeType? openXmlElement, DMW.TrackChangeType? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAuthor(openXmlElement, value.Author, diffs, objName))
        ok = false;
      if (!CmpDate(openXmlElement, value.Date, diffs, objName))
        ok = false;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.TrackChangeType value)
    where OpenXmlElementType: DXW.TrackChangeType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXW.TrackChangeType openXmlElement, DMW.TrackChangeType value)
  {
    SetAuthor(openXmlElement, value.Author);
    SetDate(openXmlElement, value.Date);
    SetId(openXmlElement, value.Id);
    return true;
  }
}
