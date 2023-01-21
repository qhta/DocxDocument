namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// 3D view settings.
/// </summary>
public static class View3DConverter
{
  /// <summary>
  /// X Rotation.
  /// </summary>
  private static SByte? GetRotateX(DXDrawCharts.View3D openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.RotateX>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetRotateX(DXDrawCharts.View3D openXmlElement, SByte? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.RotateX>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.RotateX{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Height Percent.
  /// </summary>
  private static UInt16? GetHeightPercent(DXDrawCharts.View3D openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.HeightPercent>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetHeightPercent(DXDrawCharts.View3D openXmlElement, UInt16? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.HeightPercent>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.HeightPercent{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Y Rotation.
  /// </summary>
  private static UInt16? GetRotateY(DXDrawCharts.View3D openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.RotateY>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetRotateY(DXDrawCharts.View3D openXmlElement, UInt16? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.RotateY>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.RotateY{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Depth Percent.
  /// </summary>
  private static UInt16? GetDepthPercent(DXDrawCharts.View3D openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.DepthPercent>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetDepthPercent(DXDrawCharts.View3D openXmlElement, UInt16? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.DepthPercent>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.DepthPercent{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Right Angle Axes.
  /// </summary>
  private static Boolean? GetRightAngleAxes(DXDrawCharts.View3D openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.RightAngleAxes>();
    return itemElement != null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Perspective>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetPerspective(DXDrawCharts.View3D openXmlElement, Byte? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Perspective>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.Perspective{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  private static DMDrawsCharts.ExtensionList? GetExtensionList(DXDrawCharts.View3D openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.ExtensionList>();
    if (itemElement != null)
      return DMXDrawsCharts.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static DMDrawsCharts.View3D? CreateModelElement(DXDrawCharts.View3D? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.View3D();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.View3D? value)
    where OpenXmlElementType: DXDrawCharts.View3D, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRotateX(openXmlElement, value?.RotateX);
      SetHeightPercent(openXmlElement, value?.HeightPercent);
      SetRotateY(openXmlElement, value?.RotateY);
      SetDepthPercent(openXmlElement, value?.DepthPercent);
      SetRightAngleAxes(openXmlElement, value?.RightAngleAxes);
      SetPerspective(openXmlElement, value?.Perspective);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
