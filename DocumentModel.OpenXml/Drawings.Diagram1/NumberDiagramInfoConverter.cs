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
    return openXmlElement.Lvl?.Value;
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
  
  private static void SetPtType(DXO2019DrawDgm11.NumberDiagramInfo openXmlElement, DMDrawsDgm1.STorageType? value)
  {
    openXmlElement.PtType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.STorageType, DMDrawsDgm1.STorageType>(value);
  }
  
  /// <summary>
  /// DiagramAutoBullet.
  /// </summary>
  private static DMDrawsDgm1.DiagramAutoBullet? GetDiagramAutoBullet(DXO2019DrawDgm11.NumberDiagramInfo openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2019DrawDgm11.DiagramAutoBullet>();
    if (itemElement != null)
      return DMXDrawsDgm1.DiagramAutoBulletConverter.CreateModelElement(itemElement);
    return null;
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
