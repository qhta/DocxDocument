namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Audio from CD.
/// </summary>
public static class AudioFromCDConverter
{
  /// <summary>
  /// Audio Start Time.
  /// </summary>
  public static DocumentModel.Drawings.AudioCDTimeType? GetStartTime(DocumentFormat.OpenXml.Drawing.AudioFromCD? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.StartTime>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.AudioCDTimeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetStartTime(DocumentFormat.OpenXml.Drawing.AudioFromCD? openXmlElement, DocumentModel.Drawings.AudioCDTimeType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.StartTime>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.AudioCDTimeTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.StartTime>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Audio End Time.
  /// </summary>
  public static DocumentModel.Drawings.AudioCDTimeType? GetEndTime(DocumentFormat.OpenXml.Drawing.AudioFromCD? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.EndTime>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.AudioCDTimeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetEndTime(DocumentFormat.OpenXml.Drawing.AudioFromCD? openXmlElement, DocumentModel.Drawings.AudioCDTimeType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.EndTime>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.AudioCDTimeTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.EndTime>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.AudioFromCD? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Drawing.AudioFromCD? openXmlElement, DocumentModel.Drawings.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.AudioFromCD? CreateModelElement(DocumentFormat.OpenXml.Drawing.AudioFromCD? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.AudioFromCD();
      value.StartTime = GetStartTime(openXmlElement);
      value.EndTime = GetEndTime(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.AudioFromCD? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.AudioFromCD, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
