namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Matrix Column Properties.
/// </summary>
public static class MatrixColumnPropertiesConverter
{
  /// <summary>
  /// Matrix Column Count.
  /// </summary>
  private static Int64? GetMatrixColumnCount(DXMath.MatrixColumnProperties openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXMath.MatrixColumnCount>()?.Val?.Value;
  }
  
  private static bool CmpMatrixColumnCount(DXMath.MatrixColumnProperties openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetFirstChild<DXMath.MatrixColumnCount>()?.Val?.Value == value;
  }
  
  private static void SetMatrixColumnCount(DXMath.MatrixColumnProperties openXmlElement, Int64? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.MatrixColumnCount>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXMath.MatrixColumnCount{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Matrix Column Justification.
  /// </summary>
  private static DMMath.HorizontalAlignmentKind? GetMatrixColumnJustification(DXMath.MatrixColumnProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.HorizontalAlignmentValues, DMMath.HorizontalAlignmentKind>(openXmlElement.GetFirstChild<DXMath.MatrixColumnJustification>()?.Val?.Value);
  }
  
  private static bool CmpMatrixColumnJustification(DXMath.MatrixColumnProperties openXmlElement, DMMath.HorizontalAlignmentKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.HorizontalAlignmentValues, DMMath.HorizontalAlignmentKind>(openXmlElement.GetFirstChild<DXMath.MatrixColumnJustification>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMatrixColumnJustification(DXMath.MatrixColumnProperties openXmlElement, DMMath.HorizontalAlignmentKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.MatrixColumnJustification>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXMath.MatrixColumnJustification, DocumentFormat.OpenXml.Math.HorizontalAlignmentValues, DMMath.HorizontalAlignmentKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMMath.MatrixColumnProperties? CreateModelElement(DXMath.MatrixColumnProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMMath.MatrixColumnProperties();
      value.MatrixColumnCount = GetMatrixColumnCount(openXmlElement);
      value.MatrixColumnJustification = GetMatrixColumnJustification(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXMath.MatrixColumnProperties? openXmlElement, DMMath.MatrixColumnProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpMatrixColumnCount(openXmlElement, value.MatrixColumnCount, diffs, objName))
        ok = false;
      if (!CmpMatrixColumnJustification(openXmlElement, value.MatrixColumnJustification, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMMath.MatrixColumnProperties? value)
    where OpenXmlElementType: DXMath.MatrixColumnProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetMatrixColumnCount(openXmlElement, value?.MatrixColumnCount);
      SetMatrixColumnJustification(openXmlElement, value?.MatrixColumnJustification);
      return openXmlElement;
    }
    return default;
  }
}
