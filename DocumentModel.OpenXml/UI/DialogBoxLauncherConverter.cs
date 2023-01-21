namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the DialogBoxLauncher Class.
/// </summary>
public static class DialogBoxLauncherConverter
{
  /// <summary>
  /// UnsizedButton.
  /// </summary>
  private static DMUI.UnsizedButton? GetUnsizedButton(DXOCustUI.DialogBoxLauncher openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXOCustUI.UnsizedButton>();
    if (itemElement != null)
      return DMXUI.UnsizedButtonConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetUnsizedButton(DXOCustUI.DialogBoxLauncher openXmlElement, DMUI.UnsizedButton? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCustUI.UnsizedButton>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.UnsizedButtonConverter.CreateOpenXmlElement<DXOCustUI.UnsizedButton>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMUI.DialogBoxLauncher? CreateModelElement(DXOCustUI.DialogBoxLauncher? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMUI.DialogBoxLauncher();
      value.UnsizedButton = GetUnsizedButton(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMUI.DialogBoxLauncher? value)
    where OpenXmlElementType: DXOCustUI.DialogBoxLauncher, new()
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
