namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the PrimaryItem Class.
/// </summary>
public static class PrimaryItemConverter
{
  /// <summary>
  /// BackstageRegularButton.
  /// </summary>
  public static DocumentModel.BackstageRegularButton? GetBackstageRegularButton(DocumentFormat.OpenXml.Office2010.CustomUI.PrimaryItem? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageRegularButton>();
    if (itemElement != null)
      return DocumentModel.OpenXml.BackstageRegularButtonConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBackstageRegularButton(DocumentFormat.OpenXml.Office2010.CustomUI.PrimaryItem? openXmlElement, DocumentModel.BackstageRegularButton? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageRegularButton>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.BackstageRegularButtonConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageRegularButton>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// BackstagePrimaryMenu.
  /// </summary>
  public static DocumentModel.BackstagePrimaryMenu? GetBackstagePrimaryMenu(DocumentFormat.OpenXml.Office2010.CustomUI.PrimaryItem? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstagePrimaryMenu>();
    if (itemElement != null)
      return DocumentModel.OpenXml.BackstagePrimaryMenuConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBackstagePrimaryMenu(DocumentFormat.OpenXml.Office2010.CustomUI.PrimaryItem? openXmlElement, DocumentModel.BackstagePrimaryMenu? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstagePrimaryMenu>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.BackstagePrimaryMenuConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.BackstagePrimaryMenu>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.PrimaryItem? CreateModelElement(DocumentFormat.OpenXml.Office2010.CustomUI.PrimaryItem? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.PrimaryItem();
      value.BackstageRegularButton = GetBackstageRegularButton(openXmlElement);
      value.BackstagePrimaryMenu = GetBackstagePrimaryMenu(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.PrimaryItem? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.CustomUI.PrimaryItem, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBackstageRegularButton(openXmlElement, value?.BackstageRegularButton);
      SetBackstagePrimaryMenu(openXmlElement, value?.BackstagePrimaryMenu);
      return openXmlElement;
    }
    return default;
  }
}
