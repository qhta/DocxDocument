namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the GradientFillProperties Class.
/// </summary>
public static class GradientFillPropertiesConverter
{
  /// <summary>
  /// GradientStopList.
  /// </summary>
  public static DocumentModel.Wordprocessing.GradientStopList? GetGradientStopList(DocumentFormat.OpenXml.Office2010.Word.GradientFillProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.GradientStopList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.GradientStopListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetGradientStopList(DocumentFormat.OpenXml.Office2010.Word.GradientFillProperties? openXmlElement, DocumentModel.Wordprocessing.GradientStopList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.GradientStopList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.GradientStopListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.GradientStopList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.LinearShadeProperties? GetLinearShadeProperties(DocumentFormat.OpenXml.Office2010.Word.GradientFillProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.LinearShadeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.LinearShadePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLinearShadeProperties(DocumentFormat.OpenXml.Office2010.Word.GradientFillProperties? openXmlElement, DocumentModel.Wordprocessing.LinearShadeProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.LinearShadeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.LinearShadePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.LinearShadeProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.PathShadeProperties? GetPathShadeProperties(DocumentFormat.OpenXml.Office2010.Word.GradientFillProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.PathShadeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.PathShadePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPathShadeProperties(DocumentFormat.OpenXml.Office2010.Word.GradientFillProperties? openXmlElement, DocumentModel.Wordprocessing.PathShadeProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.PathShadeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.PathShadePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.PathShadeProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.GradientFillProperties? CreateModelElement(DocumentFormat.OpenXml.Office2010.Word.GradientFillProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.GradientFillProperties();
      value.GradientStopList = GetGradientStopList(openXmlElement);
      value.LinearShadeProperties = GetLinearShadeProperties(openXmlElement);
      value.PathShadeProperties = GetPathShadeProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.GradientFillProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Word.GradientFillProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGradientStopList(openXmlElement, value?.GradientStopList);
      SetLinearShadeProperties(openXmlElement, value?.LinearShadeProperties);
      SetPathShadeProperties(openXmlElement, value?.PathShadeProperties);
      return openXmlElement;
    }
    return default;
  }
}
