using DocumentFormat.OpenXml.Office2010.CustomUI;

namespace DocumentModel.OpenXml;

/// <summary>
///   Defines the BackstageMenuGroup Class.
/// </summary>
public static class BackstageMenuGroupConverter
{
  /// <summary>
  ///   id, this property is only available in Office 2010 and later.
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
  ///   idQ, this property is only available in Office 2010 and later.
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
  ///   tag, this property is only available in Office 2010 and later.
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
  ///   label, this property is only available in Office 2010 and later.
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
  ///   getLabel, this property is only available in Office 2010 and later.
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
  ///   itemSize, this property is only available in Office 2010 and later.
  /// </summary>
  public static ItemSizeKind? GetItemSize(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup? openXmlElement)
  {
    return EnumValueConverter.GetValue<ItemSizeValues, ItemSizeKind>(openXmlElement?.ItemSize?.Value);
  }

  public static void SetItemSize(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup? openXmlElement, ItemSizeKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.ItemSize = EnumValueConverter.CreateEnumValue<ItemSizeValues, ItemSizeKind>(value);
  }

  public static BackstageMenuButton? GetBackstageMenuButton(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuButton>();
    if (itemElement != null)
      return BackstageMenuButtonConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBackstageMenuButton(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup? openXmlElement, BackstageMenuButton? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuButton>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BackstageMenuButtonConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuButton>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static BackstageMenuCheckBox? GetBackstageMenuCheckBox(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuCheckBox>();
    if (itemElement != null)
      return BackstageMenuCheckBoxConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBackstageMenuCheckBox(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup? openXmlElement, BackstageMenuCheckBox? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuCheckBox>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BackstageMenuCheckBoxConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuCheckBox>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static BackstageSubMenu? GetBackstageSubMenu(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageSubMenu>();
    if (itemElement != null)
      return BackstageSubMenuConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBackstageSubMenu(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup? openXmlElement, BackstageSubMenu? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageSubMenu>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BackstageSubMenuConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageSubMenu>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static BackstageMenuToggleButton? GetBackstageMenuToggleButton(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuToggleButton>();
    if (itemElement != null)
      return BackstageMenuToggleButtonConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBackstageMenuToggleButton(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup? openXmlElement, BackstageMenuToggleButton? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuToggleButton>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BackstageMenuToggleButtonConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuToggleButton>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static BackstageMenuGroup? CreateModelElement(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new BackstageMenuGroup();
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(BackstageMenuGroup? value)
    where OpenXmlElementType : DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup, new()
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