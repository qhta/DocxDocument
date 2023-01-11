namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the TaskGroupTask Class.
/// </summary>
public static class TaskGroupTaskConverter
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupTask? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupTask? openXmlElement, String? value)
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
  public static String? GetQualifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupTask? openXmlElement)
  {
    return openXmlElement?.QualifiedId?.Value;
  }
  
  public static void SetQualifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupTask? openXmlElement, String? value)
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
  public static String? GetTag(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupTask? openXmlElement)
  {
    return openXmlElement?.Tag?.Value;
  }
  
  public static void SetTag(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupTask? openXmlElement, String? value)
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
  public static String? GetIdMso(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupTask? openXmlElement)
  {
    return openXmlElement?.IdMso?.Value;
  }
  
  public static void SetIdMso(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupTask? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.IdMso = new StringValue { Value = value };
      else
        openXmlElement.IdMso = null;
  }
  
  /// <summary>
  /// insertAfterMso, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetInsertAfterMso(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupTask? openXmlElement)
  {
    return openXmlElement?.InsertAfterMso?.Value;
  }
  
  public static void SetInsertAfterMso(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupTask? openXmlElement, String? value)
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
  public static String? GetInsertBeforeMso(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupTask? openXmlElement)
  {
    return openXmlElement?.InsertBeforeMso?.Value;
  }
  
  public static void SetInsertBeforeMso(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupTask? openXmlElement, String? value)
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
  public static String? GetInsertAfterQulifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupTask? openXmlElement)
  {
    return openXmlElement?.InsertAfterQulifiedId?.Value;
  }
  
  public static void SetInsertAfterQulifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupTask? openXmlElement, String? value)
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
  public static String? GetInsertBeforeQulifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupTask? openXmlElement)
  {
    return openXmlElement?.InsertBeforeQulifiedId?.Value;
  }
  
  public static void SetInsertBeforeQulifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupTask? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.InsertBeforeQulifiedId = new StringValue { Value = value };
      else
        openXmlElement.InsertBeforeQulifiedId = null;
  }
  
  /// <summary>
  /// onAction, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetOnAction(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupTask? openXmlElement)
  {
    return openXmlElement?.OnAction?.Value;
  }
  
  public static void SetOnAction(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupTask? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.OnAction = new StringValue { Value = value };
      else
        openXmlElement.OnAction = null;
  }
  
  /// <summary>
  /// isDefinitive, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetIsDefinitive(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupTask? openXmlElement)
  {
    return openXmlElement?.IsDefinitive?.Value;
  }
  
  public static void SetIsDefinitive(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupTask? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.IsDefinitive = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.IsDefinitive = null;
  }
  
  /// <summary>
  /// image, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetImage(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupTask? openXmlElement)
  {
    return openXmlElement?.Image?.Value;
  }
  
  public static void SetImage(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupTask? openXmlElement, String? value)
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
  public static String? GetImageMso(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupTask? openXmlElement)
  {
    return openXmlElement?.ImageMso?.Value;
  }
  
  public static void SetImageMso(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupTask? openXmlElement, String? value)
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
  public static String? GetGetImage(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupTask? openXmlElement)
  {
    return openXmlElement?.GetImage?.Value;
  }
  
  public static void SetGetImage(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupTask? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetImage = new StringValue { Value = value };
      else
        openXmlElement.GetImage = null;
  }
  
  /// <summary>
  /// enabled, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetEnabled(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupTask? openXmlElement)
  {
    return openXmlElement?.Enabled?.Value;
  }
  
  public static void SetEnabled(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupTask? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Enabled = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Enabled = null;
  }
  
  /// <summary>
  /// getEnabled, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetEnabled(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupTask? openXmlElement)
  {
    return openXmlElement?.GetEnabled?.Value;
  }
  
  public static void SetGetEnabled(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupTask? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetEnabled = new StringValue { Value = value };
      else
        openXmlElement.GetEnabled = null;
  }
  
  /// <summary>
  /// label, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupTask? openXmlElement)
  {
    return openXmlElement?.Label?.Value;
  }
  
  public static void SetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupTask? openXmlElement, String? value)
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
  public static String? GetGetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupTask? openXmlElement)
  {
    return openXmlElement?.GetLabel?.Value;
  }
  
  public static void SetGetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupTask? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetLabel = new StringValue { Value = value };
      else
        openXmlElement.GetLabel = null;
  }
  
  /// <summary>
  /// visible, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupTask? openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  public static void SetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupTask? openXmlElement, Boolean? value)
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
  public static String? GetGetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupTask? openXmlElement)
  {
    return openXmlElement?.GetVisible?.Value;
  }
  
  public static void SetGetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupTask? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetVisible = new StringValue { Value = value };
      else
        openXmlElement.GetVisible = null;
  }
  
  /// <summary>
  /// description, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetDescription(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupTask? openXmlElement)
  {
    return openXmlElement?.Description?.Value;
  }
  
  public static void SetDescription(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupTask? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Description = new StringValue { Value = value };
      else
        openXmlElement.Description = null;
  }
  
  /// <summary>
  /// getDescription, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetDescription(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupTask? openXmlElement)
  {
    return openXmlElement?.GetDescription?.Value;
  }
  
  public static void SetGetDescription(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupTask? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetDescription = new StringValue { Value = value };
      else
        openXmlElement.GetDescription = null;
  }
  
  /// <summary>
  /// keytip, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetKeytip(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupTask? openXmlElement)
  {
    return openXmlElement?.Keytip?.Value;
  }
  
  public static void SetKeytip(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupTask? openXmlElement, String? value)
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
  public static String? GetGetKeytip(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupTask? openXmlElement)
  {
    return openXmlElement?.GetKeytip?.Value;
  }
  
  public static void SetGetKeytip(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupTask? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetKeytip = new StringValue { Value = value };
      else
        openXmlElement.GetKeytip = null;
  }
  
  public static DocumentModel.TaskGroupTask? CreateModelElement(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupTask? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.TaskGroupTask();
      value.Id = GetId(openXmlElement);
      value.QualifiedId = GetQualifiedId(openXmlElement);
      value.Tag = GetTag(openXmlElement);
      value.IdMso = GetIdMso(openXmlElement);
      value.InsertAfterMso = GetInsertAfterMso(openXmlElement);
      value.InsertBeforeMso = GetInsertBeforeMso(openXmlElement);
      value.InsertAfterQulifiedId = GetInsertAfterQulifiedId(openXmlElement);
      value.InsertBeforeQulifiedId = GetInsertBeforeQulifiedId(openXmlElement);
      value.OnAction = GetOnAction(openXmlElement);
      value.IsDefinitive = GetIsDefinitive(openXmlElement);
      value.Image = GetImage(openXmlElement);
      value.ImageMso = GetImageMso(openXmlElement);
      value.GetImage = GetGetImage(openXmlElement);
      value.Enabled = GetEnabled(openXmlElement);
      value.GetEnabled = GetGetEnabled(openXmlElement);
      value.Label = GetLabel(openXmlElement);
      value.GetLabel = GetGetLabel(openXmlElement);
      value.Visible = GetVisible(openXmlElement);
      value.GetVisible = GetGetVisible(openXmlElement);
      value.Description = GetDescription(openXmlElement);
      value.GetDescription = GetGetDescription(openXmlElement);
      value.Keytip = GetKeytip(openXmlElement);
      value.GetKeytip = GetGetKeytip(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.TaskGroupTask? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupTask, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
