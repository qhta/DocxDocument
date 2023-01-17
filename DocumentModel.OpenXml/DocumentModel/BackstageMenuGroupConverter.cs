namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the BackstageMenuGroup Class.
/// </summary>
public static class BackstageMenuGroupConverter
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetId(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetQualifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup openXmlElement)
  {
    return openXmlElement?.QualifiedId?.Value;
  }
  
  private static void SetQualifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.QualifiedId = new StringValue { Value = value };
    else
      openXmlElement.QualifiedId = null;
  }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetTag(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup openXmlElement)
  {
    return openXmlElement?.Tag?.Value;
  }
  
  private static void SetTag(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Tag = new StringValue { Value = value };
    else
      openXmlElement.Tag = null;
  }
  
  /// <summary>
  /// label, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup openXmlElement)
  {
    return openXmlElement?.Label?.Value;
  }
  
  private static void SetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Label = new StringValue { Value = value };
    else
      openXmlElement.Label = null;
  }
  
  /// <summary>
  /// getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup openXmlElement)
  {
    return openXmlElement?.GetLabel?.Value;
  }
  
  private static void SetGetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetLabel = new StringValue { Value = value };
    else
      openXmlElement.GetLabel = null;
  }
  
  /// <summary>
  /// itemSize, this property is only available in Office 2010 and later.
  /// </summary>
  private static DocumentModel.ItemSizeKind? GetItemSize(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues, DocumentModel.ItemSizeKind>(openXmlElement?.ItemSize?.Value);
  }
  
  private static void SetItemSize(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup openXmlElement, DocumentModel.ItemSizeKind? value)
  {
    openXmlElement.ItemSize = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues, DocumentModel.ItemSizeKind>(value);
  }
  
  private static DocumentModel.BackstageMenuButton? GetBackstageMenuButton(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuButton>();
    if (itemElement != null)
      return DocumentModel.OpenXml.BackstageMenuButtonConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBackstageMenuButton(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup openXmlElement, DocumentModel.BackstageMenuButton? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuButton>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.BackstageMenuButtonConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuButton>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.BackstageMenuCheckBox? GetBackstageMenuCheckBox(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuCheckBox>();
    if (itemElement != null)
      return DocumentModel.OpenXml.BackstageMenuCheckBoxConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBackstageMenuCheckBox(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup openXmlElement, DocumentModel.BackstageMenuCheckBox? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuCheckBox>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.BackstageMenuCheckBoxConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuCheckBox>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.BackstageSubMenu? GetBackstageSubMenu(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageSubMenu>();
    if (itemElement != null)
      return DocumentModel.OpenXml.BackstageSubMenuConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBackstageSubMenu(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup openXmlElement, DocumentModel.BackstageSubMenu? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageSubMenu>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.BackstageSubMenuConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageSubMenu>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.BackstageMenuToggleButton? GetBackstageMenuToggleButton(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuToggleButton>();
    if (itemElement != null)
      return DocumentModel.OpenXml.BackstageMenuToggleButtonConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBackstageMenuToggleButton(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup openXmlElement, DocumentModel.BackstageMenuToggleButton? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuToggleButton>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.BackstageMenuToggleButtonConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuToggleButton>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.BackstageMenuGroup? CreateModelElement(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.BackstageMenuGroup();
      value.Id = GetId(openXmlElement);
      value.QualifiedId = GetQualifiedId(openXmlElement);
      value.Tag = GetTag(openXmlElement);
      value.Label = GetLabel(openXmlElement);
      value.GetLabel = GetGetLabel(openXmlElement);
      value.ItemSize = GetItemSize(openXmlElement);
      value.BackstageMenuButton = GetBackstageMenuButton(openXmlElement);
      value.BackstageMenuCheckBox = GetBackstageMenuCheckBox(openXmlElement);
      value.BackstageSubMenu = GetBackstageSubMenu(openXmlElement);
      value.BackstageMenuToggleButton = GetBackstageMenuToggleButton(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.BackstageMenuGroup? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetQualifiedId(openXmlElement, value?.QualifiedId);
      SetTag(openXmlElement, value?.Tag);
      SetLabel(openXmlElement, value?.Label);
      SetGetLabel(openXmlElement, value?.GetLabel);
      SetItemSize(openXmlElement, value?.ItemSize);
      SetBackstageMenuButton(openXmlElement, value?.BackstageMenuButton);
      SetBackstageMenuCheckBox(openXmlElement, value?.BackstageMenuCheckBox);
      SetBackstageSubMenu(openXmlElement, value?.BackstageSubMenu);
      SetBackstageMenuToggleButton(openXmlElement, value?.BackstageMenuToggleButton);
      return openXmlElement;
    }
    return default;
  }
}
