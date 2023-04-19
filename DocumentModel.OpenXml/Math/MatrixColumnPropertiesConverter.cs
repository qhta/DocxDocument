namespace DocumentModel.OpenXml.Math;

/// <summary>
/// <see cref="DMM.MatrixColumnProperties"/> class from/to OpenXml converter.
/// </summary>
public static class MatrixColumnPropertiesConverter
{
  #region Matrix Column Count. conversion.
  private static Int32? GetMatrixColumnCount(DXM.MatrixColumnProperties openXmlElement)
  {
    return Int32ValueConverter.GetValue(openXmlElement?.GetFirstChild<DXM.MatrixColumnCount>()?.Val);
  }
  
  private static bool CmpMatrixColumnCount(DXM.MatrixColumnProperties openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return Int32ValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXM.MatrixColumnCount>()?.Val, value, diffs, objName, "MatrixColumnCount");
  }
  
  private static void SetMatrixColumnCount(DXM.MatrixColumnProperties openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXM.MatrixColumnCount,System.Int64>(openXmlElement, value);
  }
  #endregion

  #region Matrix Column Justification conversion.
  private static DMM.HorizontalAlignmentKind? GetMatrixColumnJustification(DXM.MatrixColumnProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.HorizontalAlignmentValues, DMM.HorizontalAlignmentKind>(openXmlElement.GetFirstChild<DXM.MatrixColumnJustification>()?.Val?.Value);
  }
  
  private static bool CmpMatrixColumnJustification(DXM.MatrixColumnProperties openXmlElement, DMM.HorizontalAlignmentKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.HorizontalAlignmentValues, DMM.HorizontalAlignmentKind>(openXmlElement.GetFirstChild<DXM.MatrixColumnJustification>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetMatrixColumnJustification(DXM.MatrixColumnProperties openXmlElement, DMM.HorizontalAlignmentKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.MatrixColumnJustification>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Math.HorizontalAlignmentValues, DMM.HorizontalAlignmentKind>(itemElement, (DMM.HorizontalAlignmentKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXM.MatrixColumnJustification, DocumentFormat.OpenXml.Math.HorizontalAlignmentValues, DMM.HorizontalAlignmentKind>((DMM.HorizontalAlignmentKind)value));
  }
  #endregion

  #region MatrixColumnProperties model conversion.
  public static DMM.MatrixColumnProperties? CreateModelElement(DXM.MatrixColumnProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMM.MatrixColumnProperties();
      model.MatrixColumnCount = GetMatrixColumnCount(openXmlElement);
      model.MatrixColumnJustification = GetMatrixColumnJustification(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXM.MatrixColumnProperties? openXmlElement, DMM.MatrixColumnProperties? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpMatrixColumnCount(openXmlElement, model.MatrixColumnCount, diffs, objName))
        ok = false;
      if (!CmpMatrixColumnJustification(openXmlElement, model.MatrixColumnJustification, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMM.MatrixColumnProperties model)
    where OpenXmlElementType: DXM.MatrixColumnProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXM.MatrixColumnProperties openXmlElement, DMM.MatrixColumnProperties model)
  {
    SetMatrixColumnCount(openXmlElement, model?.MatrixColumnCount);
    SetMatrixColumnJustification(openXmlElement, model?.MatrixColumnJustification);
  }
  #endregion
}
