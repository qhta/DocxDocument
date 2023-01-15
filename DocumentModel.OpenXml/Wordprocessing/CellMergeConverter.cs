using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using CellMerge = DocumentFormat.OpenXml.Wordprocessing.CellMerge;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Vertically Merged/Split Table Cells.
/// </summary>
public static class CellMergeConverter
{
  /// <summary>
  ///   vMerge
  /// </summary>
  public static VerticalMergeRevisionKind? GetVerticalMerge(CellMerge? openXmlElement)
  {
    return EnumValueConverter.GetValue<VerticalMergeRevisionValues, VerticalMergeRevisionKind>(openXmlElement?.VerticalMerge?.Value);
  }

  public static void SetVerticalMerge(CellMerge? openXmlElement, VerticalMergeRevisionKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.VerticalMerge = EnumValueConverter.CreateEnumValue<VerticalMergeRevisionValues, VerticalMergeRevisionKind>(value);
  }

  /// <summary>
  ///   vMergeOrig
  /// </summary>
  public static VerticalMergeRevisionKind? GetVerticalMergeOriginal(CellMerge? openXmlElement)
  {
    return EnumValueConverter.GetValue<VerticalMergeRevisionValues, VerticalMergeRevisionKind>(openXmlElement?.VerticalMergeOriginal?.Value);
  }

  public static void SetVerticalMergeOriginal(CellMerge? openXmlElement, VerticalMergeRevisionKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.VerticalMergeOriginal = EnumValueConverter.CreateEnumValue<VerticalMergeRevisionValues, VerticalMergeRevisionKind>(value);
  }

  /// <summary>
  ///   author
  /// </summary>
  public static String? GetAuthor(CellMerge? openXmlElement)
  {
    return openXmlElement?.Author?.Value;
  }

  public static void SetAuthor(CellMerge? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Author = new StringValue { Value = value };
      else
        openXmlElement.Author = null;
  }

  /// <summary>
  ///   date
  /// </summary>
  public static DateTime? GetDate(CellMerge? openXmlElement)
  {
    return openXmlElement?.Date?.Value;
  }

  public static void SetDate(CellMerge? openXmlElement, DateTime? value)
  {
    if (openXmlElement != null)
      openXmlElement.Date = value;
  }

  /// <summary>
  ///   Annotation Identifier
  /// </summary>
  public static String? GetId(CellMerge? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(CellMerge? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }

  public static DocumentModel.Wordprocessing.CellMerge? CreateModelElement(CellMerge? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.CellMerge();
      value.VerticalMerge = GetVerticalMerge(openXmlElement);
      value.VerticalMergeOriginal = GetVerticalMergeOriginal(openXmlElement);
      value.Author = GetAuthor(openXmlElement);
      value.Date = GetDate(openXmlElement);
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.CellMerge? value)
    where OpenXmlElementType : CellMerge, new()
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