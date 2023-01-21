using DMW = DocumentModel.Wordprocessing;
using DXW = DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines Styles.
/// </summary>
public static class StylesConverter
{
  /// <summary>
  ///   Document Default Paragraph and Run Properties.
  /// </summary>
  private static DMW.DocDefaults? GetDocDefaults(DXW.Styles openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.DocDefaults>();
    if (itemElement != null)
      return DocDefaultsConverter.CreateModelElement(itemElement);
    return null;
  }

  private static void SetDocDefaults(DXW.Styles openXmlElement, DMW.DocDefaults? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DocDefaults>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocDefaultsConverter.CreateOpenXmlElement<DXW.DocDefaults>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }

  /// <summary>
  ///   Latent Style Information.
  /// </summary>
  private static DMW.LatentStyles? GetLatentStyles(DXW.Styles openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.LatentStyles>();
    if (itemElement != null)
      return LatentStylesConverter.CreateModelElement(itemElement);
    return null;
  }

  private static void SetLatentStyles(DXW.Styles openXmlElement, DMW.LatentStyles? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.LatentStyles>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = LatentStylesConverter.CreateOpenXmlElement<DXW.LatentStyles>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }

  private static Collection<DMW.Style> GetItems(DXW.Styles openXmlElement)
  {
    var collection = new Collection<DMW.Style>();
    foreach (var item in openXmlElement.Elements<DXW.Style>())
    {
      var newItem = StyleConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }

  private static void SetItems(DXW.Styles openXmlElement, ICollection<DMW.Style> value)
  {
    openXmlElement.RemoveAllChildren<DXW.Style>();
    if (value != null)
      foreach (var item in value)
      {
        var newItem = StyleConverter.CreateOpenXmlElement<DXW.Style>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
  }

  public static DMW.Styles? CreateModelElement(DXW.Styles? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Styles();
      value.DocDefaults = GetDocDefaults(openXmlElement);
      value.LatentStyles = GetLatentStyles(openXmlElement);
      value.AllStyles = GetItems(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.Styles? value)
    where OpenXmlElementType : DXW.Styles, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDocDefaults(openXmlElement, value?.DocDefaults);
      SetLatentStyles(openXmlElement, value?.LatentStyles);
      if (value?.AllStyles != null)
        SetItems(openXmlElement, value.AllStyles);
      return openXmlElement;
    }
    return default;
  }
}