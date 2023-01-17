namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Columns Class.
/// </summary>
public static class ColumnsConverter
{
  /// <summary>
  /// Equal Column Widths
  /// </summary>
  private static Boolean? GetEqualWidth(DocumentFormat.OpenXml.Wordprocessing.Columns openXmlElement)
  {
    return openXmlElement?.EqualWidth?.Value;
  }
  
  private static void SetEqualWidth(DocumentFormat.OpenXml.Wordprocessing.Columns openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.EqualWidth = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.EqualWidth = null;
  }
  
  /// <summary>
  /// Spacing Between Equal Width Columns
  /// </summary>
  private static String? GetSpace(DocumentFormat.OpenXml.Wordprocessing.Columns openXmlElement)
  {
    return openXmlElement?.Space?.Value;
  }
  
  private static void SetSpace(DocumentFormat.OpenXml.Wordprocessing.Columns openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Space = new StringValue { Value = value };
    else
      openXmlElement.Space = null;
  }
  
  /// <summary>
  /// Number of Equal Width Columns
  /// </summary>
  private static Int16? GetColumnCount(DocumentFormat.OpenXml.Wordprocessing.Columns openXmlElement)
  {
    return openXmlElement.ColumnCount?.Value;
  }
  
  private static void SetColumnCount(DocumentFormat.OpenXml.Wordprocessing.Columns openXmlElement, Int16? value)
  {
    openXmlElement.ColumnCount = value;
  }
  
  /// <summary>
  /// Draw Line Between Columns
  /// </summary>
  private static Boolean? GetSeparator(DocumentFormat.OpenXml.Wordprocessing.Columns openXmlElement)
  {
    return openXmlElement?.Separator?.Value;
  }
  
  private static void SetSeparator(DocumentFormat.OpenXml.Wordprocessing.Columns openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Separator = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.Separator = null;
  }
  
  private static System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.Column> GetItems(DocumentFormat.OpenXml.Wordprocessing.Columns openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.Column>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.Column>())
    {
      var newItem = DocumentModel.OpenXml.Wordprocessing.ColumnConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetItems(DocumentFormat.OpenXml.Wordprocessing.Columns openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.Column>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.Column>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DocumentModel.OpenXml.Wordprocessing.ColumnConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Column>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.Columns? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.Columns? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.Columns, new()
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
