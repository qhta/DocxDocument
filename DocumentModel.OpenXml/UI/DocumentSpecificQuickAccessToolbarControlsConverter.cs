namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the DocumentSpecificQuickAccessToolbarControls Class.
/// </summary>
public static class DocumentSpecificQuickAccessToolbarControlsConverter
{
  public static DocumentModel.UI.QuickAccessToolbarControlClone? GetQuickAccessToolbarControlClone(DocumentFormat.OpenXml.Office.CustomUI.DocumentSpecificQuickAccessToolbarControls? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.QuickAccessToolbarControlClone>();
    if (itemElement != null)
      return DocumentModel.OpenXml.UI.QuickAccessToolbarControlCloneConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetQuickAccessToolbarControlClone(DocumentFormat.OpenXml.Office.CustomUI.DocumentSpecificQuickAccessToolbarControls? openXmlElement, DocumentModel.UI.QuickAccessToolbarControlClone? value)
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
  
  public static DocumentModel.UI.UnsizedButton? GetUnsizedButton(DocumentFormat.OpenXml.Office.CustomUI.DocumentSpecificQuickAccessToolbarControls? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton>();
    if (itemElement != null)
      return DocumentModel.OpenXml.UI.UnsizedButtonConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetUnsizedButton(DocumentFormat.OpenXml.Office.CustomUI.DocumentSpecificQuickAccessToolbarControls? openXmlElement, DocumentModel.UI.UnsizedButton? value)
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
  
  public static DocumentModel.UI.VerticalSeparator? GetVerticalSeparator(DocumentFormat.OpenXml.Office.CustomUI.DocumentSpecificQuickAccessToolbarControls? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.VerticalSeparator>();
    if (itemElement != null)
      return DocumentModel.OpenXml.UI.VerticalSeparatorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetVerticalSeparator(DocumentFormat.OpenXml.Office.CustomUI.DocumentSpecificQuickAccessToolbarControls? openXmlElement, DocumentModel.UI.VerticalSeparator? value)
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
  
  public static DocumentModel.UI.DocumentSpecificQuickAccessToolbarControls? CreateModelElement(DocumentFormat.OpenXml.Office.CustomUI.DocumentSpecificQuickAccessToolbarControls? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Office.CustomUI.DocumentSpecificQuickAccessToolbarControls, new()
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
