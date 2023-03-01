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
    var element = openXmlElement?.GetFirstChild<DXOCustUI.UnsizedButton>();
    if (element != null)
      return DMXUI.UnsizedButtonConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpUnsizedButton(DXOCustUI.DialogBoxLauncher openXmlElement, DMUI.UnsizedButton? value, DiffList? diffs, string? objName)
  {
    return DMXUI.UnsizedButtonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.UnsizedButton>(), value, diffs, objName);
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
  
  public static DocumentModel.UI.DialogBoxLauncher? CreateModelElement(DXOCustUI.DialogBoxLauncher? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.UI.DialogBoxLauncher();
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
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMUI.DialogBoxLauncher value)
    where OpenXmlElementType: DXOCustUI.DialogBoxLauncher, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXOCustUI.DialogBoxLauncher openXmlElement, DMUI.DialogBoxLauncher value)
  {
    SetUnsizedButton(openXmlElement, value?.UnsizedButton);
  }
}
