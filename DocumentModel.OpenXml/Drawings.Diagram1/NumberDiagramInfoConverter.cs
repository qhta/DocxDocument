namespace DocumentModel.OpenXml.Drawings.Diagram1;

/// <summary>
/// Defines the NumberDiagramInfo Class.
/// </summary>
public static class NumberDiagramInfoConverter
{
  /// <summary>
  /// lvl, this property is only available in Office 2019 and later.
  /// </summary>
  private static UInt32? GetLvl(DXO2019DrawDgm11.NumberDiagramInfo openXmlElement)
  {
    return openXmlElement?.Lvl?.Value;
  }
  
  private static bool CmpLvl(DXO2019DrawDgm11.NumberDiagramInfo openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Lvl?.Value == value) return true;
    diffs?.Add(objName, "Lvl", openXmlElement?.Lvl?.Value, value);
    return false;
  }
  
  private static void SetLvl(DXO2019DrawDgm11.NumberDiagramInfo openXmlElement, UInt32? value)
  {
    openXmlElement.Lvl = value;
  }
  
  /// <summary>
  /// ptType, this property is only available in Office 2019 and later.
  /// </summary>
  private static DMDrawsDgm1.STorageType? GetPtType(DXO2019DrawDgm11.NumberDiagramInfo openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.STorageType, DMDrawsDgm1.STorageType>(openXmlElement?.PtType?.Value);
  }
  
  private static bool CmpPtType(DXO2019DrawDgm11.NumberDiagramInfo openXmlElement, DMDrawsDgm1.STorageType? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.STorageType, DMDrawsDgm1.STorageType>(openXmlElement?.PtType?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPtType(DXO2019DrawDgm11.NumberDiagramInfo openXmlElement, DMDrawsDgm1.STorageType? value)
  {
    openXmlElement.PtType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.STorageType, DMDrawsDgm1.STorageType>(value);
  }
  
  /// <summary>
  /// DiagramAutoBullet.
  /// </summary>
  private static DMDrawsDgm1.DiagramAutoBullet? GetDiagramAutoBullet(DXO2019DrawDgm11.NumberDiagramInfo openXmlElement)
  {
    return DMXDrawsDgm1.DiagramAutoBulletConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2019DrawDgm11.DiagramAutoBullet>());
  }
  
  private static bool CmpDiagramAutoBullet(DXO2019DrawDgm11.NumberDiagramInfo openXmlElement, DMDrawsDgm1.DiagramAutoBullet? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgm1.DiagramAutoBulletConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2019DrawDgm11.DiagramAutoBullet>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDiagramAutoBullet(DXO2019DrawDgm11.NumberDiagramInfo openXmlElement, DMDrawsDgm1.DiagramAutoBullet? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2019DrawDgm11.DiagramAutoBullet>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgm1.DiagramAutoBulletConverter.CreateOpenXmlElement<DXO2019DrawDgm11.DiagramAutoBullet>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsDgm1.NumberDiagramInfo? CreateModelElement(DXO2019DrawDgm11.NumberDiagramInfo? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgm1.NumberDiagramInfo();
      value.Lvl = GetLvl(openXmlElement);
      value.PtType = GetPtType(openXmlElement);
      value.DiagramAutoBullet = GetDiagramAutoBullet(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2019DrawDgm11.NumberDiagramInfo? openXmlElement, DMDrawsDgm1.NumberDiagramInfo? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgm1.NumberDiagramInfo? value)
    where OpenXmlElementType: DXO2019DrawDgm11.NumberDiagramInfo, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLvl(openXmlElement, value?.Lvl);
      SetPtType(openXmlElement, value?.PtType);
      SetDiagramAutoBullet(openXmlElement, value?.DiagramAutoBullet);
      return openXmlElement;
    }
    return default;
  }
}
