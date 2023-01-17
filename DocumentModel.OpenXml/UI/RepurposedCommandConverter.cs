namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the RepurposedCommand Class.
/// </summary>
public static class RepurposedCommandConverter
{
  /// <summary>
  /// onAction
  /// </summary>
  private static String? GetOnAction(DocumentFormat.OpenXml.Office.CustomUI.RepurposedCommand openXmlElement)
  {
    return openXmlElement?.OnAction?.Value;
  }
  
  private static void SetOnAction(DocumentFormat.OpenXml.Office.CustomUI.RepurposedCommand openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.OnAction = new StringValue { Value = value };
    else
      openXmlElement.OnAction = null;
  }
  
  /// <summary>
  /// enabled
  /// </summary>
  private static Boolean? GetEnabled(DocumentFormat.OpenXml.Office.CustomUI.RepurposedCommand openXmlElement)
  {
    return openXmlElement?.Enabled?.Value;
  }
  
  private static void SetEnabled(DocumentFormat.OpenXml.Office.CustomUI.RepurposedCommand openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Enabled = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Enabled = null;
  }
  
  /// <summary>
  /// getEnabled
  /// </summary>
  private static String? GetGetEnabled(DocumentFormat.OpenXml.Office.CustomUI.RepurposedCommand openXmlElement)
  {
    return openXmlElement?.GetEnabled?.Value;
  }
  
  private static void SetGetEnabled(DocumentFormat.OpenXml.Office.CustomUI.RepurposedCommand openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetEnabled = new StringValue { Value = value };
    else
      openXmlElement.GetEnabled = null;
  }
  
  /// <summary>
  /// idMso
  /// </summary>
  private static String? GetIdMso(DocumentFormat.OpenXml.Office.CustomUI.RepurposedCommand openXmlElement)
  {
    return openXmlElement?.IdMso?.Value;
  }
  
  private static void SetIdMso(DocumentFormat.OpenXml.Office.CustomUI.RepurposedCommand openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.IdMso = new StringValue { Value = value };
    else
      openXmlElement.IdMso = null;
  }
  
  public static DocumentModel.UI.RepurposedCommand? CreateModelElement(DocumentFormat.OpenXml.Office.CustomUI.RepurposedCommand? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.UI.RepurposedCommand();
      value.OnAction = GetOnAction(openXmlElement);
      value.Enabled = GetEnabled(openXmlElement);
      value.GetEnabled = GetGetEnabled(openXmlElement);
      value.IdMso = GetIdMso(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.UI.RepurposedCommand? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office.CustomUI.RepurposedCommand, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetOnAction(openXmlElement, value?.OnAction);
      SetEnabled(openXmlElement, value?.Enabled);
      SetGetEnabled(openXmlElement, value?.GetEnabled);
      SetIdMso(openXmlElement, value?.IdMso);
      return openXmlElement;
    }
    return default;
  }
}
