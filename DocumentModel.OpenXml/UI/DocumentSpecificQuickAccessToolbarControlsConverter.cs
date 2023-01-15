using DocumentModel.UI;
using DocumentSpecificQuickAccessToolbarControls = DocumentFormat.OpenXml.Office.CustomUI.DocumentSpecificQuickAccessToolbarControls;

namespace DocumentModel.OpenXml.UI;

/// <summary>
///   Defines the DocumentSpecificQuickAccessToolbarControls Class.
/// </summary>
public static class DocumentSpecificQuickAccessToolbarControlsConverter
{
  public static QuickAccessToolbarControlClone? GetQuickAccessToolbarControlClone(DocumentSpecificQuickAccessToolbarControls? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.QuickAccessToolbarControlClone>();
    if (itemElement != null)
      return QuickAccessToolbarControlCloneConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetQuickAccessToolbarControlClone(DocumentSpecificQuickAccessToolbarControls? openXmlElement, QuickAccessToolbarControlClone? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.QuickAccessToolbarControlClone>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = QuickAccessToolbarControlCloneConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.QuickAccessToolbarControlClone>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static UnsizedButton? GetUnsizedButton(DocumentSpecificQuickAccessToolbarControls? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton>();
    if (itemElement != null)
      return UnsizedButtonConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetUnsizedButton(DocumentSpecificQuickAccessToolbarControls? openXmlElement, UnsizedButton? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = UnsizedButtonConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static VerticalSeparator? GetVerticalSeparator(DocumentSpecificQuickAccessToolbarControls? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.VerticalSeparator>();
    if (itemElement != null)
      return VerticalSeparatorConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetVerticalSeparator(DocumentSpecificQuickAccessToolbarControls? openXmlElement, VerticalSeparator? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.VerticalSeparator>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = VerticalSeparatorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.VerticalSeparator>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.UI.DocumentSpecificQuickAccessToolbarControls? CreateModelElement(DocumentSpecificQuickAccessToolbarControls? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.UI.DocumentSpecificQuickAccessToolbarControls();
      value.QuickAccessToolbarControlClone = GetQuickAccessToolbarControlClone(openXmlElement);
      value.UnsizedButton = GetUnsizedButton(openXmlElement);
      value.VerticalSeparator = GetVerticalSeparator(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.UI.DocumentSpecificQuickAccessToolbarControls? value)
    where OpenXmlElementType : DocumentSpecificQuickAccessToolbarControls, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetQuickAccessToolbarControlClone(openXmlElement, value?.QuickAccessToolbarControlClone);
      SetUnsizedButton(openXmlElement, value?.UnsizedButton);
      SetVerticalSeparator(openXmlElement, value?.VerticalSeparator);
      return openXmlElement;
    }
    return default;
  }
}