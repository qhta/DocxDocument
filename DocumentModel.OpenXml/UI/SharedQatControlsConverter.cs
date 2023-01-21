namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the SharedQatControls Class.
/// </summary>
public static class SharedQatControlsConverter
{
  private static DMUI.QuickAccessToolbarControlClone? GetQuickAccessToolbarControlClone(DXOCustUI.SharedQatControls openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXOCustUI.QuickAccessToolbarControlClone>();
    if (itemElement != null)
      return DMXUI.QuickAccessToolbarControlCloneConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetQuickAccessToolbarControlClone(DXOCustUI.SharedQatControls openXmlElement, DMUI.QuickAccessToolbarControlClone? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCustUI.QuickAccessToolbarControlClone>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.QuickAccessToolbarControlCloneConverter.CreateOpenXmlElement<DXOCustUI.QuickAccessToolbarControlClone>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMUI.UnsizedButton? GetUnsizedButton(DXOCustUI.SharedQatControls openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXOCustUI.UnsizedButton>();
    if (itemElement != null)
      return DMXUI.UnsizedButtonConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetUnsizedButton(DXOCustUI.SharedQatControls openXmlElement, DMUI.UnsizedButton? value)
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
  
  private static DMUI.VerticalSeparator? GetVerticalSeparator(DXOCustUI.SharedQatControls openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXOCustUI.VerticalSeparator>();
    if (itemElement != null)
      return DMXUI.VerticalSeparatorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetVerticalSeparator(DXOCustUI.SharedQatControls openXmlElement, DMUI.VerticalSeparator? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCustUI.VerticalSeparator>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.VerticalSeparatorConverter.CreateOpenXmlElement<DXOCustUI.VerticalSeparator>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMUI.SharedQatControls? CreateModelElement(DXOCustUI.SharedQatControls? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMUI.SharedQatControls();
      value.QuickAccessToolbarControlClone = GetQuickAccessToolbarControlClone(openXmlElement);
      value.UnsizedButton = GetUnsizedButton(openXmlElement);
      value.VerticalSeparator = GetVerticalSeparator(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMUI.SharedQatControls? value)
    where OpenXmlElementType: DXOCustUI.SharedQatControls, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetQuickAccessToolbarControlClone(openXmlElement, value?.QuickAccessToolbarControlClone);
      SetUnsizedButton(openXmlElement, value?.UnsizedButton);
      SetVerticalSeparator(openXmlElement, value?.VerticalSeparator);
      return openXmlElement;
    }
    return default;
  }
}
