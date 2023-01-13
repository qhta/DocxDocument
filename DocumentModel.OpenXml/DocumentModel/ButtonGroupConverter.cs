namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the ButtonGroup Class.
/// </summary>
public static class ButtonGroupConverter
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonGroup? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonGroup? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }
  
  /// <summary>
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetQualifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonGroup? openXmlElement)
  {
    return openXmlElement?.QualifiedId?.Value;
  }
  
  public static void SetQualifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonGroup? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.QualifiedId = new StringValue { Value = value };
      else
        openXmlElement.QualifiedId = null;
  }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetTag(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonGroup? openXmlElement)
  {
    return openXmlElement?.Tag?.Value;
  }
  
  public static void SetTag(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonGroup? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Tag = new StringValue { Value = value };
      else
        openXmlElement.Tag = null;
  }
  
  /// <summary>
  /// visible, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonGroup? openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  public static void SetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonGroup? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Visible = null;
  }
  
  /// <summary>
  /// getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonGroup? openXmlElement)
  {
    return openXmlElement?.GetVisible?.Value;
  }
  
  public static void SetGetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonGroup? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetVisible = new StringValue { Value = value };
      else
        openXmlElement.GetVisible = null;
  }
  
  /// <summary>
  /// insertAfterMso, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetInsertAfterMso(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonGroup? openXmlElement)
  {
    return openXmlElement?.InsertAfterMso?.Value;
  }
  
  public static void SetInsertAfterMso(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonGroup? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.InsertAfterMso = new StringValue { Value = value };
      else
        openXmlElement.InsertAfterMso = null;
  }
  
  /// <summary>
  /// insertBeforeMso, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetInsertBeforeMso(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonGroup? openXmlElement)
  {
    return openXmlElement?.InsertBeforeMso?.Value;
  }
  
  public static void SetInsertBeforeMso(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonGroup? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.InsertBeforeMso = new StringValue { Value = value };
      else
        openXmlElement.InsertBeforeMso = null;
  }
  
  /// <summary>
  /// insertAfterQ, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetInsertAfterQulifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonGroup? openXmlElement)
  {
    return openXmlElement?.InsertAfterQulifiedId?.Value;
  }
  
  public static void SetInsertAfterQulifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonGroup? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.InsertAfterQulifiedId = new StringValue { Value = value };
      else
        openXmlElement.InsertAfterQulifiedId = null;
  }
  
  /// <summary>
  /// insertBeforeQ, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetInsertBeforeQulifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonGroup? openXmlElement)
  {
    return openXmlElement?.InsertBeforeQulifiedId?.Value;
  }
  
  public static void SetInsertBeforeQulifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonGroup? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.InsertBeforeQulifiedId = new StringValue { Value = value };
      else
        openXmlElement.InsertBeforeQulifiedId = null;
  }
  
  public static DocumentModel.ControlCloneRegular? GetControlCloneRegular(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonGroup? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ControlCloneRegular>();
    if (itemElement != null)
      return DocumentModel.OpenXml.ControlCloneRegularConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetControlCloneRegular(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonGroup? openXmlElement, DocumentModel.ControlCloneRegular? value)
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
  
  public static DocumentModel.ButtonRegular? GetButtonRegular(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonGroup? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular>();
    if (itemElement != null)
      return DocumentModel.OpenXml.ButtonRegularConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetButtonRegular(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonGroup? openXmlElement, DocumentModel.ButtonRegular? value)
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
  
  public static DocumentModel.ToggleButtonRegular? GetToggleButtonRegular(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonGroup? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ToggleButtonRegular>();
    if (itemElement != null)
      return DocumentModel.OpenXml.ToggleButtonRegularConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetToggleButtonRegular(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonGroup? openXmlElement, DocumentModel.ToggleButtonRegular? value)
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
  
  public static DocumentModel.GalleryRegular? GetGalleryRegular(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonGroup? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular>();
    if (itemElement != null)
      return DocumentModel.OpenXml.GalleryRegularConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetGalleryRegular(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonGroup? openXmlElement, DocumentModel.GalleryRegular? value)
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
  
  public static DocumentModel.MenuRegular? GetMenuRegular(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonGroup? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.MenuRegular>();
    if (itemElement != null)
      return DocumentModel.OpenXml.MenuRegularConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetMenuRegular(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonGroup? openXmlElement, DocumentModel.MenuRegular? value)
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
  
  public static DocumentModel.DynamicMenuRegular? GetDynamicMenuRegular(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonGroup? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.DynamicMenuRegular>();
    if (itemElement != null)
      return DocumentModel.OpenXml.DynamicMenuRegularConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDynamicMenuRegular(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonGroup? openXmlElement, DocumentModel.DynamicMenuRegular? value)
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
  
  public static DocumentModel.SplitButtonRegular? GetSplitButtonRegular(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonGroup? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular>();
    if (itemElement != null)
      return DocumentModel.OpenXml.SplitButtonRegularConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSplitButtonRegular(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonGroup? openXmlElement, DocumentModel.SplitButtonRegular? value)
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
  
  public static DocumentModel.Separator? GetSeparator(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonGroup? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Separator>();
    if (itemElement != null)
      return DocumentModel.OpenXml.SeparatorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSeparator(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonGroup? openXmlElement, DocumentModel.Separator? value)
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
  
  public static DocumentModel.ButtonGroup? CreateModelElement(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonGroup? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.ButtonGroup();
      value.Id = GetId(openXmlElement);
      value.QualifiedId = GetQualifiedId(openXmlElement);
      value.Tag = GetTag(openXmlElement);
      value.Visible = GetVisible(openXmlElement);
      value.GetVisible = GetGetVisible(openXmlElement);
      value.InsertAfterMso = GetInsertAfterMso(openXmlElement);
      value.InsertBeforeMso = GetInsertBeforeMso(openXmlElement);
      value.InsertAfterQulifiedId = GetInsertAfterQulifiedId(openXmlElement);
      value.InsertBeforeQulifiedId = GetInsertBeforeQulifiedId(openXmlElement);
      value.ControlCloneRegular = GetControlCloneRegular(openXmlElement);
      value.ButtonRegular = GetButtonRegular(openXmlElement);
      value.ToggleButtonRegular = GetToggleButtonRegular(openXmlElement);
      value.GalleryRegular = GetGalleryRegular(openXmlElement);
      value.MenuRegular = GetMenuRegular(openXmlElement);
      value.DynamicMenuRegular = GetDynamicMenuRegular(openXmlElement);
      value.SplitButtonRegular = GetSplitButtonRegular(openXmlElement);
      value.Separator = GetSeparator(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.ButtonGroup? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.CustomUI.ButtonGroup, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetQualifiedId(openXmlElement, value?.QualifiedId);
      SetTag(openXmlElement, value?.Tag);
      SetVisible(openXmlElement, value?.Visible);
      SetGetVisible(openXmlElement, value?.GetVisible);
      SetInsertAfterMso(openXmlElement, value?.InsertAfterMso);
      SetInsertBeforeMso(openXmlElement, value?.InsertBeforeMso);
      SetInsertAfterQulifiedId(openXmlElement, value?.InsertAfterQulifiedId);
      SetInsertBeforeQulifiedId(openXmlElement, value?.InsertBeforeQulifiedId);
      SetControlCloneRegular(openXmlElement, value?.ControlCloneRegular);
      SetButtonRegular(openXmlElement, value?.ButtonRegular);
      SetToggleButtonRegular(openXmlElement, value?.ToggleButtonRegular);
      SetGalleryRegular(openXmlElement, value?.GalleryRegular);
      SetMenuRegular(openXmlElement, value?.MenuRegular);
      SetDynamicMenuRegular(openXmlElement, value?.DynamicMenuRegular);
      SetSplitButtonRegular(openXmlElement, value?.SplitButtonRegular);
      SetSeparator(openXmlElement, value?.Separator);
      return openXmlElement;
    }
    return default;
  }
}
