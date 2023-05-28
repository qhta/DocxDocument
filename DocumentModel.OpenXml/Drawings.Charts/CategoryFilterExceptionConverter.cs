namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the CategoryFilterException Class.
/// </summary>
public static class CategoryFilterExceptionConverter
{
  /// <summary>
  /// SequenceOfReferences.
  /// </summary>
  private static String? GetSequenceOfReferences(DXO13DC.CategoryFilterException openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXO13DC.SequenceOfReferences>()?.Text;
  }
  
  private static bool CmpSequenceOfReferences(DXO13DC.CategoryFilterException openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
      return openXmlElement?.GetFirstChild<DXO13DC.SequenceOfReferences>()?.Text == value;
  }
  
  private static void SetSequenceOfReferences(DXO13DC.CategoryFilterException openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DC.SequenceOfReferences>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO13DC.SequenceOfReferences { Text = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  private static DMDC.ShapeProperties3? GetShapeProperties(DXO13DC.CategoryFilterException openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DC.ShapeProperties>();
    if (element != null)
      return DMXDC.ShapeProperties3Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeProperties(DXO13DC.CategoryFilterException openXmlElement, DMDC.ShapeProperties3? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.ShapeProperties3Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DC.ShapeProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetShapeProperties(DXO13DC.CategoryFilterException openXmlElement, DMDC.ShapeProperties3? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DC.ShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.ShapeProperties3Converter.CreateOpenXmlElement<DXO13DC.ShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Explosion.
  /// </summary>
  private static UInt32? GetExplosion(DXO13DC.CategoryFilterException openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXO13DC.Explosion>()?.Val);
  }
  
  private static bool CmpExplosion(DXO13DC.CategoryFilterException openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXO13DC.Explosion>()?.Val, value, diffs, objName, "Explosion3");
  }
  
  private static void SetExplosion(DXO13DC.CategoryFilterException openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXO13DC.Explosion,System.UInt32>(openXmlElement, value);
  }
  
  /// <summary>
  /// InvertIfNegativeBoolean.
  /// </summary>
  private static Boolean? GetInvertIfNegativeBoolean(DXO13DC.CategoryFilterException openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO13DC.InvertIfNegativeBoolean>() != null;
  }
  
  private static bool CmpInvertIfNegativeBoolean(DXO13DC.CategoryFilterException openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXO13DC.InvertIfNegativeBoolean>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO13DC.InvertIfNegativeBoolean", val, value);
    return false;
  }
  
  private static void SetInvertIfNegativeBoolean(DXO13DC.CategoryFilterException openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO13DC.InvertIfNegativeBoolean>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO13DC.InvertIfNegativeBoolean();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Bubble3D.
  /// </summary>
  private static Boolean? GetBubble3D(DXO13DC.CategoryFilterException openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO13DC.Bubble3D>() != null;
  }
  
  private static bool CmpBubble3D(DXO13DC.CategoryFilterException openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXO13DC.Bubble3D>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO13DC.Bubble3D", val, value);
    return false;
  }
  
  private static void SetBubble3D(DXO13DC.CategoryFilterException openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO13DC.Bubble3D>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO13DC.Bubble3D();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Marker.
  /// </summary>
  private static DMDC.Marker3? GetMarker(DXO13DC.CategoryFilterException openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DC.Marker>();
    if (element != null)
      return DMXDC.Marker3Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMarker(DXO13DC.CategoryFilterException openXmlElement, DMDC.Marker3? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.Marker3Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DC.Marker>(), value, diffs, objName, propName);
  }
  
  private static void SetMarker(DXO13DC.CategoryFilterException openXmlElement, DMDC.Marker3? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DC.Marker>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.Marker3Converter.CreateOpenXmlElement<DXO13DC.Marker>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// DataLabel.
  /// </summary>
  private static DMDC.DataLabel3? GetDataLabel(DXO13DC.CategoryFilterException openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DC.DataLabel>();
    if (element != null)
      return DMXDC.DataLabel3Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataLabel(DXO13DC.CategoryFilterException openXmlElement, DMDC.DataLabel3? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.DataLabel3Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DC.DataLabel>(), value, diffs, objName, propName);
  }
  
  private static void SetDataLabel(DXO13DC.CategoryFilterException openXmlElement, DMDC.DataLabel3? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DC.DataLabel>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.DataLabel3Converter.CreateOpenXmlElement<DXO13DC.DataLabel>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.Charts.CategoryFilterException? CreateModelElement(DXO13DC.CategoryFilterException? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Charts.CategoryFilterException();
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
  
  public static bool CompareModelElement(DXO13DC.CategoryFilterException? openXmlElement, DMDC.CategoryFilterException? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpSequenceOfReferences(openXmlElement, value.SequenceOfReferences, diffs, objName, propName))
        ok = false;
      if (!CmpShapeProperties(openXmlElement, value.ShapeProperties, diffs, objName, propName))
        ok = false;
      if (!CmpExplosion(openXmlElement, value.Explosion, diffs, objName, propName))
        ok = false;
      if (!CmpInvertIfNegativeBoolean(openXmlElement, value.InvertIfNegativeBoolean, diffs, objName, propName))
        ok = false;
      if (!CmpBubble3D(openXmlElement, value.Bubble3D, diffs, objName, propName))
        ok = false;
      if (!CmpMarker(openXmlElement, value.Marker, diffs, objName, propName))
        ok = false;
      if (!CmpDataLabel(openXmlElement, value.DataLabel, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.CategoryFilterException value)
    where OpenXmlElementType: DXO13DC.CategoryFilterException, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO13DC.CategoryFilterException openXmlElement, DMDC.CategoryFilterException value)
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
