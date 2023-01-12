namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Shape Grouping History.
/// </summary>
public static class RegroupTableConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public static DocumentModel.Vml.ExtensionHandlingBehaviorKind? GetExtension(DocumentFormat.OpenXml.Vml.Office.RegroupTable? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DocumentModel.Vml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }
  
  public static void SetExtension(DocumentFormat.OpenXml.Vml.Office.RegroupTable? openXmlElement, DocumentModel.Vml.ExtensionHandlingBehaviorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DocumentModel.Vml.ExtensionHandlingBehaviorKind>(value);
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Vml.Entry>? GetEntries(DocumentFormat.OpenXml.Vml.Office.RegroupTable? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Vml.Entry>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Vml.Office.Entry>())
      {
        var newItem = DocumentModel.OpenXml.Vml.EntryConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetEntries(DocumentFormat.OpenXml.Vml.Office.RegroupTable? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Vml.Entry>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Vml.Office.Entry>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Vml.EntryConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.Entry>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Vml.RegroupTable? CreateModelElement(DocumentFormat.OpenXml.Vml.Office.RegroupTable? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Vml.Office.RegroupTable, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetExtension(openXmlElement, value?.Extension);
      return openXmlElement;
    }
    return default;
  }
}
