using DocumentModel.UI;
using SharedQatControls = DocumentFormat.OpenXml.Office.CustomUI.SharedQatControls;

namespace DocumentModel.OpenXml.UI;

/// <summary>
///   Defines the SharedQatControls Class.
/// </summary>
public static class SharedQatControlsConverter
{
  public static QuickAccessToolbarControlClone? GetQuickAccessToolbarControlClone(SharedQatControls? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.QuickAccessToolbarControlClone>();
    if (itemElement != null)
      return QuickAccessToolbarControlCloneConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetQuickAccessToolbarControlClone(SharedQatControls? openXmlElement, QuickAccessToolbarControlClone? value)
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

  public static UnsizedButton? GetUnsizedButton(SharedQatControls? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton>();
    if (itemElement != null)
      return UnsizedButtonConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetUnsizedButton(SharedQatControls? openXmlElement, UnsizedButton? value)
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

  public static VerticalSeparator? GetVerticalSeparator(SharedQatControls? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.VerticalSeparator>();
    if (itemElement != null)
      return VerticalSeparatorConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetVerticalSeparator(SharedQatControls? openXmlElement, VerticalSeparator? value)
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

  public static DocumentModel.UI.SharedQatControls? CreateModelElement(SharedQatControls? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.UI.SharedQatControls();
      value.QuickAccessToolbarControlClone = GetQuickAccessToolbarControlClone(openXmlElement);
      value.UnsizedButton = GetUnsizedButton(openXmlElement);
      value.VerticalSeparator = GetVerticalSeparator(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.UI.SharedQatControls? value)
    where OpenXmlElementType : SharedQatControls, new()
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