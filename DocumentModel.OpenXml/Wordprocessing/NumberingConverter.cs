namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Numbering Definitions.
/// </summary>
public static class NumberingConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.NumberingPictureBullet>? GetNumberingPictureBullets(DocumentFormat.OpenXml.Wordprocessing.Numbering? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.NumberingPictureBullet>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.NumberingPictureBullet>())
      {
        var newItem = DocumentModel.OpenXml.Wordprocessing.NumberingPictureBulletConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetNumberingPictureBullets(DocumentFormat.OpenXml.Wordprocessing.Numbering? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.NumberingPictureBullet>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.NumberingPictureBullet>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Wordprocessing.NumberingPictureBulletConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.NumberingPictureBullet>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.AbstractNum>? GetAbstractNums(DocumentFormat.OpenXml.Wordprocessing.Numbering? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.AbstractNum>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.AbstractNum>())
      {
        var newItem = DocumentModel.OpenXml.Wordprocessing.AbstractNumConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetAbstractNums(DocumentFormat.OpenXml.Wordprocessing.Numbering? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.AbstractNum>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.AbstractNum>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Wordprocessing.AbstractNumConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.AbstractNum>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.NumberingInstance>? GetNumberingInstances(DocumentFormat.OpenXml.Wordprocessing.Numbering? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.NumberingInstance>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.NumberingInstance>())
      {
        var newItem = DocumentModel.OpenXml.Wordprocessing.NumberingInstanceConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetNumberingInstances(DocumentFormat.OpenXml.Wordprocessing.Numbering? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.NumberingInstance>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.NumberingInstance>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Wordprocessing.NumberingInstanceConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.NumberingInstance>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static Int32? GetNumberingIdMacAtCleanup(DocumentFormat.OpenXml.Wordprocessing.Numbering? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.NumberingIdMacAtCleanup");
  }
  
  public static void SetNumberingIdMacAtCleanup(DocumentFormat.OpenXml.Wordprocessing.Numbering? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.NumberingIdMacAtCleanup");
  }
  
  public static DocumentModel.Wordprocessing.Numbering? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.Numbering? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Numbering();
      value.NumberingPictureBullets = GetNumberingPictureBullets(openXmlElement);
      value.AbstractNums = GetAbstractNums(openXmlElement);
      value.NumberingInstances = GetNumberingInstances(openXmlElement);
      value.NumberingIdMacAtCleanup = GetNumberingIdMacAtCleanup(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Numbering? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.Numbering, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
