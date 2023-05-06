namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the DialogBoxLauncher Class.
/// </summary>
public static class DialogBoxLauncherConverter
{
  /// <summary>
  /// ButtonRegular.
  /// </summary>
  private static DM.ButtonRegular? GetButtonRegular(DXO10CUI.DialogBoxLauncher openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.ButtonRegular>();
    if (element != null)
      return DMX.ButtonRegularConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpButtonRegular(DXO10CUI.DialogBoxLauncher openXmlElement, DM.ButtonRegular? value, DiffList? diffs, string? objName)
  {
    return DMX.ButtonRegularConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.ButtonRegular>(), value, diffs, objName);
  }
  
  private static void SetButtonRegular(DXO10CUI.DialogBoxLauncher openXmlElement, DM.ButtonRegular? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.ButtonRegular>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.ButtonRegularConverter.CreateOpenXmlElement<DXO10CUI.ButtonRegular>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.DialogBoxLauncher? CreateModelElement(DXO10CUI.DialogBoxLauncher? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.DialogBoxLauncher();
      value.ButtonRegular = GetButtonRegular(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO10CUI.DialogBoxLauncher? openXmlElement, DM.DialogBoxLauncher? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpButtonRegular(openXmlElement, value.ButtonRegular, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DM.DialogBoxLauncher value)
    where OpenXmlElementType: DXO10CUI.DialogBoxLauncher, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10CUI.DialogBoxLauncher openXmlElement, DM.DialogBoxLauncher value)
  {
    SetButtonRegular(openXmlElement, value?.ButtonRegular);
  }
}
