namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the Group Class.
/// </summary>
public static class GroupConverter
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement, String? value)
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
  public static String? GetQualifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement)
  {
    return openXmlElement?.QualifiedId?.Value;
  }
  
  public static void SetQualifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement, String? value)
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
  public static String? GetTag(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement)
  {
    return openXmlElement?.Tag?.Value;
  }
  
  public static void SetTag(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Tag = new StringValue { Value = value };
      else
        openXmlElement.Tag = null;
  }
  
  /// <summary>
  /// idMso, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetIdMso(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement)
  {
    return openXmlElement?.IdMso?.Value;
  }
  
  public static void SetIdMso(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.IdMso = new StringValue { Value = value };
      else
        openXmlElement.IdMso = null;
  }
  
  /// <summary>
  /// label, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement)
  {
    return openXmlElement?.Label?.Value;
  }
  
  public static void SetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement, String? value)
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
  public static String? GetGetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement)
  {
    return openXmlElement?.GetLabel?.Value;
  }
  
  public static void SetGetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetLabel = new StringValue { Value = value };
      else
        openXmlElement.GetLabel = null;
  }
  
  /// <summary>
  /// image, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetImage(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement)
  {
    return openXmlElement?.Image?.Value;
  }
  
  public static void SetImage(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Image = new StringValue { Value = value };
      else
        openXmlElement.Image = null;
  }
  
  /// <summary>
  /// imageMso, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetImageMso(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement)
  {
    return openXmlElement?.ImageMso?.Value;
  }
  
  public static void SetImageMso(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ImageMso = new StringValue { Value = value };
      else
        openXmlElement.ImageMso = null;
  }
  
  /// <summary>
  /// getImage, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetImage(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement)
  {
    return openXmlElement?.GetImage?.Value;
  }
  
  public static void SetGetImage(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetImage = new StringValue { Value = value };
      else
        openXmlElement.GetImage = null;
  }
  
  /// <summary>
  /// insertAfterMso, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetInsertAfterMso(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement)
  {
    return openXmlElement?.InsertAfterMso?.Value;
  }
  
  public static void SetInsertAfterMso(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement, String? value)
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
  public static String? GetInsertBeforeMso(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement)
  {
    return openXmlElement?.InsertBeforeMso?.Value;
  }
  
  public static void SetInsertBeforeMso(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement, String? value)
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
  public static String? GetInsertAfterQulifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement)
  {
    return openXmlElement?.InsertAfterQulifiedId?.Value;
  }
  
  public static void SetInsertAfterQulifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement, String? value)
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
  public static String? GetInsertBeforeQulifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement)
  {
    return openXmlElement?.InsertBeforeQulifiedId?.Value;
  }
  
  public static void SetInsertBeforeQulifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.InsertBeforeQulifiedId = new StringValue { Value = value };
      else
        openXmlElement.InsertBeforeQulifiedId = null;
  }
  
  /// <summary>
  /// screentip, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetScreentip(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement)
  {
    return openXmlElement?.Screentip?.Value;
  }
  
  public static void SetScreentip(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Screentip = new StringValue { Value = value };
      else
        openXmlElement.Screentip = null;
  }
  
  /// <summary>
  /// getScreentip, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetScreentip(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement)
  {
    return openXmlElement?.GetScreentip?.Value;
  }
  
  public static void SetGetScreentip(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetScreentip = new StringValue { Value = value };
      else
        openXmlElement.GetScreentip = null;
  }
  
  /// <summary>
  /// supertip, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetSupertip(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement)
  {
    return openXmlElement?.Supertip?.Value;
  }
  
  public static void SetSupertip(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Supertip = new StringValue { Value = value };
      else
        openXmlElement.Supertip = null;
  }
  
  /// <summary>
  /// getSupertip, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetSupertip(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement)
  {
    return openXmlElement?.GetSupertip?.Value;
  }
  
  public static void SetGetSupertip(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetSupertip = new StringValue { Value = value };
      else
        openXmlElement.GetSupertip = null;
  }
  
  /// <summary>
  /// visible, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  public static void SetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement, Boolean? value)
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
  public static String? GetGetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement)
  {
    return openXmlElement?.GetVisible?.Value;
  }
  
  public static void SetGetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetVisible = new StringValue { Value = value };
      else
        openXmlElement.GetVisible = null;
  }
  
  /// <summary>
  /// keytip, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetKeytip(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement)
  {
    return openXmlElement?.Keytip?.Value;
  }
  
  public static void SetKeytip(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Keytip = new StringValue { Value = value };
      else
        openXmlElement.Keytip = null;
  }
  
  /// <summary>
  /// getKeytip, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetKeytip(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement)
  {
    return openXmlElement?.GetKeytip?.Value;
  }
  
  public static void SetGetKeytip(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetKeytip = new StringValue { Value = value };
      else
        openXmlElement.GetKeytip = null;
  }
  
  /// <summary>
  /// autoScale, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetAutoScale(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement)
  {
    return openXmlElement?.AutoScale?.Value;
  }
  
  public static void SetAutoScale(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AutoScale = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.AutoScale = null;
  }
  
  /// <summary>
  /// centerVertically, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetCenterVertically(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement)
  {
    return openXmlElement?.CenterVertically?.Value;
  }
  
  public static void SetCenterVertically(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.CenterVertically = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.CenterVertically = null;
  }
  
  public static DocumentModel.ControlClone? GetControlClone(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ControlClone>();
    if (itemElement != null)
      return DocumentModel.OpenXml.ControlCloneConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetControlClone(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement, DocumentModel.ControlClone? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ControlClone>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.ControlCloneConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.ControlClone>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.LabelControl? GetLabelControl(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.LabelControl>();
    if (itemElement != null)
      return DocumentModel.OpenXml.LabelControlConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLabelControl(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement, DocumentModel.LabelControl? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.LabelControl>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.LabelControlConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.LabelControl>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Button? GetButton(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Button>();
    if (itemElement != null)
      return DocumentModel.OpenXml.ButtonConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetButton(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement, DocumentModel.Button? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Button>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.ButtonConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.Button>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.ToggleButton? GetToggleButton(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ToggleButton>();
    if (itemElement != null)
      return DocumentModel.OpenXml.ToggleButtonConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetToggleButton(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement, DocumentModel.ToggleButton? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ToggleButton>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.ToggleButtonConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.ToggleButton>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.CheckBox? GetCheckBox(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.CheckBox>();
    if (itemElement != null)
      return DocumentModel.OpenXml.CheckBoxConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCheckBox(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement, DocumentModel.CheckBox? value)
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
  
  public static DocumentModel.EditBox? GetEditBox(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.EditBox>();
    if (itemElement != null)
      return DocumentModel.OpenXml.EditBoxConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetEditBox(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement, DocumentModel.EditBox? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.EditBox>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.EditBoxConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.EditBox>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.ComboBox? GetComboBox(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ComboBox>();
    if (itemElement != null)
      return DocumentModel.OpenXml.ComboBoxConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetComboBox(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement, DocumentModel.ComboBox? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ComboBox>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.ComboBoxConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.ComboBox>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.DropDownRegular? GetDropDownRegular(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular>();
    if (itemElement != null)
      return DocumentModel.OpenXml.DropDownRegularConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDropDownRegular(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement, DocumentModel.DropDownRegular? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.DropDownRegularConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Gallery? GetGallery(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Gallery>();
    if (itemElement != null)
      return DocumentModel.OpenXml.GalleryConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetGallery(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement, DocumentModel.Gallery? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Gallery>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.GalleryConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.Gallery>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Menu? GetMenu(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Menu>();
    if (itemElement != null)
      return DocumentModel.OpenXml.MenuConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetMenu(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement, DocumentModel.Menu? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Menu>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.MenuConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.Menu>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.DynamicMenu? GetDynamicMenu(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.DynamicMenu>();
    if (itemElement != null)
      return DocumentModel.OpenXml.DynamicMenuConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDynamicMenu(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement, DocumentModel.DynamicMenu? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.DynamicMenu>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.DynamicMenuConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.DynamicMenu>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.SplitButton? GetSplitButton(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.SplitButton>();
    if (itemElement != null)
      return DocumentModel.OpenXml.SplitButtonConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSplitButton(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement, DocumentModel.SplitButton? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.SplitButton>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.SplitButtonConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.SplitButton>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Box? GetBox(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Box>();
    if (itemElement != null)
      return DocumentModel.OpenXml.BoxConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBox(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement, DocumentModel.Box? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Box>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.BoxConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.Box>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.ButtonGroup? GetButtonGroup(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ButtonGroup>();
    if (itemElement != null)
      return DocumentModel.OpenXml.ButtonGroupConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetButtonGroup(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement, DocumentModel.ButtonGroup? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ButtonGroup>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.ButtonGroupConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.ButtonGroup>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Separator? GetSeparator(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Separator>();
    if (itemElement != null)
      return DocumentModel.OpenXml.SeparatorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSeparator(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement, DocumentModel.Separator? value)
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
  
  public static DocumentModel.DialogBoxLauncher? GetDialogBoxLauncher(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.DialogBoxLauncher>();
    if (itemElement != null)
      return DocumentModel.OpenXml.DialogBoxLauncherConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDialogBoxLauncher(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement, DocumentModel.DialogBoxLauncher? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.DialogBoxLauncher>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.DialogBoxLauncherConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.DialogBoxLauncher>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Group? CreateModelElement(DocumentFormat.OpenXml.Office2010.CustomUI.Group? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Group();
      value.Id = GetId(openXmlElement);
      value.QualifiedId = GetQualifiedId(openXmlElement);
      value.Tag = GetTag(openXmlElement);
      value.IdMso = GetIdMso(openXmlElement);
      value.Label = GetLabel(openXmlElement);
      value.GetLabel = GetGetLabel(openXmlElement);
      value.Image = GetImage(openXmlElement);
      value.ImageMso = GetImageMso(openXmlElement);
      value.GetImage = GetGetImage(openXmlElement);
      value.InsertAfterMso = GetInsertAfterMso(openXmlElement);
      value.InsertBeforeMso = GetInsertBeforeMso(openXmlElement);
      value.InsertAfterQulifiedId = GetInsertAfterQulifiedId(openXmlElement);
      value.InsertBeforeQulifiedId = GetInsertBeforeQulifiedId(openXmlElement);
      value.Screentip = GetScreentip(openXmlElement);
      value.GetScreentip = GetGetScreentip(openXmlElement);
      value.Supertip = GetSupertip(openXmlElement);
      value.GetSupertip = GetGetSupertip(openXmlElement);
      value.Visible = GetVisible(openXmlElement);
      value.GetVisible = GetGetVisible(openXmlElement);
      value.Keytip = GetKeytip(openXmlElement);
      value.GetKeytip = GetGetKeytip(openXmlElement);
      value.AutoScale = GetAutoScale(openXmlElement);
      value.CenterVertically = GetCenterVertically(openXmlElement);
      value.ControlClone = GetControlClone(openXmlElement);
      value.LabelControl = GetLabelControl(openXmlElement);
      value.Button = GetButton(openXmlElement);
      value.ToggleButton = GetToggleButton(openXmlElement);
      value.CheckBox = GetCheckBox(openXmlElement);
      value.EditBox = GetEditBox(openXmlElement);
      value.ComboBox = GetComboBox(openXmlElement);
      value.DropDownRegular = GetDropDownRegular(openXmlElement);
      value.Gallery = GetGallery(openXmlElement);
      value.Menu = GetMenu(openXmlElement);
      value.DynamicMenu = GetDynamicMenu(openXmlElement);
      value.SplitButton = GetSplitButton(openXmlElement);
      value.Box = GetBox(openXmlElement);
      value.ButtonGroup = GetButtonGroup(openXmlElement);
      value.Separator = GetSeparator(openXmlElement);
      value.DialogBoxLauncher = GetDialogBoxLauncher(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Group? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.CustomUI.Group, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetQualifiedId(openXmlElement, value?.QualifiedId);
      SetTag(openXmlElement, value?.Tag);
      SetIdMso(openXmlElement, value?.IdMso);
      SetLabel(openXmlElement, value?.Label);
      SetGetLabel(openXmlElement, value?.GetLabel);
      SetImage(openXmlElement, value?.Image);
      SetImageMso(openXmlElement, value?.ImageMso);
      SetGetImage(openXmlElement, value?.GetImage);
      SetInsertAfterMso(openXmlElement, value?.InsertAfterMso);
      SetInsertBeforeMso(openXmlElement, value?.InsertBeforeMso);
      SetInsertAfterQulifiedId(openXmlElement, value?.InsertAfterQulifiedId);
      SetInsertBeforeQulifiedId(openXmlElement, value?.InsertBeforeQulifiedId);
      SetScreentip(openXmlElement, value?.Screentip);
      SetGetScreentip(openXmlElement, value?.GetScreentip);
      SetSupertip(openXmlElement, value?.Supertip);
      SetGetSupertip(openXmlElement, value?.GetSupertip);
      SetVisible(openXmlElement, value?.Visible);
      SetGetVisible(openXmlElement, value?.GetVisible);
      SetKeytip(openXmlElement, value?.Keytip);
      SetGetKeytip(openXmlElement, value?.GetKeytip);
      SetAutoScale(openXmlElement, value?.AutoScale);
      SetCenterVertically(openXmlElement, value?.CenterVertically);
      SetControlClone(openXmlElement, value?.ControlClone);
      SetLabelControl(openXmlElement, value?.LabelControl);
      SetButton(openXmlElement, value?.Button);
      SetToggleButton(openXmlElement, value?.ToggleButton);
      SetCheckBox(openXmlElement, value?.CheckBox);
      SetEditBox(openXmlElement, value?.EditBox);
      SetComboBox(openXmlElement, value?.ComboBox);
      SetDropDownRegular(openXmlElement, value?.DropDownRegular);
      SetGallery(openXmlElement, value?.Gallery);
      SetMenu(openXmlElement, value?.Menu);
      SetDynamicMenu(openXmlElement, value?.DynamicMenu);
      SetSplitButton(openXmlElement, value?.SplitButton);
      SetBox(openXmlElement, value?.Box);
      SetButtonGroup(openXmlElement, value?.ButtonGroup);
      SetSeparator(openXmlElement, value?.Separator);
      SetDialogBoxLauncher(openXmlElement, value?.DialogBoxLauncher);
      return openXmlElement;
    }
    return default;
  }
}
