using DocumentFormat.OpenXml.Vml;
using DocumentModel.Vml;
using RegroupTable = DocumentFormat.OpenXml.Vml.Office.RegroupTable;

namespace DocumentModel.OpenXml.Vml;

/// <summary>
///   Shape Grouping History.
/// </summary>
public static class RegroupTableConverter
{
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  public static ExtensionHandlingBehaviorKind? GetExtension(RegroupTable? openXmlElement)
  {
    return EnumValueConverter.GetValue<ExtensionHandlingBehaviorValues, ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }

  public static void SetExtension(RegroupTable? openXmlElement, ExtensionHandlingBehaviorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Extension = EnumValueConverter.CreateEnumValue<ExtensionHandlingBehaviorValues, ExtensionHandlingBehaviorKind>(value);
  }

  public static Collection<Entry>? GetEntries(RegroupTable? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<Entry>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Vml.Office.Entry>())
      {
        var newItem = EntryConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetEntries(RegroupTable? openXmlElement, Collection<Entry>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Vml.Office.Entry>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = EntryConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.Entry>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Vml.RegroupTable? CreateModelElement(RegroupTable? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.RegroupTable();
      value.Extension = GetExtension(openXmlElement);
      value.Entries = GetEntries(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Vml.RegroupTable? value)
    where OpenXmlElementType : RegroupTable, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetExtension(openXmlElement, value?.Extension);
      SetEntries(openXmlElement, value?.Entries);
      return openXmlElement;
    }
    return default;
  }
}