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
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXMath.MatrixColumnCount>()?.Val);
  }
  
  private static bool CmpMatrixColumnCount(DXMath.MatrixColumnProperties openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXMath.MatrixColumnCount>()?.Val, value, diffs, objName, "MatrixColumnCount");
  }
  
  private static void SetMatrixColumnCount(DXMath.MatrixColumnProperties openXmlElement, Int64? value)
  {
    SimpleValueConverter.SetValue<DXMath.MatrixColumnCount,System.Int64>(openXmlElement, value);
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
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Math.HorizontalAlignmentValues, DMMath.HorizontalAlignmentKind>(itemElement, (DMMath.HorizontalAlignmentKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXMath.MatrixColumnJustification, DocumentFormat.OpenXml.Math.HorizontalAlignmentValues, DMMath.HorizontalAlignmentKind>((DMMath.HorizontalAlignmentKind)value));
  }
  
  public static DocumentModel.Math.MatrixColumnProperties? CreateModelElement(DXMath.MatrixColumnProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.MatrixColumnProperties();
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
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMMath.MatrixColumnProperties value)
    where OpenXmlElementType: DXMath.MatrixColumnProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXMath.MatrixColumnProperties openXmlElement, DMMath.MatrixColumnProperties value)
  {
    SetMatrixColumnCount(openXmlElement, value?.MatrixColumnCount);
    SetMatrixColumnJustification(openXmlElement, value?.MatrixColumnJustification);
    }
  }
