namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the DialogBoxLauncher Class.
/// </summary>
public static class DialogBoxLauncherConverter
{
  /// <summary>
  /// UnsizedButton.
  /// </summary>
  private static DMUI.UnsizedButton? GetUnsizedButton(DXOCUI.DialogBoxLauncher openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCUI.UnsizedButton>();
    if (element != null)
      return DMXUI.UnsizedButtonConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpUnsizedButton(DXOCUI.DialogBoxLauncher openXmlElement, DMUI.UnsizedButton? value, DiffList? diffs, string? objName)
  {
    return DMXUI.UnsizedButtonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCUI.UnsizedButton>(), value, diffs, objName);
  }
  
  private static void SetUnsizedButton(DXOCUI.DialogBoxLauncher openXmlElement, DMUI.UnsizedButton? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCUI.UnsizedButton>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.UnsizedButtonConverter.CreateOpenXmlElement<DXOCUI.UnsizedButton>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.UI.DialogBoxLauncher? CreateModelElement(DXOCUI.DialogBoxLauncher? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.UI.DialogBoxLauncher();
      value.UnsizedButton = GetUnsizedButton(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXOCUI.DialogBoxLauncher? openXmlElement, DMUI.DialogBoxLauncher? value, DiffList? diffs, string? objName)
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
    where OpenXmlElementType: DXOCUI.DialogBoxLauncher, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXOCUI.DialogBoxLauncher openXmlElement, DMUI.DialogBoxLauncher value)
  {
    SetUnsizedButton(openXmlElement, value?.UnsizedButton);
  }
}
