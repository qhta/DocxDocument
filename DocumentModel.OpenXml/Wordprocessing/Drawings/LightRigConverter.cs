namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the LightRig Class.
/// </summary>
public static class LightRigConverter
{
  /// <summary>
  /// rig, this property is only available in Office 2010 and later.
  /// </summary>
  private static DMW.LightRigKind? GetLightRigType(DXO10W.LightRig openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.LightRigTypeValues, DMW.LightRigKind>(openXmlElement?.LightRigType?.Value);
  }
  
  private static bool CmpLightRigType(DXO10W.LightRig openXmlElement, DMW.LightRigKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.Word.LightRigTypeValues, DMW.LightRigKind>(openXmlElement?.LightRigType?.Value, value, diffs, objName, propName);
  }
  
  private static void SetLightRigType(DXO10W.LightRig openXmlElement, DMW.LightRigKind? value)
  {
    openXmlElement.LightRigType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.LightRigTypeValues, DMW.LightRigKind>(value);
  }
  
  /// <summary>
  /// dir, this property is only available in Office 2010 and later.
  /// </summary>
  private static DMW.LightRigDirectionKind? GetLightDirectionType(DXO10W.LightRig openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.LightRigDirectionValues, DMW.LightRigDirectionKind>(openXmlElement?.LightDirectionType?.Value);
  }
  
  private static bool CmpLightDirectionType(DXO10W.LightRig openXmlElement, DMW.LightRigDirectionKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.Word.LightRigDirectionValues, DMW.LightRigDirectionKind>(openXmlElement?.LightDirectionType?.Value, value, diffs, objName, propName);
  }
  
  private static void SetLightDirectionType(DXO10W.LightRig openXmlElement, DMW.LightRigDirectionKind? value)
  {
    openXmlElement.LightDirectionType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.LightRigDirectionValues, DMW.LightRigDirectionKind>(value);
  }
  
  /// <summary>
  /// SphereCoordinates.
  /// </summary>
  private static DMW.SphereCoordinates? GetSphereCoordinates(DXO10W.LightRig openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10W.SphereCoordinates>();
    if (element != null)
      return DMXW.SphereCoordinatesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSphereCoordinates(DXO10W.LightRig openXmlElement, DMW.SphereCoordinates? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.SphereCoordinatesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10W.SphereCoordinates>(), value, diffs, objName, propName);
  }
  
  private static void SetSphereCoordinates(DXO10W.LightRig openXmlElement, DMW.SphereCoordinates? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10W.SphereCoordinates>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.SphereCoordinatesConverter.CreateOpenXmlElement<DXO10W.SphereCoordinates>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMW.LightRig? CreateModelElement(DXO10W.LightRig? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.LightRig();
      value.LightRigType = GetLightRigType(openXmlElement);
      value.LightDirectionType = GetLightDirectionType(openXmlElement);
      value.SphereCoordinates = GetSphereCoordinates(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO10W.LightRig? openXmlElement, DMW.LightRig? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLightRigType(openXmlElement, value.LightRigType, diffs, objName, propName))
        ok = false;
      if (!CmpLightDirectionType(openXmlElement, value.LightDirectionType, diffs, objName, propName))
        ok = false;
      if (!CmpSphereCoordinates(openXmlElement, value.SphereCoordinates, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.LightRig value)
    where OpenXmlElementType: DXO10W.LightRig, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10W.LightRig openXmlElement, DMW.LightRig value)
  {
    SetLightRigType(openXmlElement, value?.LightRigType);
    SetLightDirectionType(openXmlElement, value?.LightDirectionType);
    SetSphereCoordinates(openXmlElement, value?.SphereCoordinates);
  }
}
