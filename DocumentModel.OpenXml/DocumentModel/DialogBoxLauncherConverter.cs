namespace DocumentModel.OpenXml;

/// <summary>
///   Defines the DialogBoxLauncher Class.
/// </summary>
public static class DialogBoxLauncherConverter
{
  /// <summary>
  ///   ButtonRegular.
  /// </summary>
  public static ButtonRegular? GetButtonRegular(DocumentFormat.OpenXml.Office2010.CustomUI.DialogBoxLauncher? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular>();
    if (itemElement != null)
      return ButtonRegularConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetButtonRegular(DocumentFormat.OpenXml.Office2010.CustomUI.DialogBoxLauncher? openXmlElement, ButtonRegular? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ButtonRegularConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DialogBoxLauncher? CreateModelElement(DocumentFormat.OpenXml.Office2010.CustomUI.DialogBoxLauncher? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DialogBoxLauncher();
      value.ButtonRegular = GetButtonRegular(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DialogBoxLauncher? value)
    where OpenXmlElementType : DocumentFormat.OpenXml.Office2010.CustomUI.DialogBoxLauncher, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetButtonRegular(openXmlElement, value?.ButtonRegular);
      return openXmlElement;
    }
    return default;
  }
}