namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the DataPoint Class.
/// </summary>
public static class DataPointConverter
{
  /// <summary>
  /// Index.
  /// </summary>
  private static UInt32? GetIndex(DXDC.DataPoint openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.Index>()?.Val);
  }
  
  private static bool CmpIndex(DXDC.DataPoint openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.Index>()?.Val, value, diffs, objName, "Index");
  }
  
  private static void SetIndex(DXDC.DataPoint openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXDC.Index,System.UInt32>(openXmlElement, value);
  }
  
  /// <summary>
  /// Invert if Negative.
  /// </summary>
  private static Boolean? GetInvertIfNegative(DXDC.DataPoint openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.InvertIfNegative>() != null;
  }
  
  private static bool CmpInvertIfNegative(DXDC.DataPoint openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXDC.InvertIfNegative>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.InvertIfNegative", val, value);
    return false;
  }
  
  private static void SetInvertIfNegative(DXDC.DataPoint openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDC.InvertIfNegative>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDC.InvertIfNegative();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Marker.
  /// </summary>
  private static DMDC.Marker? GetMarker(DXDC.DataPoint openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.Marker>();
    if (element != null)
      return DMXDC.MarkerConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMarker(DXDC.DataPoint openXmlElement, DMDC.Marker? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.MarkerConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.Marker>(), value, diffs, objName, propName);
  }
  
  private static void SetMarker(DXDC.DataPoint openXmlElement, DMDC.Marker? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.Marker>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.MarkerConverter.CreateOpenXmlElement<DXDC.Marker>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// 3D Bubble.
  /// </summary>
  private static Boolean? GetBubble3D(DXDC.DataPoint openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.Bubble3D>() != null;
  }
  
  private static bool CmpBubble3D(DXDC.DataPoint openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXDC.Bubble3D>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.Bubble3D", val, value);
    return false;
  }
  
  private static void SetBubble3D(DXDC.DataPoint openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDC.Bubble3D>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDC.Bubble3D();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Explosion.
  /// </summary>
  private static UInt32? GetExplosion(DXDC.DataPoint openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.Explosion>()?.Val);
  }
  
  private static bool CmpExplosion(DXDC.DataPoint openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.Explosion>()?.Val, value, diffs, objName, "Explosion");
  }
  
  private static void SetExplosion(DXDC.DataPoint openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXDC.Explosion,System.UInt32>(openXmlElement, value);
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  private static DMDC.ChartShapeProperties? GetChartShapeProperties(DXDC.DataPoint openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ChartShapeProperties>();
    if (element != null)
      return DMXDC.ChartShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChartShapeProperties(DXDC.DataPoint openXmlElement, DMDC.ChartShapeProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.ChartShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ChartShapeProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetChartShapeProperties(DXDC.DataPoint openXmlElement, DMDC.ChartShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.ChartShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.ChartShapePropertiesConverter.CreateOpenXmlElement<DXDC.ChartShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// PictureOptions.
  /// </summary>
  private static DMDC.PictureOptions? GetPictureOptions(DXDC.DataPoint openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.PictureOptions>();
    if (element != null)
      return DMXDC.PictureOptionsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPictureOptions(DXDC.DataPoint openXmlElement, DMDC.PictureOptions? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.PictureOptionsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.PictureOptions>(), value, diffs, objName, propName);
  }
  
  private static void SetPictureOptions(DXDC.DataPoint openXmlElement, DMDC.PictureOptions? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.PictureOptions>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.PictureOptionsConverter.CreateOpenXmlElement<DXDC.PictureOptions>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  private static DMDC.ExtensionList? GetExtensionList(DXDC.DataPoint openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ExtensionList>();
    if (element != null)
      return DMXDC.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDC.DataPoint openXmlElement, DMDC.ExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetExtensionList(DXDC.DataPoint openXmlElement, DMDC.ExtensionList? value)
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
  
  public static DMD.Charts.DataPoint? CreateModelElement(DXDC.DataPoint? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Charts.DataPoint();
      value.Index = GetIndex(openXmlElement);
      value.InvertIfNegative = GetInvertIfNegative(openXmlElement);
      value.Marker = GetMarker(openXmlElement);
      value.Bubble3D = GetBubble3D(openXmlElement);
      value.Explosion = GetExplosion(openXmlElement);
      value.ChartShapeProperties = GetChartShapeProperties(openXmlElement);
      value.PictureOptions = GetPictureOptions(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.DataPoint? openXmlElement, DMDC.DataPoint? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpIndex(openXmlElement, value.Index, diffs, objName, propName))
        ok = false;
      if (!CmpInvertIfNegative(openXmlElement, value.InvertIfNegative, diffs, objName, propName))
        ok = false;
      if (!CmpMarker(openXmlElement, value.Marker, diffs, objName, propName))
        ok = false;
      if (!CmpBubble3D(openXmlElement, value.Bubble3D, diffs, objName, propName))
        ok = false;
      if (!CmpExplosion(openXmlElement, value.Explosion, diffs, objName, propName))
        ok = false;
      if (!CmpChartShapeProperties(openXmlElement, value.ChartShapeProperties, diffs, objName, propName))
        ok = false;
      if (!CmpPictureOptions(openXmlElement, value.PictureOptions, diffs, objName, propName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.DataPoint value)
    where OpenXmlElementType: DXDC.DataPoint, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.DataPoint openXmlElement, DMDC.DataPoint value)
  {
    SetIndex(openXmlElement, value?.Index);
    SetInvertIfNegative(openXmlElement, value?.InvertIfNegative);
    SetMarker(openXmlElement, value?.Marker);
    SetBubble3D(openXmlElement, value?.Bubble3D);
    SetExplosion(openXmlElement, value?.Explosion);
    SetChartShapeProperties(openXmlElement, value?.ChartShapeProperties);
    SetPictureOptions(openXmlElement, value?.PictureOptions);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
