namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the CameraTool Class.
/// </summary>
public static class CameraToolConverter
{
  /// <summary>
  /// cellRange, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetCellRange(DocumentFormat.OpenXml.Office2010.Drawing.CameraTool openXmlElement)
  {
    return openXmlElement?.CellRange?.Value;
  }
  
  private static void SetCellRange(DocumentFormat.OpenXml.Office2010.Drawing.CameraTool openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.CellRange = new StringValue { Value = value };
    else
      openXmlElement.CellRange = null;
  }
  
  /// <summary>
  /// spid, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetShapeId(DocumentFormat.OpenXml.Office2010.Drawing.CameraTool openXmlElement)
  {
    return openXmlElement?.ShapeId?.Value;
  }
  
  private static void SetShapeId(DocumentFormat.OpenXml.Office2010.Drawing.CameraTool openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ShapeId = new StringValue { Value = value };
    else
      openXmlElement.ShapeId = null;
  }
  
  public static DocumentModel.Drawings.CameraTool? CreateModelElement(DocumentFormat.OpenXml.Office2010.Drawing.CameraTool? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.CameraTool();
      value.CellRange = GetCellRange(openXmlElement);
      value.ShapeId = GetShapeId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.CameraTool? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Drawing.CameraTool, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetCellRange(openXmlElement, value?.CellRange);
      SetShapeId(openXmlElement, value?.ShapeId);
      return openXmlElement;
    }
    return default;
  }
}
