namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the SharedQatControls Class.
/// </summary>
public static class SharedQatControlsConverter
{
  public static DocumentModel.UI.QuickAccessToolbarControlClone? GetQuickAccessToolbarControlClone(DocumentFormat.OpenXml.Office.CustomUI.SharedQatControls? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.QuickAccessToolbarControlClone>();
    if (itemElement != null)
      return DocumentModel.OpenXml.UI.QuickAccessToolbarControlCloneConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetQuickAccessToolbarControlClone(DocumentFormat.OpenXml.Office.CustomUI.SharedQatControls? openXmlElement, DocumentModel.UI.QuickAccessToolbarControlClone? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.QuickAccessToolbarControlClone>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.UI.QuickAccessToolbarControlCloneConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.QuickAccessToolbarControlClone>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.UI.UnsizedButton? GetUnsizedButton(DocumentFormat.OpenXml.Office.CustomUI.SharedQatControls? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton>();
    if (itemElement != null)
      return DocumentModel.OpenXml.UI.UnsizedButtonConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetUnsizedButton(DocumentFormat.OpenXml.Office.CustomUI.SharedQatControls? openXmlElement, DocumentModel.UI.UnsizedButton? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.UI.UnsizedButtonConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.UI.VerticalSeparator? GetVerticalSeparator(DocumentFormat.OpenXml.Office.CustomUI.SharedQatControls? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.VerticalSeparator>();
    if (itemElement != null)
      return DocumentModel.OpenXml.UI.VerticalSeparatorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetVerticalSeparator(DocumentFormat.OpenXml.Office.CustomUI.SharedQatControls? openXmlElement, DocumentModel.UI.VerticalSeparator? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.VerticalSeparator>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.UI.VerticalSeparatorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.VerticalSeparator>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.UI.SharedQatControls? CreateModelElement(DocumentFormat.OpenXml.Office.CustomUI.SharedQatControls? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Office.CustomUI.SharedQatControls, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
