using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentModel.Drawings.Diagram1;
using DocumentModel.Drawings.Diagram2;
using DocumentModel.OpenXml.Drawings.Diagram1;
using DocumentModel.OpenXml.Drawings.Diagram2;

namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
///   Defines the DiagramDefinitionExtension Class.
/// </summary>
public static class DiagramDefinitionExtensionConverter
{
  /// <summary>
  ///   URI
  /// </summary>
  public static String? GetUri(DiagramDefinitionExtension? openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }

  public static void SetUri(DiagramDefinitionExtension? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Uri = new StringValue { Value = value };
      else
        openXmlElement.Uri = null;
  }

  public static NumberDiagramInfoList? GetNumberDiagramInfoList(DiagramDefinitionExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.NumberDiagramInfoList>();
    if (itemElement != null)
      return NumberDiagramInfoListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNumberDiagramInfoList(DiagramDefinitionExtension? openXmlElement, NumberDiagramInfoList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.NumberDiagramInfoList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NumberDiagramInfoListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.NumberDiagramInfoList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TextListStyleType? GetTextListStyleType(DiagramDefinitionExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2019.Drawing.Diagram12.TextListStyleType>();
    if (itemElement != null)
      return TextListStyleTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTextListStyleType(DiagramDefinitionExtension? openXmlElement, TextListStyleType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2019.Drawing.Diagram12.TextListStyleType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextListStyleTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2019.Drawing.Diagram12.TextListStyleType>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Diagrams.DiagramDefinitionExtension? CreateModelElement(DiagramDefinitionExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.DiagramDefinitionExtension();
      value.Uri = GetUri(openXmlElement);
      value.NumberDiagramInfoList = GetNumberDiagramInfoList(openXmlElement);
      value.TextListStyleType = GetTextListStyleType(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.DiagramDefinitionExtension? value)
    where OpenXmlElementType : DiagramDefinitionExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetNumberDiagramInfoList(openXmlElement, value?.NumberDiagramInfoList);
      SetTextListStyleType(openXmlElement, value?.TextListStyleType);
      return openXmlElement;
    }
    return default;
  }
}