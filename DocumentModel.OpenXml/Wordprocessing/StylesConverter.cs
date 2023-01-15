using DocumentModel.Wordprocessing;
using Styles = DocumentFormat.OpenXml.Wordprocessing.Styles;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines Styles.
/// </summary>
public static class StylesConverter
{
  /// <summary>
  ///   Document Default Paragraph and Run Properties.
  /// </summary>
  public static DocDefaults? GetDocDefaults(Styles? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocDefaults>();
    if (itemElement != null)
      return DocDefaultsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDocDefaults(Styles? openXmlElement, DocDefaults? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocDefaults>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocDefaultsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.DocDefaults>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Latent Style Information.
  /// </summary>
  public static LatentStyles? GetLatentStyles(Styles? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LatentStyles>();
    if (itemElement != null)
      return LatentStylesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLatentStyles(Styles? openXmlElement, LatentStyles? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LatentStyles>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LatentStylesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.LatentStyles>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Collection<Style>? GetItems(Styles? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<Style>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.Style>())
      {
        var newItem = StyleConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetItems(Styles? openXmlElement, Collection<Style>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.Style>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = StyleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Style>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Wordprocessing.Styles? CreateModelElement(Styles? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Styles();
      value.DocDefaults = GetDocDefaults(openXmlElement);
      value.LatentStyles = GetLatentStyles(openXmlElement);
      value.Items = GetItems(openXmlElement) ?? new Collection<Style>();
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Styles? value)
    where OpenXmlElementType : Styles, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDocDefaults(openXmlElement, value?.DocDefaults);
      SetLatentStyles(openXmlElement, value?.LatentStyles);
      SetItems(openXmlElement, value?.Items);
      return openXmlElement;
    }
    return null;
  }
}