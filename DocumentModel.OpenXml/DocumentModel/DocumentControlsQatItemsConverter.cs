namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the DocumentControlsQatItems Class.
/// </summary>
public static class DocumentControlsQatItemsConverter
{
  public static DocumentModel.ControlCloneQat? GetControlCloneQat(DocumentFormat.OpenXml.Office2010.CustomUI.DocumentControlsQatItems? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ControlCloneQat>();
    if (itemElement != null)
      return DocumentModel.OpenXml.ControlCloneQatConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetControlCloneQat(DocumentFormat.OpenXml.Office2010.CustomUI.DocumentControlsQatItems? openXmlElement, DocumentModel.ControlCloneQat? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ControlCloneQat>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.ControlCloneQatConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.ControlCloneQat>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.ButtonRegular? GetButtonRegular(DocumentFormat.OpenXml.Office2010.CustomUI.DocumentControlsQatItems? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular>();
    if (itemElement != null)
      return DocumentModel.OpenXml.ButtonRegularConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetButtonRegular(DocumentFormat.OpenXml.Office2010.CustomUI.DocumentControlsQatItems? openXmlElement, DocumentModel.ButtonRegular? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.ButtonRegularConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Separator? GetSeparator(DocumentFormat.OpenXml.Office2010.CustomUI.DocumentControlsQatItems? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Separator>();
    if (itemElement != null)
      return DocumentModel.OpenXml.SeparatorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSeparator(DocumentFormat.OpenXml.Office2010.CustomUI.DocumentControlsQatItems? openXmlElement, DocumentModel.Separator? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Separator>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.SeparatorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.Separator>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.DocumentControlsQatItems? CreateModelElement(DocumentFormat.OpenXml.Office2010.CustomUI.DocumentControlsQatItems? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.DocumentControlsQatItems();
      value.ControlCloneQat = GetControlCloneQat(openXmlElement);
      value.ButtonRegular = GetButtonRegular(openXmlElement);
      value.Separator = GetSeparator(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.DocumentControlsQatItems? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.CustomUI.DocumentControlsQatItems, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
