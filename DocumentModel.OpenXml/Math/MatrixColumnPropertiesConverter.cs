namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Matrix Column Properties.
/// </summary>
public static class MatrixColumnPropertiesConverter
{
  /// <summary>
  /// Matrix Column Count.
  /// </summary>
  public static Int64? GetMatrixColumnCount(DocumentFormat.OpenXml.Math.MatrixColumnProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.MatrixColumnCount>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetMatrixColumnCount(DocumentFormat.OpenXml.Math.MatrixColumnProperties? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.MatrixColumnCount>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Math.MatrixColumnCount{ Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Matrix Column Justification.
  /// </summary>
  public static DocumentModel.Math.HorizontalAlignmentKind? GetMatrixColumnJustification(DocumentFormat.OpenXml.Math.MatrixColumnProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.MatrixColumnJustification>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.HorizontalAlignmentValues, DocumentModel.Math.HorizontalAlignmentKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetMatrixColumnJustification(DocumentFormat.OpenXml.Math.MatrixColumnProperties? openXmlElement, DocumentModel.Math.HorizontalAlignmentKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.MatrixColumnJustification>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.MatrixColumnJustification, DocumentFormat.OpenXml.Math.HorizontalAlignmentValues, DocumentModel.Math.HorizontalAlignmentKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Math.MatrixColumnProperties? CreateModelElement(DocumentFormat.OpenXml.Math.MatrixColumnProperties? openXmlElement)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.MatrixColumnProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Math.MatrixColumnProperties, new()
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
