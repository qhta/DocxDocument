namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Numbering Definition Instance.
/// </summary>
public static class NumberingInstanceConverter
{
  /// <summary>
  /// numId
  /// </summary>
  public static Int32? GetNumberID(DocumentFormat.OpenXml.Wordprocessing.NumberingInstance? openXmlElement)
  {
    return openXmlElement?.NumberID?.Value;
  }
  
  public static void SetNumberID(DocumentFormat.OpenXml.Wordprocessing.NumberingInstance? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.NumberID = value;
  }
  
  /// <summary>
  /// durableId
  /// </summary>
  public static Int32? GetDurableId(DocumentFormat.OpenXml.Wordprocessing.NumberingInstance? openXmlElement)
  {
    return openXmlElement?.DurableId?.Value;
  }
  
  public static void SetDurableId(DocumentFormat.OpenXml.Wordprocessing.NumberingInstance? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.DurableId = value;
  }
  
  /// <summary>
  /// AbstractNumId.
  /// </summary>
  public static Int32? GetAbstractNumId(DocumentFormat.OpenXml.Wordprocessing.NumberingInstance? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.AbstractNumId");
  }
  
  public static void SetAbstractNumId(DocumentFormat.OpenXml.Wordprocessing.NumberingInstance? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.AbstractNumId");
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.LevelOverride>? GetLevelOverrides(DocumentFormat.OpenXml.Wordprocessing.NumberingInstance? openXmlElement)
  {
    if (openXmlElement != null)
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
    return null;
  }
  
  public static void SetLevelOverrides(DocumentFormat.OpenXml.Wordprocessing.NumberingInstance? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.LevelOverride>? value)
  {
    if (openXmlElement != null)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
