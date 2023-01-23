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
    return DMXUI.UnsizedButtonConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXOCustUI.UnsizedButton>());
  }
  
  private static bool CmpUnsizedButton(DXOCustUI.DialogBoxLauncher openXmlElement, DMUI.UnsizedButton? value, DiffList? diffs, string? objName)
  {
    return DMXUI.UnsizedButtonConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXOCustUI.UnsizedButton>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static bool CompareModelElement(DXOCustUI.DialogBoxLauncher? openXmlElement, DMUI.DialogBoxLauncher? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUnsizedButton(openXmlElement, value.UnsizedButton, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
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
