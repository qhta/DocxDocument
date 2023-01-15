namespace DocumentModel.OpenXml;

/// <summary>
///   Defines the SplitButtonRegular Class.
/// </summary>
public static class SplitButtonRegularConverter
{
  /// <summary>
  ///   enabled, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetEnabled(DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular? openXmlElement)
  {
    return openXmlElement?.Enabled?.Value;
  }

  public static void SetEnabled(DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Enabled = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Enabled = null;
  }

  /// <summary>
  ///   getEnabled, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetEnabled(DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular? openXmlElement)
  {
    return openXmlElement?.GetEnabled?.Value;
  }

  public static void SetGetEnabled(DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetEnabled = new StringValue { Value = value };
      else
        openXmlElement.GetEnabled = null;
  }

  /// <summary>
  ///   id, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular? openXmlElement, String? value)
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
  public static String? GetQualifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular? openXmlElement)
  {
    return openXmlElement?.QualifiedId?.Value;
  }

  public static void SetQualifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular? openXmlElement, String? value)
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
  public static String? GetTag(DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular? openXmlElement)
  {
    return openXmlElement?.Tag?.Value;
  }

  public static void SetTag(DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Tag = new StringValue { Value = value };
      else
        openXmlElement.Tag = null;
  }

  /// <summary>
  ///   idMso, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetIdMso(DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular? openXmlElement)
  {
    return openXmlElement?.IdMso?.Value;
  }

  public static void SetIdMso(DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.IdMso = new StringValue { Value = value };
      else
        openXmlElement.IdMso = null;
  }

  /// <summary>
  ///   insertAfterMso, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetInsertAfterMso(DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular? openXmlElement)
  {
    return openXmlElement?.InsertAfterMso?.Value;
  }

  public static void SetInsertAfterMso(DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.InsertAfterMso = new StringValue { Value = value };
      else
        openXmlElement.InsertAfterMso = null;
  }

  /// <summary>
  ///   insertBeforeMso, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetInsertBeforeMso(DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular? openXmlElement)
  {
    return openXmlElement?.InsertBeforeMso?.Value;
  }

  public static void SetInsertBeforeMso(DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.InsertBeforeMso = new StringValue { Value = value };
      else
        openXmlElement.InsertBeforeMso = null;
  }

  /// <summary>
  ///   insertAfterQ, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetInsertAfterQulifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular? openXmlElement)
  {
    return openXmlElement?.InsertAfterQulifiedId?.Value;
  }

  public static void SetInsertAfterQulifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.InsertAfterQulifiedId = new StringValue { Value = value };
      else
        openXmlElement.InsertAfterQulifiedId = null;
  }

  /// <summary>
  ///   insertBeforeQ, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetInsertBeforeQulifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular? openXmlElement)
  {
    return openXmlElement?.InsertBeforeQulifiedId?.Value;
  }

  public static void SetInsertBeforeQulifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.InsertBeforeQulifiedId = new StringValue { Value = value };
      else
        openXmlElement.InsertBeforeQulifiedId = null;
  }

  /// <summary>
  ///   visible, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular? openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }

  public static void SetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Visible = null;
  }

  /// <summary>
  ///   getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular? openXmlElement)
  {
    return openXmlElement?.GetVisible?.Value;
  }

  public static void SetGetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetVisible = new StringValue { Value = value };
      else
        openXmlElement.GetVisible = null;
  }

  /// <summary>
  ///   keytip, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetKeytip(DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular? openXmlElement)
  {
    return openXmlElement?.Keytip?.Value;
  }

  public static void SetKeytip(DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Keytip = new StringValue { Value = value };
      else
        openXmlElement.Keytip = null;
  }

  /// <summary>
  ///   getKeytip, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetKeytip(DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular? openXmlElement)
  {
    return openXmlElement?.GetKeytip?.Value;
  }

  public static void SetGetKeytip(DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetKeytip = new StringValue { Value = value };
      else
        openXmlElement.GetKeytip = null;
  }

  /// <summary>
  ///   showLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetShowLabel(DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular? openXmlElement)
  {
    return openXmlElement?.ShowLabel?.Value;
  }

  public static void SetShowLabel(DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ShowLabel = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.ShowLabel = null;
  }

  /// <summary>
  ///   getShowLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetShowLabel(DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular? openXmlElement)
  {
    return openXmlElement?.GetShowLabel?.Value;
  }

  public static void SetGetShowLabel(DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetShowLabel = new StringValue { Value = value };
      else
        openXmlElement.GetShowLabel = null;
  }

  public static VisibleButton? GetVisibleButton(DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.VisibleButton>();
    if (itemElement != null)
      return VisibleButtonConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetVisibleButton(DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular? openXmlElement, VisibleButton? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.VisibleButton>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = VisibleButtonConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.VisibleButton>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static VisibleToggleButton? GetVisibleToggleButton(DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.VisibleToggleButton>();
    if (itemElement != null)
      return VisibleToggleButtonConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetVisibleToggleButton(DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular? openXmlElement, VisibleToggleButton? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.VisibleToggleButton>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = VisibleToggleButtonConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.VisibleToggleButton>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static MenuRegular? GetMenuRegular(DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.MenuRegular>();
    if (itemElement != null)
      return MenuRegularConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMenuRegular(DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular? openXmlElement, MenuRegular? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.MenuRegular>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MenuRegularConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.MenuRegular>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static SplitButtonRegular? CreateModelElement(DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new SplitButtonRegular();
      value.Enabled = GetEnabled(openXmlElement);
      value.GetEnabled = GetGetEnabled(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.QualifiedId = GetQualifiedId(openXmlElement);
      value.Tag = GetTag(openXmlElement);
      value.IdMso = GetIdMso(openXmlElement);
      value.InsertAfterMso = GetInsertAfterMso(openXmlElement);
      value.InsertBeforeMso = GetInsertBeforeMso(openXmlElement);
      value.InsertAfterQulifiedId = GetInsertAfterQulifiedId(openXmlElement);
      value.InsertBeforeQulifiedId = GetInsertBeforeQulifiedId(openXmlElement);
      value.Visible = GetVisible(openXmlElement);
      value.GetVisible = GetGetVisible(openXmlElement);
      value.Keytip = GetKeytip(openXmlElement);
      value.GetKeytip = GetGetKeytip(openXmlElement);
      value.ShowLabel = GetShowLabel(openXmlElement);
      value.GetShowLabel = GetGetShowLabel(openXmlElement);
      value.VisibleButton = GetVisibleButton(openXmlElement);
      value.VisibleToggleButton = GetVisibleToggleButton(openXmlElement);
      value.MenuRegular = GetMenuRegular(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(SplitButtonRegular? value)
    where OpenXmlElementType : DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetEnabled(openXmlElement, value?.Enabled);
      SetGetEnabled(openXmlElement, value?.GetEnabled);
      SetId(openXmlElement, value?.Id);
      SetQualifiedId(openXmlElement, value?.QualifiedId);
      SetTag(openXmlElement, value?.Tag);
      SetIdMso(openXmlElement, value?.IdMso);
      SetInsertAfterMso(openXmlElement, value?.InsertAfterMso);
      SetInsertBeforeMso(openXmlElement, value?.InsertBeforeMso);
      SetInsertAfterQulifiedId(openXmlElement, value?.InsertAfterQulifiedId);
      SetInsertBeforeQulifiedId(openXmlElement, value?.InsertBeforeQulifiedId);
      SetVisible(openXmlElement, value?.Visible);
      SetGetVisible(openXmlElement, value?.GetVisible);
      SetKeytip(openXmlElement, value?.Keytip);
      SetGetKeytip(openXmlElement, value?.GetKeytip);
      SetShowLabel(openXmlElement, value?.ShowLabel);
      SetGetShowLabel(openXmlElement, value?.GetShowLabel);
      SetVisibleButton(openXmlElement, value?.VisibleButton);
      SetVisibleToggleButton(openXmlElement, value?.VisibleToggleButton);
      SetMenuRegular(openXmlElement, value?.MenuRegular);
      return openXmlElement;
    }
    return default;
  }
}