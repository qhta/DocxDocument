namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the BackstageMenuGroup Class.
/// </summary>
public static class BackstageMenuGroupConverter
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup? openXmlElement, String? value)
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
  public static String? GetQualifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup? openXmlElement)
  {
    return openXmlElement?.QualifiedId?.Value;
  }
  
  public static void SetQualifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup? openXmlElement, String? value)
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
  public static String? GetTag(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup? openXmlElement)
  {
    return openXmlElement?.Tag?.Value;
  }
  
  public static void SetTag(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Tag = new StringValue { Value = value };
      else
        openXmlElement.Tag = null;
  }
  
  /// <summary>
  /// label, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup? openXmlElement)
  {
    return openXmlElement?.Label?.Value;
  }
  
  public static void SetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Label = new StringValue { Value = value };
      else
        openXmlElement.Label = null;
  }
  
  /// <summary>
  /// getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup? openXmlElement)
  {
    return openXmlElement?.GetLabel?.Value;
  }
  
  public static void SetGetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetLabel = new StringValue { Value = value };
      else
        openXmlElement.GetLabel = null;
  }
  
  /// <summary>
  /// itemSize, this property is only available in Office 2010 and later.
  /// </summary>
  public static DocumentModel.ItemSizeKind? GetItemSize(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues, DocumentModel.ItemSizeKind>(openXmlElement?.ItemSize?.Value);
  }
  
  public static void SetItemSize(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup? openXmlElement, DocumentModel.ItemSizeKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.ItemSize = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues, DocumentModel.ItemSizeKind>(value);
  }
  
  public static DocumentModel.BackstageMenuButton? GetBackstageMenuButton(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuButton>();
    if (itemElement != null)
      return DocumentModel.OpenXml.BackstageMenuButtonConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBackstageMenuButton(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup? openXmlElement, DocumentModel.BackstageMenuButton? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.BackstageMenuCheckBox? GetBackstageMenuCheckBox(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuCheckBox>();
    if (itemElement != null)
      return DocumentModel.OpenXml.BackstageMenuCheckBoxConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBackstageMenuCheckBox(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup? openXmlElement, DocumentModel.BackstageMenuCheckBox? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.BackstageSubMenu? GetBackstageSubMenu(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageSubMenu>();
    if (itemElement != null)
      return DocumentModel.OpenXml.BackstageSubMenuConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBackstageSubMenu(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup? openXmlElement, DocumentModel.BackstageSubMenu? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.BackstageMenuToggleButton? GetBackstageMenuToggleButton(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuToggleButton>();
    if (itemElement != null)
      return DocumentModel.OpenXml.BackstageMenuToggleButtonConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBackstageMenuToggleButton(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup? openXmlElement, DocumentModel.BackstageMenuToggleButton? value)
  {
    if (openXmlElement != null)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
