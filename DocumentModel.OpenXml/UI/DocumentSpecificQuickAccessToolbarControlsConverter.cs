namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the DocumentSpecificQuickAccessToolbarControls Class.
/// </summary>
public static class DocumentSpecificQuickAccessToolbarControlsConverter
{
  private static DMUI.QuickAccessToolbarControlClone? GetQuickAccessToolbarControlClone(DXOCustUI.DocumentSpecificQuickAccessToolbarControls openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXOCustUI.QuickAccessToolbarControlClone>();
    if (itemElement != null)
      return DMXUI.QuickAccessToolbarControlCloneConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetQuickAccessToolbarControlClone(DXOCustUI.DocumentSpecificQuickAccessToolbarControls openXmlElement, DMUI.QuickAccessToolbarControlClone? value)
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
  
  private static DMUI.UnsizedButton? GetUnsizedButton(DXOCustUI.DocumentSpecificQuickAccessToolbarControls openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXOCustUI.UnsizedButton>();
    if (itemElement != null)
      return DMXUI.UnsizedButtonConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetUnsizedButton(DXOCustUI.DocumentSpecificQuickAccessToolbarControls openXmlElement, DMUI.UnsizedButton? value)
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
  
  private static DMUI.VerticalSeparator? GetVerticalSeparator(DXOCustUI.DocumentSpecificQuickAccessToolbarControls openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXOCustUI.VerticalSeparator>();
    if (itemElement != null)
      return DMXUI.VerticalSeparatorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetVerticalSeparator(DXOCustUI.DocumentSpecificQuickAccessToolbarControls openXmlElement, DMUI.VerticalSeparator? value)
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
  
  public static DMUI.DocumentSpecificQuickAccessToolbarControls? CreateModelElement(DXOCustUI.DocumentSpecificQuickAccessToolbarControls? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMUI.DocumentSpecificQuickAccessToolbarControls();
      value.QuickAccessToolbarControlClone = GetQuickAccessToolbarControlClone(openXmlElement);
      value.UnsizedButton = GetUnsizedButton(openXmlElement);
      value.VerticalSeparator = GetVerticalSeparator(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMUI.DocumentSpecificQuickAccessToolbarControls? value)
    where OpenXmlElementType: DXOCustUI.DocumentSpecificQuickAccessToolbarControls, new()
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
