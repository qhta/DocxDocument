namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// DrawingML Object.
/// </summary>
public static class DrawingConverter
{
  /// <summary>
  /// Drawing Element Anchor.
  /// </summary>
  private static DMDW.Anchor? GetAnchor(DXW.Drawing openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDW.Anchor>();
    if (element != null)
      return DMXDW.AnchorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAnchor(DXW.Drawing openXmlElement, DMDW.Anchor? value, DiffList? diffs, string? objName)
  {
    return DMXDW.AnchorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDW.Anchor>(), value, diffs, objName);
  }
  
  private static void SetAnchor(DXW.Drawing openXmlElement, DMDW.Anchor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDW.Anchor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDW.AnchorConverter.CreateOpenXmlElement<DXDW.Anchor>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Inline Drawing Object.
  /// </summary>
  private static DMDW.Inline? GetInline(DXW.Drawing openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDW.Inline>();
    if (element != null)
      return DMXDW.InlineConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpInline(DXW.Drawing openXmlElement, DMDW.Inline? value, DiffList? diffs, string? objName)
  {
    return DMXDW.InlineConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDW.Inline>(), value, diffs, objName);
  }
  
  private static void SetInline(DXW.Drawing openXmlElement, DMDW.Inline? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDW.Inline>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDW.InlineConverter.CreateOpenXmlElement<DXDW.Inline>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.Drawing? CreateModelElement(DXW.Drawing? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Drawing();
      value.Anchor = GetAnchor(openXmlElement);
      value.Inline = GetInline(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.Drawing? openXmlElement, DMW.Drawing? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAnchor(openXmlElement, value.Anchor, diffs, objName))
        ok = false;
      if (!CmpInline(openXmlElement, value.Inline, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static DXW.Drawing CreateOpenXmlElement(DMW.Drawing value)
  {
    var openXmlElement = new DXW.Drawing();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXW.Drawing openXmlElement, DMW.Drawing value)
  {
    SetAnchor(openXmlElement, value?.Anchor);
    SetInline(openXmlElement, value?.Inline);
    return true;
  }
}
