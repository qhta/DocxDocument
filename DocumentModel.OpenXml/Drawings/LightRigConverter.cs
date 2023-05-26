namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Light Rig.
/// </summary>
public static class LightRigConverter
{
  /// <summary>
  /// Rig Preset
  /// </summary>
  private static DMD.LightRigKind? GetRig(DXD.LightRig openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.LightRigValues, DMD.LightRigKind>(openXmlElement?.Rig?.Value);
  }
  
  private static bool CmpRig(DXD.LightRig openXmlElement, DMD.LightRigKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.LightRigValues, DMD.LightRigKind>(openXmlElement?.Rig?.Value, value, diffs, objName, propName);
  }
  
  private static void SetRig(DXD.LightRig openXmlElement, DMD.LightRigKind? value)
  {
    openXmlElement.Rig = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.LightRigValues, DMD.LightRigKind>(value);
  }
  
  /// <summary>
  /// Direction
  /// </summary>
  private static DMD.LightRigDirectionKind? GetDirection(DXD.LightRig openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.LightRigDirectionValues, DMD.LightRigDirectionKind>(openXmlElement?.Direction?.Value);
  }
  
  private static bool CmpDirection(DXD.LightRig openXmlElement, DMD.LightRigDirectionKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.LightRigDirectionValues, DMD.LightRigDirectionKind>(openXmlElement?.Direction?.Value, value, diffs, objName, propName);
  }
  
  private static void SetDirection(DXD.LightRig openXmlElement, DMD.LightRigDirectionKind? value)
  {
    openXmlElement.Direction = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.LightRigDirectionValues, DMD.LightRigDirectionKind>(value);
  }
  
  /// <summary>
  /// Rotation.
  /// </summary>
  private static DMD.Rotation? GetRotation(DXD.LightRig openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Rotation>();
    if (element != null)
      return DMXD.RotationConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRotation(DXD.LightRig openXmlElement, DMD.Rotation? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.RotationConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Rotation>(), value, diffs, objName, propName);
  }
  
  private static void SetRotation(DXD.LightRig openXmlElement, DMD.Rotation? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Rotation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.RotationConverter.CreateOpenXmlElement<DXD.Rotation>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.LightRig? CreateModelElement(DXD.LightRig? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.LightRig();
      value.Rig = GetRig(openXmlElement);
      value.Direction = GetDirection(openXmlElement);
      value.Rotation = GetRotation(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.LightRig? openXmlElement, DMD.LightRig? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRig(openXmlElement, value.Rig, diffs, objName, propName))
        ok = false;
      if (!CmpDirection(openXmlElement, value.Direction, diffs, objName, propName))
        ok = false;
      if (!CmpRotation(openXmlElement, value.Rotation, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.LightRig value)
    where OpenXmlElementType: DXD.LightRig, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.LightRig openXmlElement, DMD.LightRig value)
  {
    SetRig(openXmlElement, value?.Rig);
    SetDirection(openXmlElement, value?.Direction);
    SetRotation(openXmlElement, value?.Rotation);
  }
}
