namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines Styles.
/// </summary>
public static class StylesConverter
{
  /// <summary>
  /// Document Default Paragraph and Run Properties.
  /// </summary>
  public static DocumentModel.Wordprocessing.DocDefaults? GetDocDefaults(DocumentFormat.OpenXml.Wordprocessing.Styles? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocDefaults>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.DocDefaultsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDocDefaults(DocumentFormat.OpenXml.Wordprocessing.Styles? openXmlElement, DocumentModel.Wordprocessing.DocDefaults? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Latent Style Information.
  /// </summary>
  public static DocumentModel.Wordprocessing.LatentStyles? GetLatentStyles(DocumentFormat.OpenXml.Wordprocessing.Styles? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LatentStyles>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.LatentStylesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLatentStyles(DocumentFormat.OpenXml.Wordprocessing.Styles? openXmlElement, DocumentModel.Wordprocessing.LatentStyles? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.Style>? GetItems(DocumentFormat.OpenXml.Wordprocessing.Styles? openXmlElement)
  {
    if (openXmlElement != null)
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
    return null;
  }
  
  public static void SetItems(DocumentFormat.OpenXml.Wordprocessing.Styles? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.Style>? value)
  {
    if (openXmlElement != null)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
