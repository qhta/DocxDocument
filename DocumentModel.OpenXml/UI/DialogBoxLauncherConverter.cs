namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the DialogBoxLauncher Class.
/// </summary>
public static class DialogBoxLauncherConverter
{
  /// <summary>
  /// UnsizedButton.
  /// </summary>
  private static DocumentModel.UI.UnsizedButton? GetUnsizedButton(DocumentFormat.OpenXml.Office.CustomUI.DialogBoxLauncher openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton>();
    if (itemElement != null)
      return DocumentModel.OpenXml.UI.UnsizedButtonConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetUnsizedButton(DocumentFormat.OpenXml.Office.CustomUI.DialogBoxLauncher openXmlElement, DocumentModel.UI.UnsizedButton? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.UI.UnsizedButtonConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.UI.DialogBoxLauncher? CreateModelElement(DocumentFormat.OpenXml.Office.CustomUI.DialogBoxLauncher? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.UI.DialogBoxLauncher();
      value.UnsizedButton = GetUnsizedButton(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.UI.DialogBoxLauncher? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office.CustomUI.DialogBoxLauncher, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUnsizedButton(openXmlElement, value?.UnsizedButton);
      return openXmlElement;
    }
    return default;
  }
}
