namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Delimiter Function.
/// </summary>
public static class DelimiterConverter
{
  /// <summary>
  /// Delimiter Properties.
  /// </summary>
  public static DocumentModel.Math.DelimiterProperties? GetDelimiterProperties(DocumentFormat.OpenXml.Math.Delimiter? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.DelimiterProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.DelimiterPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDelimiterProperties(DocumentFormat.OpenXml.Math.Delimiter? openXmlElement, DocumentModel.Math.DelimiterProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.DelimiterProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Math.DelimiterPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.DelimiterProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Math.Base>? GetBases(DocumentFormat.OpenXml.Math.Delimiter? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Math.Base>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Math.Base>())
      {
        var newItem = DocumentModel.OpenXml.Math.BaseConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetBases(DocumentFormat.OpenXml.Math.Delimiter? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Math.Base>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Math.Base>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Math.BaseConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Base>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Math.Delimiter? CreateModelElement(DocumentFormat.OpenXml.Math.Delimiter? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.Delimiter();
      value.DelimiterProperties = GetDelimiterProperties(openXmlElement);
      value.Bases = GetBases(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.Delimiter? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Math.Delimiter, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
