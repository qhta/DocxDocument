using DocumentModel.UI;

namespace DocumentModel.OpenXml.UI;

/// <summary>
///   Defines CustomUI.
/// </summary>
public static class CustomUIConverter
{
  /// <summary>
  ///   onLoad
  /// </summary>
  public static String? GetOnLoad(DocumentFormat.OpenXml.Office.CustomUI.CustomUI? openXmlElement)
  {
    return openXmlElement?.OnLoad?.Value;
  }

  public static void SetOnLoad(DocumentFormat.OpenXml.Office.CustomUI.CustomUI? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.OnLoad = new StringValue { Value = value };
      else
        openXmlElement.OnLoad = null;
  }

  /// <summary>
  ///   loadImage
  /// </summary>
  public static String? GetLoadImage(DocumentFormat.OpenXml.Office.CustomUI.CustomUI? openXmlElement)
  {
    return openXmlElement?.LoadImage?.Value;
  }

  public static void SetLoadImage(DocumentFormat.OpenXml.Office.CustomUI.CustomUI? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.LoadImage = new StringValue { Value = value };
      else
        openXmlElement.LoadImage = null;
  }

  /// <summary>
  ///   RepurposedCommands.
  /// </summary>
  public static RepurposedCommands? GetRepurposedCommands(DocumentFormat.OpenXml.Office.CustomUI.CustomUI? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.RepurposedCommands>();
    if (itemElement != null)
      return RepurposedCommandsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRepurposedCommands(DocumentFormat.OpenXml.Office.CustomUI.CustomUI? openXmlElement, RepurposedCommands? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.RepurposedCommands>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RepurposedCommandsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.RepurposedCommands>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Ribbon.
  /// </summary>
  public static DocumentModel.UI.Ribbon? GetRibbon(DocumentFormat.OpenXml.Office.CustomUI.CustomUI? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.Ribbon>();
    if (itemElement != null)
      return RibbonConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRibbon(DocumentFormat.OpenXml.Office.CustomUI.CustomUI? openXmlElement, DocumentModel.UI.Ribbon? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.Ribbon>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RibbonConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.Ribbon>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.UI.CustomUI? CreateModelElement(DocumentFormat.OpenXml.Office.CustomUI.CustomUI? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.UI.CustomUI();
      value.OnLoad = GetOnLoad(openXmlElement);
      value.LoadImage = GetLoadImage(openXmlElement);
      value.RepurposedCommands = GetRepurposedCommands(openXmlElement);
      value.Ribbon = GetRibbon(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.UI.CustomUI? value)
    where OpenXmlElementType : DocumentFormat.OpenXml.Office.CustomUI.CustomUI, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetOnLoad(openXmlElement, value?.OnLoad);
      SetLoadImage(openXmlElement, value?.LoadImage);
      SetRepurposedCommands(openXmlElement, value?.RepurposedCommands);
      SetRibbon(openXmlElement, value?.Ribbon);
      return openXmlElement;
    }
    return default;
  }
}