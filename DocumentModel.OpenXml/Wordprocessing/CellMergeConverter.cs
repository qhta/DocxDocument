namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Vertically Merged/Split Table Cells.
/// </summary>
public static class CellMergeConverter
{
  /// <summary>
  /// vMerge
  /// </summary>
  private static DMW.VerticalMergeRevisionKind? GetVerticalMerge(DXW.CellMerge openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.VerticalMergeRevisionValues, DMW.VerticalMergeRevisionKind>(openXmlElement?.VerticalMerge?.Value);
  }
  
  private static void SetVerticalMerge(DXW.CellMerge openXmlElement, DMW.VerticalMergeRevisionKind? value)
  {
    openXmlElement.VerticalMerge = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.VerticalMergeRevisionValues, DMW.VerticalMergeRevisionKind>(value);
  }
  
  /// <summary>
  /// vMergeOrig
  /// </summary>
  private static DMW.VerticalMergeRevisionKind? GetVerticalMergeOriginal(DXW.CellMerge openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.VerticalMergeRevisionValues, DMW.VerticalMergeRevisionKind>(openXmlElement?.VerticalMergeOriginal?.Value);
  }
  
  private static void SetVerticalMergeOriginal(DXW.CellMerge openXmlElement, DMW.VerticalMergeRevisionKind? value)
  {
    openXmlElement.VerticalMergeOriginal = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.VerticalMergeRevisionValues, DMW.VerticalMergeRevisionKind>(value);
  }
  
  /// <summary>
  /// author
  /// </summary>
  private static String? GetAuthor(DXW.CellMerge openXmlElement)
  {
    return openXmlElement?.Author?.Value;
  }
  
  private static void SetAuthor(DXW.CellMerge openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Author = new StringValue { Value = value };
    else
      openXmlElement.Author = null;
  }
  
  /// <summary>
  /// date
  /// </summary>
  private static DateTime? GetDate(DXW.CellMerge openXmlElement)
  {
    return openXmlElement.Date?.Value;
  }
  
  private static void SetDate(DXW.CellMerge openXmlElement, DateTime? value)
  {
    openXmlElement.Date = value;
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  private static String? GetId(DXW.CellMerge openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DXW.CellMerge openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  public static DMW.CellMerge? CreateModelElement(DXW.CellMerge? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.CellMerge();
      value.VerticalMerge = GetVerticalMerge(openXmlElement);
      value.VerticalMergeOriginal = GetVerticalMergeOriginal(openXmlElement);
      value.Author = GetAuthor(openXmlElement);
      value.Date = GetDate(openXmlElement);
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.CellMerge? value)
    where OpenXmlElementType: DXW.CellMerge, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetVerticalMerge(openXmlElement, value?.VerticalMerge);
      SetVerticalMergeOriginal(openXmlElement, value?.VerticalMergeOriginal);
      SetAuthor(openXmlElement, value?.Author);
      SetDate(openXmlElement, value?.Date);
      SetId(openXmlElement, value?.Id);
      return openXmlElement;
    }
    return default;
  }
}
