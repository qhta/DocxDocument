namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the CategoryFilterException Class.
/// </summary>
public static class CategoryFilterExceptionConverter
{
  /// <summary>
  /// SequenceOfReferences.
  /// </summary>
  private static String? GetSequenceOfReferences(DXO2013DrawChart.CategoryFilterException openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXO2013DrawChart.SequenceOfReferences>()?.Text;
  }
  
  private static bool CmpSequenceOfReferences(DXO2013DrawChart.CategoryFilterException openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXO2013DrawChart.SequenceOfReferences>()?.Text == value;
  }
  
  private static void SetSequenceOfReferences(DXO2013DrawChart.CategoryFilterException openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.SequenceOfReferences>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO2013DrawChart.SequenceOfReferences { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  private static DMDrawsCharts.ShapeProperties3? GetShapeProperties(DXO2013DrawChart.CategoryFilterException openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChart.ShapeProperties>();
    if (element != null)
      return DMXDrawsCharts.ShapeProperties3Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeProperties(DXO2013DrawChart.CategoryFilterException openXmlElement, DMDrawsCharts.ShapeProperties3? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ShapeProperties3Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChart.ShapeProperties>(), value, diffs, objName);
  }
  
  private static void SetShapeProperties(DXO2013DrawChart.CategoryFilterException openXmlElement, DMDrawsCharts.ShapeProperties3? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.ShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ShapeProperties3Converter.CreateOpenXmlElement<DXO2013DrawChart.ShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Explosion.
  /// </summary>
  private static UInt32? GetExplosion(DXO2013DrawChart.CategoryFilterException openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXO2013DrawChart.Explosion>()?.Val);
  }
  
  private static bool CmpExplosion(DXO2013DrawChart.CategoryFilterException openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXO2013DrawChart.Explosion>()?.Val, value, diffs, objName, "Explosion3");
  }
  
  private static void SetExplosion(DXO2013DrawChart.CategoryFilterException openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXO2013DrawChart.Explosion,System.UInt32>(openXmlElement, value);
  }
  
  /// <summary>
  /// InvertIfNegativeBoolean.
  /// </summary>
  private static Boolean? GetInvertIfNegativeBoolean(DXO2013DrawChart.CategoryFilterException openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO2013DrawChart.InvertIfNegativeBoolean>() != null;
  }
  
  private static bool CmpInvertIfNegativeBoolean(DXO2013DrawChart.CategoryFilterException openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXO2013DrawChart.InvertIfNegativeBoolean>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO2013DrawChart.InvertIfNegativeBoolean", val, value);
    return false;
  }
  
  private static void SetInvertIfNegativeBoolean(DXO2013DrawChart.CategoryFilterException openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.InvertIfNegativeBoolean>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO2013DrawChart.InvertIfNegativeBoolean();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Bubble3D.
  /// </summary>
  private static Boolean? GetBubble3D(DXO2013DrawChart.CategoryFilterException openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO2013DrawChart.Bubble3D>() != null;
  }
  
  private static bool CmpBubble3D(DXO2013DrawChart.CategoryFilterException openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXO2013DrawChart.Bubble3D>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO2013DrawChart.Bubble3D", val, value);
    return false;
  }
  
  private static void SetBubble3D(DXO2013DrawChart.CategoryFilterException openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.Bubble3D>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO2013DrawChart.Bubble3D();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Marker.
  /// </summary>
  private static DMDrawsCharts.Marker3? GetMarker(DXO2013DrawChart.CategoryFilterException openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChart.Marker>();
    if (element != null)
      return DMXDrawsCharts.Marker3Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMarker(DXO2013DrawChart.CategoryFilterException openXmlElement, DMDrawsCharts.Marker3? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.Marker3Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChart.Marker>(), value, diffs, objName);
  }
  
  private static void SetMarker(DXO2013DrawChart.CategoryFilterException openXmlElement, DMDrawsCharts.Marker3? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.Marker>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.Marker3Converter.CreateOpenXmlElement<DXO2013DrawChart.Marker>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// DataLabel.
  /// </summary>
  private static DMDrawsCharts.DataLabel3? GetDataLabel(DXO2013DrawChart.CategoryFilterException openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChart.DataLabel>();
    if (element != null)
      return DMXDrawsCharts.DataLabel3Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataLabel(DXO2013DrawChart.CategoryFilterException openXmlElement, DMDrawsCharts.DataLabel3? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.DataLabel3Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChart.DataLabel>(), value, diffs, objName);
  }
  
  private static void SetDataLabel(DXO2013DrawChart.CategoryFilterException openXmlElement, DMDrawsCharts.DataLabel3? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.DataLabel>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.DataLabel3Converter.CreateOpenXmlElement<DXO2013DrawChart.DataLabel>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.CategoryFilterException? CreateModelElement(DXO2013DrawChart.CategoryFilterException? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.CategoryFilterException();
      value.SequenceOfReferences = GetSequenceOfReferences(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.Explosion = GetExplosion(openXmlElement);
      value.InvertIfNegativeBoolean = GetInvertIfNegativeBoolean(openXmlElement);
      value.Bubble3D = GetBubble3D(openXmlElement);
      value.Marker = GetMarker(openXmlElement);
      value.DataLabel = GetDataLabel(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2013DrawChart.CategoryFilterException? openXmlElement, DMDrawsCharts.CategoryFilterException? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpSequenceOfReferences(openXmlElement, value.SequenceOfReferences, diffs, objName))
        ok = false;
      if (!CmpShapeProperties(openXmlElement, value.ShapeProperties, diffs, objName))
        ok = false;
      if (!CmpExplosion(openXmlElement, value.Explosion, diffs, objName))
        ok = false;
      if (!CmpInvertIfNegativeBoolean(openXmlElement, value.InvertIfNegativeBoolean, diffs, objName))
        ok = false;
      if (!CmpBubble3D(openXmlElement, value.Bubble3D, diffs, objName))
        ok = false;
      if (!CmpMarker(openXmlElement, value.Marker, diffs, objName))
        ok = false;
      if (!CmpDataLabel(openXmlElement, value.DataLabel, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.CategoryFilterException value)
    where OpenXmlElementType: DXO2013DrawChart.CategoryFilterException, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2013DrawChart.CategoryFilterException openXmlElement, DMDrawsCharts.CategoryFilterException value)
  {
    SetSequenceOfReferences(openXmlElement, value?.SequenceOfReferences);
    SetShapeProperties(openXmlElement, value?.ShapeProperties);
    SetExplosion(openXmlElement, value?.Explosion);
    SetInvertIfNegativeBoolean(openXmlElement, value?.InvertIfNegativeBoolean);
    SetBubble3D(openXmlElement, value?.Bubble3D);
    SetMarker(openXmlElement, value?.Marker);
    SetDataLabel(openXmlElement, value?.DataLabel);
  }
}
