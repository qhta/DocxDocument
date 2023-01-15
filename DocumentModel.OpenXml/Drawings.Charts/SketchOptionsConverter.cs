using DocumentFormat.OpenXml.Office2010.Drawing.Charts;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the SketchOptions Class.
/// </summary>
public static class SketchOptionsConverter
{
  /// <summary>
  ///   InSketchMode.
  /// </summary>
  public static Boolean? GetInSketchMode(SketchOptions? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<InSketchMode>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetInSketchMode(SketchOptions? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<InSketchMode>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new InSketchMode();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ShowSketchButton.
  /// </summary>
  public static Boolean? GetShowSketchButton(SketchOptions? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ShowSketchButton>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetShowSketchButton(SketchOptions? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<ShowSketchButton>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new ShowSketchButton();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.SketchOptions? CreateModelElement(SketchOptions? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.SketchOptions();
      value.InSketchMode = GetInSketchMode(openXmlElement);
      value.ShowSketchButton = GetShowSketchButton(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.SketchOptions? value)
    where OpenXmlElementType : SketchOptions, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetInSketchMode(openXmlElement, value?.InSketchMode);
      SetShowSketchButton(openXmlElement, value?.ShowSketchButton);
      return openXmlElement;
    }
    return default;
  }
}