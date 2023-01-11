namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the ContextMenu Class.
/// </summary>
public static class ContextMenuConverter
{
  /// <summary>
  /// idMso, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetIdMso(DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu? openXmlElement)
  {
    return openXmlElement?.IdMso?.Value;
  }
  
  public static void SetIdMso(DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.IdMso = new StringValue { Value = value };
      else
        openXmlElement.IdMso = null;
  }
  
  public static DocumentModel.ControlCloneRegular? GetControlCloneRegular(DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ControlCloneRegular>();
    if (itemElement != null)
      return DocumentModel.OpenXml.ControlCloneRegularConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetControlCloneRegular(DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu? openXmlElement, DocumentModel.ControlCloneRegular? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ControlCloneRegular>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.ControlCloneRegularConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.ControlCloneRegular>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.ButtonRegular? GetButtonRegular(DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular>();
    if (itemElement != null)
      return DocumentModel.OpenXml.ButtonRegularConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetButtonRegular(DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu? openXmlElement, DocumentModel.ButtonRegular? value)
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
  
  public static DocumentModel.CheckBox? GetCheckBox(DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.CheckBox>();
    if (itemElement != null)
      return DocumentModel.OpenXml.CheckBoxConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCheckBox(DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu? openXmlElement, DocumentModel.CheckBox? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.CheckBox>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.CheckBoxConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.CheckBox>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.GalleryRegular? GetGalleryRegular(DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular>();
    if (itemElement != null)
      return DocumentModel.OpenXml.GalleryRegularConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetGalleryRegular(DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu? openXmlElement, DocumentModel.GalleryRegular? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.GalleryRegularConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.ToggleButtonRegular? GetToggleButtonRegular(DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ToggleButtonRegular>();
    if (itemElement != null)
      return DocumentModel.OpenXml.ToggleButtonRegularConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetToggleButtonRegular(DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu? openXmlElement, DocumentModel.ToggleButtonRegular? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ToggleButtonRegular>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.ToggleButtonRegularConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.ToggleButtonRegular>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.SplitButtonRegular? GetSplitButtonRegular(DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular>();
    if (itemElement != null)
      return DocumentModel.OpenXml.SplitButtonRegularConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSplitButtonRegular(DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu? openXmlElement, DocumentModel.SplitButtonRegular? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.SplitButtonRegularConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.MenuRegular? GetMenuRegular(DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.MenuRegular>();
    if (itemElement != null)
      return DocumentModel.OpenXml.MenuRegularConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetMenuRegular(DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu? openXmlElement, DocumentModel.MenuRegular? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.MenuRegular>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.MenuRegularConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.MenuRegular>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.DynamicMenuRegular? GetDynamicMenuRegular(DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.DynamicMenuRegular>();
    if (itemElement != null)
      return DocumentModel.OpenXml.DynamicMenuRegularConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDynamicMenuRegular(DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu? openXmlElement, DocumentModel.DynamicMenuRegular? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.DynamicMenuRegular>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.DynamicMenuRegularConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.DynamicMenuRegular>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.MenuSeparatorNoTitle? GetMenuSeparatorNoTitle(DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.MenuSeparatorNoTitle>();
    if (itemElement != null)
      return DocumentModel.OpenXml.MenuSeparatorNoTitleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetMenuSeparatorNoTitle(DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu? openXmlElement, DocumentModel.MenuSeparatorNoTitle? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.MenuSeparatorNoTitle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.MenuSeparatorNoTitleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.MenuSeparatorNoTitle>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.ContextMenu? CreateModelElement(DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.ContextMenu();
      value.IdMso = GetIdMso(openXmlElement);
      value.ControlCloneRegular = GetControlCloneRegular(openXmlElement);
      value.ButtonRegular = GetButtonRegular(openXmlElement);
      value.CheckBox = GetCheckBox(openXmlElement);
      value.GalleryRegular = GetGalleryRegular(openXmlElement);
      value.ToggleButtonRegular = GetToggleButtonRegular(openXmlElement);
      value.SplitButtonRegular = GetSplitButtonRegular(openXmlElement);
      value.MenuRegular = GetMenuRegular(openXmlElement);
      value.DynamicMenuRegular = GetDynamicMenuRegular(openXmlElement);
      value.MenuSeparatorNoTitle = GetMenuSeparatorNoTitle(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.ContextMenu? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
