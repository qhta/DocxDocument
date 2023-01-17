namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines Styles.
/// </summary>
public static class StylesConverter
{
  /// <summary>
  /// Document Default Paragraph and Run Properties.
  /// </summary>
  private static DocumentModel.Wordprocessing.DocDefaults? GetDocDefaults(DocumentFormat.OpenXml.Wordprocessing.Styles openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocDefaults>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.DocDefaultsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDocDefaults(DocumentFormat.OpenXml.Wordprocessing.Styles openXmlElement, DocumentModel.Wordprocessing.DocDefaults? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocDefaults>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.DocDefaultsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.DocDefaults>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Latent Style Information.
  /// </summary>
  private static DocumentModel.Wordprocessing.LatentStyles? GetLatentStyles(DocumentFormat.OpenXml.Wordprocessing.Styles openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LatentStyles>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.LatentStylesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLatentStyles(DocumentFormat.OpenXml.Wordprocessing.Styles openXmlElement, DocumentModel.Wordprocessing.LatentStyles? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LatentStyles>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.LatentStylesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.LatentStyles>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.Style> GetItems(DocumentFormat.OpenXml.Wordprocessing.Styles openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.Style>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.Style>())
    {
      var newItem = DocumentModel.OpenXml.Wordprocessing.StyleConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetItems(DocumentFormat.OpenXml.Wordprocessing.Styles openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.Style>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.Style>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DocumentModel.OpenXml.Wordprocessing.StyleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Style>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.Styles? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.Styles? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Styles();
      value.DocDefaults = GetDocDefaults(openXmlElement);
      value.LatentStyles = GetLatentStyles(openXmlElement);
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Styles? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.Styles, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDocDefaults(openXmlElement, value?.DocDefaults);
      SetLatentStyles(openXmlElement, value?.LatentStyles);
      SetItems(openXmlElement, value?.Items);
      return openXmlElement;
    }
    return default;
  }
}
