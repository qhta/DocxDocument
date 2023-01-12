namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the UnsizedSplitButton Class.
/// </summary>
public static class UnsizedSplitButtonConverter
{
  /// <summary>
  /// enabled
  /// </summary>
  public static Boolean? GetEnabled(DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton? openXmlElement)
  {
    return openXmlElement?.Enabled?.Value;
  }
  
  public static void SetEnabled(DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Enabled = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Enabled = null;
  }
  
  /// <summary>
  /// getEnabled
  /// </summary>
  public static String? GetGetEnabled(DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton? openXmlElement)
  {
    return openXmlElement?.GetEnabled?.Value;
  }
  
  public static void SetGetEnabled(DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetEnabled = new StringValue { Value = value };
      else
        openXmlElement.GetEnabled = null;
  }
  
  /// <summary>
  /// id
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton? openXmlElement, String? value)
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
  public static String? GetIdQ(DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton? openXmlElement)
  {
    return openXmlElement?.IdQ?.Value;
  }
  
  public static void SetIdQ(DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.IdQ = new StringValue { Value = value };
      else
        openXmlElement.IdQ = null;
  }
  
  /// <summary>
  /// idMso
  /// </summary>
  public static String? GetIdMso(DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton? openXmlElement)
  {
    return openXmlElement?.IdMso?.Value;
  }
  
  public static void SetIdMso(DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.IdMso = new StringValue { Value = value };
      else
        openXmlElement.IdMso = null;
  }
  
  /// <summary>
  /// tag
  /// </summary>
  public static String? GetTag(DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton? openXmlElement)
  {
    return openXmlElement?.Tag?.Value;
  }
  
  public static void SetTag(DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Tag = new StringValue { Value = value };
      else
        openXmlElement.Tag = null;
  }
  
  /// <summary>
  /// insertAfterMso
  /// </summary>
  public static String? GetInsertAfterMso(DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton? openXmlElement)
  {
    return openXmlElement?.InsertAfterMso?.Value;
  }
  
  public static void SetInsertAfterMso(DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton? openXmlElement, String? value)
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
  public static String? GetInsertBeforeMso(DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton? openXmlElement)
  {
    return openXmlElement?.InsertBeforeMso?.Value;
  }
  
  public static void SetInsertBeforeMso(DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton? openXmlElement, String? value)
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
  public static String? GetInsertAfterQ(DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton? openXmlElement)
  {
    return openXmlElement?.InsertAfterQ?.Value;
  }
  
  public static void SetInsertAfterQ(DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton? openXmlElement, String? value)
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
  public static String? GetInsertBeforeQ(DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton? openXmlElement)
  {
    return openXmlElement?.InsertBeforeQ?.Value;
  }
  
  public static void SetInsertBeforeQ(DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.InsertBeforeQ = new StringValue { Value = value };
      else
        openXmlElement.InsertBeforeQ = null;
  }
  
  /// <summary>
  /// visible
  /// </summary>
  public static Boolean? GetVisible(DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton? openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  public static void SetVisible(DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton? openXmlElement, Boolean? value)
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
  public static String? GetGetVisible(DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton? openXmlElement)
  {
    return openXmlElement?.GetVisible?.Value;
  }
  
  public static void SetGetVisible(DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetVisible = new StringValue { Value = value };
      else
        openXmlElement.GetVisible = null;
  }
  
  /// <summary>
  /// keytip
  /// </summary>
  public static String? GetKeytip(DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton? openXmlElement)
  {
    return openXmlElement?.Keytip?.Value;
  }
  
  public static void SetKeytip(DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Keytip = new StringValue { Value = value };
      else
        openXmlElement.Keytip = null;
  }
  
  /// <summary>
  /// getKeytip
  /// </summary>
  public static String? GetGetKeytip(DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton? openXmlElement)
  {
    return openXmlElement?.GetKeytip?.Value;
  }
  
  public static void SetGetKeytip(DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetKeytip = new StringValue { Value = value };
      else
        openXmlElement.GetKeytip = null;
  }
  
  /// <summary>
  /// showLabel
  /// </summary>
  public static Boolean? GetShowLabel(DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton? openXmlElement)
  {
    return openXmlElement?.ShowLabel?.Value;
  }
  
  public static void SetShowLabel(DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ShowLabel = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.ShowLabel = null;
  }
  
  /// <summary>
  /// getShowLabel
  /// </summary>
  public static String? GetGetShowLabel(DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton? openXmlElement)
  {
    return openXmlElement?.GetShowLabel?.Value;
  }
  
  public static void SetGetShowLabel(DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetShowLabel = new StringValue { Value = value };
      else
        openXmlElement.GetShowLabel = null;
  }
  
  public static DocumentModel.UI.VisibleButton? GetVisibleButton(DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.VisibleButton>();
    if (itemElement != null)
      return DocumentModel.OpenXml.UI.VisibleButtonConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetVisibleButton(DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton? openXmlElement, DocumentModel.UI.VisibleButton? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.VisibleButton>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.UI.VisibleButtonConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.VisibleButton>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.UI.VisibleToggleButton? GetVisibleToggleButton(DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.VisibleToggleButton>();
    if (itemElement != null)
      return DocumentModel.OpenXml.UI.VisibleToggleButtonConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetVisibleToggleButton(DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton? openXmlElement, DocumentModel.UI.VisibleToggleButton? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.VisibleToggleButton>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.UI.VisibleToggleButtonConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.VisibleToggleButton>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.UI.UnsizedMenu? GetUnsizedMenu(DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu>();
    if (itemElement != null)
      return DocumentModel.OpenXml.UI.UnsizedMenuConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetUnsizedMenu(DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton? openXmlElement, DocumentModel.UI.UnsizedMenu? value)
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
  
  public static DocumentModel.UI.UnsizedSplitButton? CreateModelElement(DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.UI.UnsizedSplitButton();
      value.Enabled = GetEnabled(openXmlElement);
      value.GetEnabled = GetGetEnabled(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.IdQ = GetIdQ(openXmlElement);
      value.IdMso = GetIdMso(openXmlElement);
      value.Tag = GetTag(openXmlElement);
      value.InsertAfterMso = GetInsertAfterMso(openXmlElement);
      value.InsertBeforeMso = GetInsertBeforeMso(openXmlElement);
      value.InsertAfterQ = GetInsertAfterQ(openXmlElement);
      value.InsertBeforeQ = GetInsertBeforeQ(openXmlElement);
      value.Visible = GetVisible(openXmlElement);
      value.GetVisible = GetGetVisible(openXmlElement);
      value.Keytip = GetKeytip(openXmlElement);
      value.GetKeytip = GetGetKeytip(openXmlElement);
      value.ShowLabel = GetShowLabel(openXmlElement);
      value.GetShowLabel = GetGetShowLabel(openXmlElement);
      value.VisibleButton = GetVisibleButton(openXmlElement);
      value.VisibleToggleButton = GetVisibleToggleButton(openXmlElement);
      value.UnsizedMenu = GetUnsizedMenu(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.UI.UnsizedSplitButton? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetEnabled(openXmlElement, value?.Enabled);
      SetGetEnabled(openXmlElement, value?.GetEnabled);
      SetId(openXmlElement, value?.Id);
      SetIdQ(openXmlElement, value?.IdQ);
      SetIdMso(openXmlElement, value?.IdMso);
      SetTag(openXmlElement, value?.Tag);
      SetInsertAfterMso(openXmlElement, value?.InsertAfterMso);
      SetInsertBeforeMso(openXmlElement, value?.InsertBeforeMso);
      SetInsertAfterQ(openXmlElement, value?.InsertAfterQ);
      SetInsertBeforeQ(openXmlElement, value?.InsertBeforeQ);
      SetVisible(openXmlElement, value?.Visible);
      SetGetVisible(openXmlElement, value?.GetVisible);
      SetKeytip(openXmlElement, value?.Keytip);
      SetGetKeytip(openXmlElement, value?.GetKeytip);
      SetShowLabel(openXmlElement, value?.ShowLabel);
      SetGetShowLabel(openXmlElement, value?.GetShowLabel);
      return openXmlElement;
    }
    return default;
  }
}
