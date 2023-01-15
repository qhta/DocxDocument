using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the MajorTickMarksTickMarks Class.
/// </summary>
public static class MajorTickMarksTickMarksConverter
{
  public static DocumentModel.Drawings.ChartDrawings.ExtensionList? GetExtensionList(MajorTickMarksTickMarks? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(MajorTickMarksTickMarks? openXmlElement, DocumentModel.Drawings.ChartDrawings.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ChartDrawings.MajorTickMarksTickMarks? CreateModelElement(MajorTickMarksTickMarks? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.MajorTickMarksTickMarks();
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.MajorTickMarksTickMarks? value)
    where OpenXmlElementType : MajorTickMarksTickMarks, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}