namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the NumberingProperties Class.
/// </summary>
public static class NumberingPropertiesConverter
{
  /// <summary>
  /// Numbering Level Reference.
  /// </summary>
  public static Int32? GetNumberingLevelReference(DocumentFormat.OpenXml.Wordprocessing.NumberingProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingLevelReference>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetNumberingLevelReference(DocumentFormat.OpenXml.Wordprocessing.NumberingProperties? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingLevelReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Wordprocessing.NumberingLevelReference{ Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Numbering Definition Instance Reference.
  /// </summary>
  public static Int32? GetNumberingId(DocumentFormat.OpenXml.Wordprocessing.NumberingProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingId>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetNumberingId(DocumentFormat.OpenXml.Wordprocessing.NumberingProperties? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingId>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Wordprocessing.NumberingId{ Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Previous Paragraph Numbering Properties.
  /// </summary>
  public static DocumentModel.Wordprocessing.NumberingChange? GetNumberingChange(DocumentFormat.OpenXml.Wordprocessing.NumberingProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingChange>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.NumberingChangeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetNumberingChange(DocumentFormat.OpenXml.Wordprocessing.NumberingProperties? openXmlElement, DocumentModel.Wordprocessing.NumberingChange? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingChange>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.NumberingChangeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.NumberingChange>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Inserted Numbering Properties.
  /// </summary>
  public static DocumentModel.Wordprocessing.TrackChangeType? GetInserted(DocumentFormat.OpenXml.Wordprocessing.NumberingProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Inserted>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetInserted(DocumentFormat.OpenXml.Wordprocessing.NumberingProperties? openXmlElement, DocumentModel.Wordprocessing.TrackChangeType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Inserted>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.TrackChangeTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Inserted>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.NumberingProperties? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.NumberingProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.NumberingProperties();
      value.NumberingLevelReference = GetNumberingLevelReference(openXmlElement);
      value.NumberingId = GetNumberingId(openXmlElement);
      value.NumberingChange = GetNumberingChange(openXmlElement);
      value.Inserted = GetInserted(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.NumberingProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.NumberingProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNumberingLevelReference(openXmlElement, value?.NumberingLevelReference);
      SetNumberingId(openXmlElement, value?.NumberingId);
      SetNumberingChange(openXmlElement, value?.NumberingChange);
      SetInserted(openXmlElement, value?.Inserted);
      return openXmlElement;
    }
    return default;
  }
}
