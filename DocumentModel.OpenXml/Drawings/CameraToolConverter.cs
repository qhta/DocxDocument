using DocumentFormat.OpenXml.Office2010.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the CameraTool Class.
/// </summary>
public static class CameraToolConverter
{
  /// <summary>
  ///   cellRange, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetCellRange(CameraTool? openXmlElement)
  {
    return openXmlElement?.CellRange?.Value;
  }

  public static void SetCellRange(CameraTool? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.CellRange = new StringValue { Value = value };
      else
        openXmlElement.CellRange = null;
  }

  /// <summary>
  ///   spid, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetShapeId(CameraTool? openXmlElement)
  {
    return openXmlElement?.ShapeId?.Value;
  }

  public static void SetShapeId(CameraTool? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ShapeId = new StringValue { Value = value };
      else
        openXmlElement.ShapeId = null;
  }

  public static DocumentModel.Drawings.CameraTool? CreateModelElement(CameraTool? openXmlElement)
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
    where OpenXmlElementType : CameraTool, new()
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