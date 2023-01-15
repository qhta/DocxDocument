using DocumentFormat.OpenXml.Math;
using DocumentModel.Math;
using MatrixColumnProperties = DocumentFormat.OpenXml.Math.MatrixColumnProperties;

namespace DocumentModel.OpenXml.Math;

/// <summary>
///   Matrix Column Properties.
/// </summary>
public static class MatrixColumnPropertiesConverter
{
  /// <summary>
  ///   Matrix Column Count.
  /// </summary>
  public static Int64? GetMatrixColumnCount(MatrixColumnProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<MatrixColumnCount>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetMatrixColumnCount(MatrixColumnProperties? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MatrixColumnCount>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new MatrixColumnCount { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Matrix Column Justification.
  /// </summary>
  public static HorizontalAlignmentKind? GetMatrixColumnJustification(MatrixColumnProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MatrixColumnJustification>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<HorizontalAlignmentValues, HorizontalAlignmentKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetMatrixColumnJustification(MatrixColumnProperties? openXmlElement, HorizontalAlignmentKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MatrixColumnJustification>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<MatrixColumnJustification, HorizontalAlignmentValues, HorizontalAlignmentKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Math.MatrixColumnProperties? CreateModelElement(MatrixColumnProperties? openXmlElement)
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
    where OpenXmlElementType : MatrixColumnProperties, new()
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