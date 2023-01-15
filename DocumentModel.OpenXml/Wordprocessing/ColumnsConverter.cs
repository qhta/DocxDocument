using DocumentFormat.OpenXml.Wordprocessing;
using Column = DocumentModel.Wordprocessing.Column;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the Columns Class.
/// </summary>
public static class ColumnsConverter
{
  /// <summary>
  ///   Equal Column Widths
  /// </summary>
  public static Boolean? GetEqualWidth(Columns? openXmlElement)
  {
    return openXmlElement?.EqualWidth?.Value;
  }

  public static void SetEqualWidth(Columns? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.EqualWidth = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.EqualWidth = null;
  }

  /// <summary>
  ///   Spacing Between Equal Width Columns
  /// </summary>
  public static String? GetSpace(Columns? openXmlElement)
  {
    return openXmlElement?.Space?.Value;
  }

  public static void SetSpace(Columns? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Space = new StringValue { Value = value };
      else
        openXmlElement.Space = null;
  }

  /// <summary>
  ///   Number of Equal Width Columns
  /// </summary>
  public static Int16? GetColumnCount(Columns? openXmlElement)
  {
    return openXmlElement?.ColumnCount?.Value;
  }

  public static void SetColumnCount(Columns? openXmlElement, Int16? value)
  {
    if (openXmlElement != null)
      openXmlElement.ColumnCount = value;
  }

  /// <summary>
  ///   Draw Line Between Columns
  /// </summary>
  public static Boolean? GetSeparator(Columns? openXmlElement)
  {
    return openXmlElement?.Separator?.Value;
  }

  public static void SetSeparator(Columns? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Separator = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.Separator = null;
  }

  public static Collection<Column>? GetItems(Columns? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<Column>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.Column>())
      {
        var newItem = ColumnConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetItems(Columns? openXmlElement, Collection<Column>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.Column>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = ColumnConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Column>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Wordprocessing.Columns? CreateModelElement(Columns? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Columns();
      value.EqualWidth = GetEqualWidth(openXmlElement);
      value.Space = GetSpace(openXmlElement);
      value.ColumnCount = GetColumnCount(openXmlElement);
      value.Separator = GetSeparator(openXmlElement);
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Columns? value)
    where OpenXmlElementType : Columns, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetEqualWidth(openXmlElement, value?.EqualWidth);
      SetSpace(openXmlElement, value?.Space);
      SetColumnCount(openXmlElement, value?.ColumnCount);
      SetSeparator(openXmlElement, value?.Separator);
      SetItems(openXmlElement, value?.Items);
      return openXmlElement;
    }
    return default;
  }
}