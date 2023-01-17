namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Numbering Definition Instance.
/// </summary>
public static class NumberingInstanceConverter
{
  /// <summary>
  /// numId
  /// </summary>
  private static Int32? GetNumberID(DocumentFormat.OpenXml.Wordprocessing.NumberingInstance openXmlElement)
  {
    return openXmlElement.NumberID?.Value;
  }
  
  private static void SetNumberID(DocumentFormat.OpenXml.Wordprocessing.NumberingInstance openXmlElement, Int32? value)
  {
    openXmlElement.NumberID = value;
  }
  
  /// <summary>
  /// durableId
  /// </summary>
  private static Int32? GetDurableId(DocumentFormat.OpenXml.Wordprocessing.NumberingInstance openXmlElement)
  {
    return openXmlElement.DurableId?.Value;
  }
  
  private static void SetDurableId(DocumentFormat.OpenXml.Wordprocessing.NumberingInstance openXmlElement, Int32? value)
  {
    openXmlElement.DurableId = value;
  }
  
  /// <summary>
  /// AbstractNumId.
  /// </summary>
  private static Int32? GetAbstractNumId(DocumentFormat.OpenXml.Wordprocessing.NumberingInstance openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AbstractNumId>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetAbstractNumId(DocumentFormat.OpenXml.Wordprocessing.NumberingInstance openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AbstractNumId>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.AbstractNumId{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.LevelOverride> GetLevelOverrides(DocumentFormat.OpenXml.Wordprocessing.NumberingInstance openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.LevelOverride>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.LevelOverride>())
    {
      var newItem = DocumentModel.OpenXml.Wordprocessing.LevelOverrideConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetLevelOverrides(DocumentFormat.OpenXml.Wordprocessing.NumberingInstance openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.LevelOverride>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.LevelOverride>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DocumentModel.OpenXml.Wordprocessing.LevelOverrideConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.LevelOverride>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.NumberingInstance? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.NumberingInstance? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.NumberingInstance();
      value.NumberID = GetNumberID(openXmlElement);
      value.DurableId = GetDurableId(openXmlElement);
      value.AbstractNumId = GetAbstractNumId(openXmlElement);
      value.LevelOverrides = GetLevelOverrides(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.NumberingInstance? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.NumberingInstance, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNumberID(openXmlElement, value?.NumberID);
      SetDurableId(openXmlElement, value?.DurableId);
      SetAbstractNumId(openXmlElement, value?.AbstractNumId);
      SetLevelOverrides(openXmlElement, value?.LevelOverrides);
      return openXmlElement;
    }
    return default;
  }
}
