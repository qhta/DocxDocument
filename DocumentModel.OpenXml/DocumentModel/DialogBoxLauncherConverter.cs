namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the DialogBoxLauncher Class.
/// </summary>
public static class DialogBoxLauncherConverter
{
  /// <summary>
  /// ButtonRegular.
  /// </summary>
  private static DM.ButtonRegular? GetButtonRegular(DXO2010CustUI.DialogBoxLauncher openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.ButtonRegular>();
    if (itemElement != null)
      return DMX.ButtonRegularConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetButtonRegular(DXO2010CustUI.DialogBoxLauncher openXmlElement, DM.ButtonRegular? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.ButtonRegular>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.ButtonRegularConverter.CreateOpenXmlElement<DXO2010CustUI.ButtonRegular>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DM.DialogBoxLauncher? CreateModelElement(DXO2010CustUI.DialogBoxLauncher? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DM.DialogBoxLauncher();
      value.ButtonRegular = GetButtonRegular(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DM.DialogBoxLauncher? value)
    where OpenXmlElementType: DXO2010CustUI.DialogBoxLauncher, new()
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
