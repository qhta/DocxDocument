namespace DocumentModel.OpenXml.Drawings.Diagram1;

/// <summary>
/// Defines the NumberDiagramInfo Class.
/// </summary>
public static class NumberDiagramInfoConverter
{
  /// <summary>
  /// lvl, this property is only available in Office 2019 and later.
  /// </summary>
  private static UInt32? GetLvl(DXO19DD11.NumberDiagramInfo openXmlElement)
  {
    return openXmlElement?.Lvl?.Value;
  }
  
  private static bool CmpLvl(DXO19DD11.NumberDiagramInfo openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Lvl?.Value == value) return true;
    diffs?.Add(objName, "Lvl", openXmlElement?.Lvl?.Value, value);
    return false;
  }
  
  private static void SetLvl(DXO19DD11.NumberDiagramInfo openXmlElement, UInt32? value)
  {
    openXmlElement.Lvl = value;
  }
  
  /// <summary>
  /// ptType, this property is only available in Office 2019 and later.
  /// </summary>
  private static DMDD1.STorageType? GetPtType(DXO19DD11.NumberDiagramInfo openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.STorageType, DMDD1.STorageType>(openXmlElement?.PtType?.Value);
  }
  
  private static bool CmpPtType(DXO19DD11.NumberDiagramInfo openXmlElement, DMDD1.STorageType? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.STorageType, DMDD1.STorageType>(openXmlElement?.PtType?.Value, value, diffs, objName);
  }
  
  private static void SetPtType(DXO19DD11.NumberDiagramInfo openXmlElement, DMDD1.STorageType? value)
  {
    openXmlElement.PtType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.STorageType, DMDD1.STorageType>(value);
  }
  
  /// <summary>
  /// DiagramAutoBullet.
  /// </summary>
  private static DMDD1.DiagramAutoBullet? GetDiagramAutoBullet(DXO19DD11.NumberDiagramInfo openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO19DD11.DiagramAutoBullet>();
    if (element != null)
      return DMXDD1.DiagramAutoBulletConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDiagramAutoBullet(DXO19DD11.NumberDiagramInfo openXmlElement, DMDD1.DiagramAutoBullet? value, DiffList? diffs, string? objName)
  {
    return DMXDD1.DiagramAutoBulletConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO19DD11.DiagramAutoBullet>(), value, diffs, objName);
  }
  
  private static void SetDiagramAutoBullet(DXO19DD11.NumberDiagramInfo openXmlElement, DMDD1.DiagramAutoBullet? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO19DD11.DiagramAutoBullet>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD1.DiagramAutoBulletConverter.CreateOpenXmlElement<DXO19DD11.DiagramAutoBullet>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Diagram1.NumberDiagramInfo? CreateModelElement(DXO19DD11.NumberDiagramInfo? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagram1.NumberDiagramInfo();
      value.Lvl = GetLvl(openXmlElement);
      value.PtType = GetPtType(openXmlElement);
      value.DiagramAutoBullet = GetDiagramAutoBullet(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO19DD11.NumberDiagramInfo? openXmlElement, DMDD1.NumberDiagramInfo? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLvl(openXmlElement, value.Lvl, diffs, objName))
        ok = false;
      if (!CmpPtType(openXmlElement, value.PtType, diffs, objName))
        ok = false;
      if (!CmpDiagramAutoBullet(openXmlElement, value.DiagramAutoBullet, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDD1.NumberDiagramInfo value)
    where OpenXmlElementType: DXO19DD11.NumberDiagramInfo, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO19DD11.NumberDiagramInfo openXmlElement, DMDD1.NumberDiagramInfo value)
  {
    SetLvl(openXmlElement, value?.Lvl);
    SetPtType(openXmlElement, value?.PtType);
    SetDiagramAutoBullet(openXmlElement, value?.DiagramAutoBullet);
  }
}
