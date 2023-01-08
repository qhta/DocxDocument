namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Matrix Column Properties.
/// </summary>
public static class MatrixColumnPropertiesConverter
{
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
  
}
