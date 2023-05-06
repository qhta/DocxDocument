namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// 3D view settings.
/// </summary>
public static class View3DConverter
{
  /// <summary>
  /// X Rotation.
  /// </summary>
  private static SByte? GetRotateX(DXDC.View3D openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.RotateX>()?.Val);
  }
  
  private static bool CmpRotateX(DXDC.View3D openXmlElement, SByte? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.RotateX>()?.Val, value, diffs, objName, "RotateX");
  }
  
  private static void SetRotateX(DXDC.View3D openXmlElement, SByte? value)
  {
    SimpleValueConverter.SetValue<DXDC.RotateX,System.SByte>(openXmlElement, value);
  }
  
  /// <summary>
  /// Height Percent.
  /// </summary>
  private static UInt16? GetHeightPercent(DXDC.View3D openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.HeightPercent>()?.Val);
  }
  
  private static bool CmpHeightPercent(DXDC.View3D openXmlElement, UInt16? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.HeightPercent>()?.Val, value, diffs, objName, "HeightPercent");
  }
  
  private static void SetHeightPercent(DXDC.View3D openXmlElement, UInt16? value)
  {
    SimpleValueConverter.SetValue<DXDC.HeightPercent,System.UInt16>(openXmlElement, value);
  }
  
  /// <summary>
  /// Y Rotation.
  /// </summary>
  private static UInt16? GetRotateY(DXDC.View3D openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.RotateY>()?.Val);
  }
  
  private static bool CmpRotateY(DXDC.View3D openXmlElement, UInt16? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.RotateY>()?.Val, value, diffs, objName, "RotateY");
  }
  
  private static void SetRotateY(DXDC.View3D openXmlElement, UInt16? value)
  {
    SimpleValueConverter.SetValue<DXDC.RotateY,System.UInt16>(openXmlElement, value);
  }
  
  /// <summary>
  /// Depth Percent.
  /// </summary>
  private static UInt16? GetDepthPercent(DXDC.View3D openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.DepthPercent>()?.Val);
  }
  
  private static bool CmpDepthPercent(DXDC.View3D openXmlElement, UInt16? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.DepthPercent>()?.Val, value, diffs, objName, "DepthPercent");
  }
  
  private static void SetDepthPercent(DXDC.View3D openXmlElement, UInt16? value)
  {
    SimpleValueConverter.SetValue<DXDC.DepthPercent,System.UInt16>(openXmlElement, value);
  }
  
  /// <summary>
  /// Right Angle Axes.
  /// </summary>
  private static Boolean? GetRightAngleAxes(DXDC.View3D openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.RightAngleAxes>() != null;
  }
  
  private static bool CmpRightAngleAxes(DXDC.View3D openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDC.RightAngleAxes>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.RightAngleAxes", val, value);
    return false;
  }
  
  private static void SetRightAngleAxes(DXDC.View3D openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDC.RightAngleAxes>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDC.RightAngleAxes();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Perspective.
  /// </summary>
  private static Byte? GetPerspective(DXDC.View3D openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.Perspective>()?.Val);
  }
  
  private static bool CmpPerspective(DXDC.View3D openXmlElement, Byte? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.Perspective>()?.Val, value, diffs, objName, "Perspective");
  }
  
  private static void SetPerspective(DXDC.View3D openXmlElement, Byte? value)
  {
    SimpleValueConverter.SetValue<DXDC.Perspective,System.Byte>(openXmlElement, value);
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  private static DMDC.ExtensionList? GetExtensionList(DXDC.View3D openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ExtensionList>();
    if (element != null)
      return DMXDC.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDC.View3D openXmlElement, DMDC.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDC.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ExtensionList>(), value, diffs, objName);
  }
  
  private static void SetExtensionList(DXDC.View3D openXmlElement, DMDC.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.ExtensionListConverter.CreateOpenXmlElement<DXDC.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.View3D? CreateModelElement(DXDC.View3D? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.View3D();
      value.RotateX = GetRotateX(openXmlElement);
      value.HeightPercent = GetHeightPercent(openXmlElement);
      value.RotateY = GetRotateY(openXmlElement);
      value.DepthPercent = GetDepthPercent(openXmlElement);
      value.RightAngleAxes = GetRightAngleAxes(openXmlElement);
      value.Perspective = GetPerspective(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.View3D? openXmlElement, DMDC.View3D? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRotateX(openXmlElement, value.RotateX, diffs, objName))
        ok = false;
      if (!CmpHeightPercent(openXmlElement, value.HeightPercent, diffs, objName))
        ok = false;
      if (!CmpRotateY(openXmlElement, value.RotateY, diffs, objName))
        ok = false;
      if (!CmpDepthPercent(openXmlElement, value.DepthPercent, diffs, objName))
        ok = false;
      if (!CmpRightAngleAxes(openXmlElement, value.RightAngleAxes, diffs, objName))
        ok = false;
      if (!CmpPerspective(openXmlElement, value.Perspective, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.View3D value)
    where OpenXmlElementType: DXDC.View3D, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.View3D openXmlElement, DMDC.View3D value)
  {
    SetRotateX(openXmlElement, value?.RotateX);
    SetHeightPercent(openXmlElement, value?.HeightPercent);
    SetRotateY(openXmlElement, value?.RotateY);
    SetDepthPercent(openXmlElement, value?.DepthPercent);
    SetRightAngleAxes(openXmlElement, value?.RightAngleAxes);
    SetPerspective(openXmlElement, value?.Perspective);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
