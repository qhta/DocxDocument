using DocumentFormat.OpenXml.Drawing.Charts;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the PivotSource Class.
/// </summary>
public static class PivotSourceConverter
{
  /// <summary>
  ///   Pivot Name.
  /// </summary>
  public static String? GetPivotTableName(PivotSource? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<PivotTableName>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetPivotTableName(PivotSource? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<PivotTableName>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new PivotTableName { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Format ID.
  /// </summary>
  public static UInt32? GetFormatId(PivotSource? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<FormatId>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetFormatId(PivotSource? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<FormatId>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new FormatId { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  public static DocumentModel.Drawings.Charts.ExtensionList? GetExtensionList(PivotSource? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(PivotSource? openXmlElement, DocumentModel.Drawings.Charts.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.PivotSource? CreateModelElement(PivotSource? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.PivotSource();
      value.PivotTableName = GetPivotTableName(openXmlElement);
      value.FormatId = GetFormatId(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.PivotSource? value)
    where OpenXmlElementType : PivotSource, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPivotTableName(openXmlElement, value?.PivotTableName);
      SetFormatId(openXmlElement, value?.FormatId);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}