namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Light Rig.
/// </summary>
public static class LightRigConverter
{
  /// <summary>
  /// Rig Preset
  /// </summary>
  private static DMDraws.LightRigKind? GetRig(DXDraw.LightRig openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.LightRigValues, DMDraws.LightRigKind>(openXmlElement?.Rig?.Value);
  }
  
  private static bool CmpRig(DXDraw.LightRig openXmlElement, DMDraws.LightRigKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.LightRigValues, DMDraws.LightRigKind>(openXmlElement?.Rig?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRig(DXDraw.LightRig openXmlElement, DMDraws.LightRigKind? value)
  {
    openXmlElement.Rig = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.LightRigValues, DMDraws.LightRigKind>(value);
  }
  
  /// <summary>
  /// Direction
  /// </summary>
  private static DMDraws.LightRigDirectionKind? GetDirection(DXDraw.LightRig openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.LightRigDirectionValues, DMDraws.LightRigDirectionKind>(openXmlElement?.Direction?.Value);
  }
  
  private static bool CmpDirection(DXDraw.LightRig openXmlElement, DMDraws.LightRigDirectionKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.LightRigDirectionValues, DMDraws.LightRigDirectionKind>(openXmlElement?.Direction?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDirection(DXDraw.LightRig openXmlElement, DMDraws.LightRigDirectionKind? value)
  {
    openXmlElement.Direction = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.LightRigDirectionValues, DMDraws.LightRigDirectionKind>(value);
  }
  
  /// <summary>
  /// Rotation.
  /// </summary>
  private static DMDraws.Rotation? GetRotation(DXDraw.LightRig openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.Rotation>();
    if (element != null)
      return DMXDraws.RotationConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRotation(DXDraw.LightRig openXmlElement, DMDraws.Rotation? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.RotationConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Rotation>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRotation(DXDraw.LightRig openXmlElement, DMDraws.Rotation? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Rotation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.RotationConverter.CreateOpenXmlElement<DXDraw.Rotation>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.LightRig? CreateModelElement(DXDraw.LightRig? openXmlElement)
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
  
  public static bool CompareModelElement(DXDraw.LightRig? openXmlElement, DMDraws.LightRig? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRig(openXmlElement, value.Rig, diffs, objName))
        ok = false;
      if (!CmpDirection(openXmlElement, value.Direction, diffs, objName))
        ok = false;
      if (!CmpRotation(openXmlElement, value.Rotation, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.LightRig value)
    where OpenXmlElementType: DXDraw.LightRig, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.LightRig openXmlElement, DMDraws.LightRig value)
  {
    SetRig(openXmlElement, value?.Rig);
    SetDirection(openXmlElement, value?.Direction);
    SetRotation(openXmlElement, value?.Rotation);
    }
  }
