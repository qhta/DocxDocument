namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// 3D view settings converter from/to OpenXml.
///</summary>
public static class View3DConverter
{
  /// <summary>
  /// X Rotation.
  /// </summary>
  private static SByte? GetRotateX(DXDrawCharts.View3D openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDrawCharts.RotateX>()?.Val);
  }
  
  private static bool CmpRotateX(DXDrawCharts.View3D openXmlElement, SByte? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDrawCharts.RotateX>()?.Val, value, diffs, objName, "RotateX");
  }
  
  private static void SetRotateX(DXDrawCharts.View3D openXmlElement, SByte? value)
  {
    SimpleValueConverter.SetValue<DXDrawCharts.RotateX,System.SByte>(openXmlElement, value);
  }
  
  /// <summary>
  /// Height Percent.
  /// </summary>
  private static UInt16? GetHeightPercent(DXDrawCharts.View3D openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDrawCharts.HeightPercent>()?.Val);
  }
  
  private static bool CmpHeightPercent(DXDrawCharts.View3D openXmlElement, UInt16? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDrawCharts.HeightPercent>()?.Val, value, diffs, objName, "HeightPercent");
  }
  
  private static void SetHeightPercent(DXDrawCharts.View3D openXmlElement, UInt16? value)
  {
    SimpleValueConverter.SetValue<DXDrawCharts.HeightPercent,System.UInt16>(openXmlElement, value);
  }
  
  /// <summary>
  /// Y Rotation.
  /// </summary>
  private static UInt16? GetRotateY(DXDrawCharts.View3D openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDrawCharts.RotateY>()?.Val);
  }
  
  private static bool CmpRotateY(DXDrawCharts.View3D openXmlElement, UInt16? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDrawCharts.RotateY>()?.Val, value, diffs, objName, "RotateY");
  }
  
  private static void SetRotateY(DXDrawCharts.View3D openXmlElement, UInt16? value)
  {
    SimpleValueConverter.SetValue<DXDrawCharts.RotateY,System.UInt16>(openXmlElement, value);
  }
  
  /// <summary>
  /// Depth Percent.
  /// </summary>
  private static UInt16? GetDepthPercent(DXDrawCharts.View3D openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDrawCharts.DepthPercent>()?.Val);
  }
  
  private static bool CmpDepthPercent(DXDrawCharts.View3D openXmlElement, UInt16? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDrawCharts.DepthPercent>()?.Val, value, diffs, objName, "DepthPercent");
  }
  
  private static void SetDepthPercent(DXDrawCharts.View3D openXmlElement, UInt16? value)
  {
    SimpleValueConverter.SetValue<DXDrawCharts.DepthPercent,System.UInt16>(openXmlElement, value);
  }
  
  /// <summary>
  /// Right Angle Axes.
  /// </summary>
  private static Boolean? GetRightAngleAxes(DXDrawCharts.View3D openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.RightAngleAxes>() != null;
  }
  
  private static bool CmpRightAngleAxes(DXDrawCharts.View3D openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDrawCharts.RightAngleAxes>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDrawCharts.RightAngleAxes", val, value);
    return false;
  }
  
  private static void SetRightAngleAxes(DXDrawCharts.View3D openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.RightAngleAxes>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDrawCharts.RightAngleAxes();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Perspective.
  /// </summary>
  private static Byte? GetPerspective(DXDrawCharts.View3D openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDrawCharts.Perspective>()?.Val);
  }
  
  private static bool CmpPerspective(DXDrawCharts.View3D openXmlElement, Byte? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDrawCharts.Perspective>()?.Val, value, diffs, objName, "Perspective");
  }
  
  private static void SetPerspective(DXDrawCharts.View3D openXmlElement, Byte? value)
  {
    SimpleValueConverter.SetValue<DXDrawCharts.Perspective,System.Byte>(openXmlElement, value);
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  private static DMDrawsCharts.ExtensionList? GetExtensionList(DXDrawCharts.View3D openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.ExtensionList>();
    if (element != null)
      return DMXDrawsCharts.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDrawCharts.View3D openXmlElement, DMDrawsCharts.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.ExtensionList>(), value, diffs, objName);
  }
  
  private static void SetExtensionList(DXDrawCharts.View3D openXmlElement, DMDrawsCharts.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ExtensionListConverter.CreateOpenXmlElement<DXDrawCharts.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.View3D? CreateModelElement(DXDrawCharts.View3D? openXmlElement)
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
  
  public static bool CompareModelElement(DXDrawCharts.View3D? openXmlElement, DMDrawsCharts.View3D? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.View3D value)
    where OpenXmlElementType: DXDrawCharts.View3D, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.View3D openXmlElement, DMDrawsCharts.View3D value)
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
