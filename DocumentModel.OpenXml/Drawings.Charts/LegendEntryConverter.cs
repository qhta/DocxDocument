using DocumentFormat.OpenXml.Drawing.Charts;
using Index = DocumentFormat.OpenXml.Drawing.Charts.Index;
using TextProperties = DocumentModel.Drawings.Charts.TextProperties;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Legend Entry.
/// </summary>
public static class LegendEntryConverter
{
  /// <summary>
  ///   Index.
  /// </summary>
  public static UInt32? GetIndex(LegendEntry? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Index>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetIndex(LegendEntry? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Index>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new Index { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetDelete(LegendEntry? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Delete>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDelete(LegendEntry? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<Delete>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new Delete();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TextProperties? GetTextProperties(LegendEntry? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.TextProperties>();
    if (itemElement != null)
      return TextPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTextProperties(LegendEntry? openXmlElement, TextProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.TextProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.TextProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.ExtensionList? GetExtensionList(LegendEntry? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(LegendEntry? openXmlElement, DocumentModel.Drawings.Charts.ExtensionList? value)
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

  public static DocumentModel.Drawings.Charts.LegendEntry? CreateModelElement(LegendEntry? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.LegendEntry();
      value.Index = GetIndex(openXmlElement);
      value.Delete = GetDelete(openXmlElement);
      value.TextProperties = GetTextProperties(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.LegendEntry? value)
    where OpenXmlElementType : LegendEntry, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetIndex(openXmlElement, value?.Index);
      SetDelete(openXmlElement, value?.Delete);
      SetTextProperties(openXmlElement, value?.TextProperties);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}