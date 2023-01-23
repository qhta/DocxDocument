namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the LightRig Class.
/// </summary>
public static class LightRigConverter
{
  /// <summary>
  /// rig, this property is only available in Office 2010 and later.
  /// </summary>
  private static DMW.LightRigKind? GetLightRigType(DXO2010W.LightRig openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.LightRigTypeValues, DMW.LightRigKind>(openXmlElement?.LightRigType?.Value);
  }
  
  private static bool CmpLightRigType(DXO2010W.LightRig openXmlElement, DMW.LightRigKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.Word.LightRigTypeValues, DMW.LightRigKind>(openXmlElement?.LightRigType?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLightRigType(DXO2010W.LightRig openXmlElement, DMW.LightRigKind? value)
  {
    openXmlElement.LightRigType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.LightRigTypeValues, DMW.LightRigKind>(value);
  }
  
  /// <summary>
  /// dir, this property is only available in Office 2010 and later.
  /// </summary>
  private static DMW.LightRigDirectionKind? GetLightDirectionType(DXO2010W.LightRig openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.LightRigDirectionValues, DMW.LightRigDirectionKind>(openXmlElement?.LightDirectionType?.Value);
  }
  
  private static bool CmpLightDirectionType(DXO2010W.LightRig openXmlElement, DMW.LightRigDirectionKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.Word.LightRigDirectionValues, DMW.LightRigDirectionKind>(openXmlElement?.LightDirectionType?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLightDirectionType(DXO2010W.LightRig openXmlElement, DMW.LightRigDirectionKind? value)
  {
    openXmlElement.LightDirectionType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.LightRigDirectionValues, DMW.LightRigDirectionKind>(value);
  }
  
  /// <summary>
  /// SphereCoordinates.
  /// </summary>
  private static DMW.SphereCoordinates? GetSphereCoordinates(DXO2010W.LightRig openXmlElement)
  {
    return DMXW.SphereCoordinatesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010W.SphereCoordinates>());
  }
  
  private static bool CmpSphereCoordinates(DXO2010W.LightRig openXmlElement, DMW.SphereCoordinates? value, DiffList? diffs, string? objName)
  {
    return DMXW.SphereCoordinatesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2010W.SphereCoordinates>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSphereCoordinates(DXO2010W.LightRig openXmlElement, DMW.SphereCoordinates? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.SphereCoordinates>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.SphereCoordinatesConverter.CreateOpenXmlElement<DXO2010W.SphereCoordinates>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.LightRig? CreateModelElement(DXO2010W.LightRig? openXmlElement)
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
  
  public static bool CompareModelElement(DXO2010W.LightRig? openXmlElement, DMW.LightRig? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLightRigType(openXmlElement, value.LightRigType, diffs, objName))
        ok = false;
      if (!CmpLightDirectionType(openXmlElement, value.LightDirectionType, diffs, objName))
        ok = false;
      if (!CmpSphereCoordinates(openXmlElement, value.SphereCoordinates, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.LightRig? value)
    where OpenXmlElementType: DXO2010W.LightRig, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLightRigType(openXmlElement, value?.LightRigType);
      SetLightDirectionType(openXmlElement, value?.LightDirectionType);
      SetSphereCoordinates(openXmlElement, value?.SphereCoordinates);
      return openXmlElement;
    }
    return default;
  }
}
