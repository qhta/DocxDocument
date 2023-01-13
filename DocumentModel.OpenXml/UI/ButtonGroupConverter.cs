namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the ButtonGroup Class.
/// </summary>
public static class ButtonGroupConverter
{
  /// <summary>
  /// id
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Office.CustomUI.ButtonGroup? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Office.CustomUI.ButtonGroup? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }
  
  /// <summary>
  /// idQ
  /// </summary>
  public static String? GetIdQ(DocumentFormat.OpenXml.Office.CustomUI.ButtonGroup? openXmlElement)
  {
    return openXmlElement?.IdQ?.Value;
  }
  
  public static void SetIdQ(DocumentFormat.OpenXml.Office.CustomUI.ButtonGroup? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.IdQ = new StringValue { Value = value };
      else
        openXmlElement.IdQ = null;
  }
  
  /// <summary>
  /// visible
  /// </summary>
  public static Boolean? GetVisible(DocumentFormat.OpenXml.Office.CustomUI.ButtonGroup? openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  public static void SetVisible(DocumentFormat.OpenXml.Office.CustomUI.ButtonGroup? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Visible = null;
  }
  
  /// <summary>
  /// getVisible
  /// </summary>
  public static String? GetGetVisible(DocumentFormat.OpenXml.Office.CustomUI.ButtonGroup? openXmlElement)
  {
    return openXmlElement?.GetVisible?.Value;
  }
  
  public static void SetGetVisible(DocumentFormat.OpenXml.Office.CustomUI.ButtonGroup? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetVisible = new StringValue { Value = value };
      else
        openXmlElement.GetVisible = null;
  }
  
  /// <summary>
  /// insertAfterMso
  /// </summary>
  public static String? GetInsertAfterMso(DocumentFormat.OpenXml.Office.CustomUI.ButtonGroup? openXmlElement)
  {
    return openXmlElement?.InsertAfterMso?.Value;
  }
  
  public static void SetInsertAfterMso(DocumentFormat.OpenXml.Office.CustomUI.ButtonGroup? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.InsertAfterMso = new StringValue { Value = value };
      else
        openXmlElement.InsertAfterMso = null;
  }
  
  /// <summary>
  /// insertBeforeMso
  /// </summary>
  public static String? GetInsertBeforeMso(DocumentFormat.OpenXml.Office.CustomUI.ButtonGroup? openXmlElement)
  {
    return openXmlElement?.InsertBeforeMso?.Value;
  }
  
  public static void SetInsertBeforeMso(DocumentFormat.OpenXml.Office.CustomUI.ButtonGroup? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.InsertBeforeMso = new StringValue { Value = value };
      else
        openXmlElement.InsertBeforeMso = null;
  }
  
  /// <summary>
  /// insertAfterQ
  /// </summary>
  public static String? GetInsertAfterQ(DocumentFormat.OpenXml.Office.CustomUI.ButtonGroup? openXmlElement)
  {
    return openXmlElement?.InsertAfterQ?.Value;
  }
  
  public static void SetInsertAfterQ(DocumentFormat.OpenXml.Office.CustomUI.ButtonGroup? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.InsertAfterQ = new StringValue { Value = value };
      else
        openXmlElement.InsertAfterQ = null;
  }
  
  /// <summary>
  /// insertBeforeQ
  /// </summary>
  public static String? GetInsertBeforeQ(DocumentFormat.OpenXml.Office.CustomUI.ButtonGroup? openXmlElement)
  {
    return openXmlElement?.InsertBeforeQ?.Value;
  }
  
  public static void SetInsertBeforeQ(DocumentFormat.OpenXml.Office.CustomUI.ButtonGroup? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.InsertBeforeQ = new StringValue { Value = value };
      else
        openXmlElement.InsertBeforeQ = null;
  }
  
  public static DocumentModel.UI.UnsizedControlClone? GetUnsizedControlClone(DocumentFormat.OpenXml.Office.CustomUI.ButtonGroup? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedControlClone>();
    if (itemElement != null)
      return DocumentModel.OpenXml.UI.UnsizedControlCloneConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetUnsizedControlClone(DocumentFormat.OpenXml.Office.CustomUI.ButtonGroup? openXmlElement, DocumentModel.UI.UnsizedControlClone? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedControlClone>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.UI.UnsizedControlCloneConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.UnsizedControlClone>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.UI.UnsizedButton? GetUnsizedButton(DocumentFormat.OpenXml.Office.CustomUI.ButtonGroup? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton>();
    if (itemElement != null)
      return DocumentModel.OpenXml.UI.UnsizedButtonConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetUnsizedButton(DocumentFormat.OpenXml.Office.CustomUI.ButtonGroup? openXmlElement, DocumentModel.UI.UnsizedButton? value)
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
  
  public static DocumentModel.UI.UnsizedToggleButton? GetUnsizedToggleButton(DocumentFormat.OpenXml.Office.CustomUI.ButtonGroup? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedToggleButton>();
    if (itemElement != null)
      return DocumentModel.OpenXml.UI.UnsizedToggleButtonConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetUnsizedToggleButton(DocumentFormat.OpenXml.Office.CustomUI.ButtonGroup? openXmlElement, DocumentModel.UI.UnsizedToggleButton? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedToggleButton>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.UI.UnsizedToggleButtonConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.UnsizedToggleButton>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.UI.UnsizedGallery? GetUnsizedGallery(DocumentFormat.OpenXml.Office.CustomUI.ButtonGroup? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery>();
    if (itemElement != null)
      return DocumentModel.OpenXml.UI.UnsizedGalleryConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetUnsizedGallery(DocumentFormat.OpenXml.Office.CustomUI.ButtonGroup? openXmlElement, DocumentModel.UI.UnsizedGallery? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.UI.UnsizedGalleryConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.UI.UnsizedMenu? GetUnsizedMenu(DocumentFormat.OpenXml.Office.CustomUI.ButtonGroup? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu>();
    if (itemElement != null)
      return DocumentModel.OpenXml.UI.UnsizedMenuConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetUnsizedMenu(DocumentFormat.OpenXml.Office.CustomUI.ButtonGroup? openXmlElement, DocumentModel.UI.UnsizedMenu? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.UI.UnsizedMenuConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.UI.UnsizedDynamicMenu? GetUnsizedDynamicMenu(DocumentFormat.OpenXml.Office.CustomUI.ButtonGroup? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedDynamicMenu>();
    if (itemElement != null)
      return DocumentModel.OpenXml.UI.UnsizedDynamicMenuConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetUnsizedDynamicMenu(DocumentFormat.OpenXml.Office.CustomUI.ButtonGroup? openXmlElement, DocumentModel.UI.UnsizedDynamicMenu? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedDynamicMenu>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.UI.UnsizedDynamicMenuConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.UnsizedDynamicMenu>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.UI.UnsizedSplitButton? GetUnsizedSplitButton(DocumentFormat.OpenXml.Office.CustomUI.ButtonGroup? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton>();
    if (itemElement != null)
      return DocumentModel.OpenXml.UI.UnsizedSplitButtonConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetUnsizedSplitButton(DocumentFormat.OpenXml.Office.CustomUI.ButtonGroup? openXmlElement, DocumentModel.UI.UnsizedSplitButton? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.UI.UnsizedSplitButtonConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.UI.ButtonGroup? CreateModelElement(DocumentFormat.OpenXml.Office.CustomUI.ButtonGroup? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.UI.ButtonGroup();
      value.Id = GetId(openXmlElement);
      value.IdQ = GetIdQ(openXmlElement);
      value.Visible = GetVisible(openXmlElement);
      value.GetVisible = GetGetVisible(openXmlElement);
      value.InsertAfterMso = GetInsertAfterMso(openXmlElement);
      value.InsertBeforeMso = GetInsertBeforeMso(openXmlElement);
      value.InsertAfterQ = GetInsertAfterQ(openXmlElement);
      value.InsertBeforeQ = GetInsertBeforeQ(openXmlElement);
      value.UnsizedControlClone = GetUnsizedControlClone(openXmlElement);
      value.UnsizedButton = GetUnsizedButton(openXmlElement);
      value.UnsizedToggleButton = GetUnsizedToggleButton(openXmlElement);
      value.UnsizedGallery = GetUnsizedGallery(openXmlElement);
      value.UnsizedMenu = GetUnsizedMenu(openXmlElement);
      value.UnsizedDynamicMenu = GetUnsizedDynamicMenu(openXmlElement);
      value.UnsizedSplitButton = GetUnsizedSplitButton(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.UI.ButtonGroup? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office.CustomUI.ButtonGroup, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetIdQ(openXmlElement, value?.IdQ);
      SetVisible(openXmlElement, value?.Visible);
      SetGetVisible(openXmlElement, value?.GetVisible);
      SetInsertAfterMso(openXmlElement, value?.InsertAfterMso);
      SetInsertBeforeMso(openXmlElement, value?.InsertBeforeMso);
      SetInsertAfterQ(openXmlElement, value?.InsertAfterQ);
      SetInsertBeforeQ(openXmlElement, value?.InsertBeforeQ);
      SetUnsizedControlClone(openXmlElement, value?.UnsizedControlClone);
      SetUnsizedButton(openXmlElement, value?.UnsizedButton);
      SetUnsizedToggleButton(openXmlElement, value?.UnsizedToggleButton);
      SetUnsizedGallery(openXmlElement, value?.UnsizedGallery);
      SetUnsizedMenu(openXmlElement, value?.UnsizedMenu);
      SetUnsizedDynamicMenu(openXmlElement, value?.UnsizedDynamicMenu);
      SetUnsizedSplitButton(openXmlElement, value?.UnsizedSplitButton);
      return openXmlElement;
    }
    return default;
  }
}
