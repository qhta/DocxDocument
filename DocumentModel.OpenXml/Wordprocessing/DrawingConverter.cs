namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// DrawingML Object converter from/to OpenXml.
///</summary>
public static class DrawingConverter
{
  /// <summary>
  /// Drawing Element Anchor.
  /// </summary>
  private static DMDrawsW.Anchor? GetAnchor(DXW.Drawing openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawW.Anchor>();
    if (element != null)
      return DMXDrawsW.AnchorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAnchor(DXW.Drawing openXmlElement, DMDrawsW.Anchor? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsW.AnchorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawW.Anchor>(), value, diffs, objName);
  }
  
  private static void SetAnchor(DXW.Drawing openXmlElement, DMDrawsW.Anchor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawW.Anchor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsW.AnchorConverter.CreateOpenXmlElement<DXDrawW.Anchor>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Inline Drawing Object.
  /// </summary>
  private static DMDrawsW.Inline? GetInline(DXW.Drawing openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawW.Inline>();
    if (element != null)
      return DMXDrawsW.InlineConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpInline(DXW.Drawing openXmlElement, DMDrawsW.Inline? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsW.InlineConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawW.Inline>(), value, diffs, objName);
  }
  
  private static void SetInline(DXW.Drawing openXmlElement, DMDrawsW.Inline? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawW.Inline>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsW.InlineConverter.CreateOpenXmlElement<DXDrawW.Inline>(value);
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
