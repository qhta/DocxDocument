namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the MoveToMathControl Class.
/// </summary>
public static class MoveToMathControlConverter
{
  private static DocumentModel.Wordprocessing.RunProperties? GetRunProperties(DocumentFormat.OpenXml.Wordprocessing.MoveToMathControl openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.RunPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRunProperties(DocumentFormat.OpenXml.Wordprocessing.MoveToMathControl openXmlElement, DocumentModel.Wordprocessing.RunProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.RunPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.RunProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.InsertedMathControl? GetInsertedMathControl(DocumentFormat.OpenXml.Wordprocessing.MoveToMathControl openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.InsertedMathControl>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.InsertedMathControlConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetInsertedMathControl(DocumentFormat.OpenXml.Wordprocessing.MoveToMathControl openXmlElement, DocumentModel.Wordprocessing.InsertedMathControl? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.InsertedMathControl>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.InsertedMathControlConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.InsertedMathControl>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.DeletedMathControl? GetDeletedMathControl(DocumentFormat.OpenXml.Wordprocessing.MoveToMathControl openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DeletedMathControl>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.DeletedMathControlConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDeletedMathControl(DocumentFormat.OpenXml.Wordprocessing.MoveToMathControl openXmlElement, DocumentModel.Wordprocessing.DeletedMathControl? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DeletedMathControl>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.DeletedMathControlConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.DeletedMathControl>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.MoveToMathControl? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.MoveToMathControl? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.MoveToMathControl();
      value.RunProperties = GetRunProperties(openXmlElement);
      value.InsertedMathControl = GetInsertedMathControl(openXmlElement);
      value.DeletedMathControl = GetDeletedMathControl(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.MoveToMathControl? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.MoveToMathControl, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRunProperties(openXmlElement, value?.RunProperties);
      SetInsertedMathControl(openXmlElement, value?.InsertedMathControl);
      SetDeletedMathControl(openXmlElement, value?.DeletedMathControl);
      return openXmlElement;
    }
    return default;
  }
}
