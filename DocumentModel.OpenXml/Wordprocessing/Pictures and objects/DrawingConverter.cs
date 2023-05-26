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
  
  private static bool CmpAnchor(DXW.Drawing openXmlElement, DMDW.Anchor? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDW.AnchorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDW.Anchor>(), value, diffs, objName, propName);
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
        openXmlElement.AppendChild(itemElement);
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
  
  private static bool CmpInline(DXW.Drawing openXmlElement, DMDW.Inline? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDW.InlineConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDW.Inline>(), value, diffs, objName, propName);
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
        openXmlElement.AppendChild(itemElement);
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
  
  public static bool CompareModelElement(DXW.Drawing? openXmlElement, DMW.Drawing? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAnchor(openXmlElement, value.Anchor, diffs, objName, propName))
        ok = false;
      if (!CmpInline(openXmlElement, value.Inline, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
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
