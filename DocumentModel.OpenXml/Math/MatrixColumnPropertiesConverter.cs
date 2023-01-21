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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.MatrixColumnCount>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXMath.MatrixColumnJustification>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.HorizontalAlignmentValues, DMMath.HorizontalAlignmentKind>(itemElement.Val.Value);
    return null;
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
