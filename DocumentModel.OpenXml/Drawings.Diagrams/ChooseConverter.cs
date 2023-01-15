using DocumentFormat.OpenXml.Drawing.Diagrams;
using DiagramChooseElse = DocumentModel.Drawings.Diagrams.DiagramChooseElse;
using DiagramChooseIf = DocumentModel.Drawings.Diagrams.DiagramChooseIf;

namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
///   Choose Element.
/// </summary>
public static class ChooseConverter
{
  /// <summary>
  ///   Name
  /// </summary>
  public static String? GetName(Choose? openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }

  public static void SetName(Choose? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Name = new StringValue { Value = value };
      else
        openXmlElement.Name = null;
  }

  public static DiagramChooseIf? GetDiagramChooseIf(Choose? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf>();
    if (itemElement != null)
      return DiagramChooseIfConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDiagramChooseIf(Choose? openXmlElement, DiagramChooseIf? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DiagramChooseIfConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DiagramChooseElse? GetDiagramChooseElse(Choose? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseElse>();
    if (itemElement != null)
      return DiagramChooseElseConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDiagramChooseElse(Choose? openXmlElement, DiagramChooseElse? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseElse>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DiagramChooseElseConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseElse>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Diagrams.Choose? CreateModelElement(Choose? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.Choose();
      value.Name = GetName(openXmlElement);
      value.DiagramChooseIf = GetDiagramChooseIf(openXmlElement);
      value.DiagramChooseElse = GetDiagramChooseElse(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.Choose? value)
    where OpenXmlElementType : Choose, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetName(openXmlElement, value?.Name);
      SetDiagramChooseIf(openXmlElement, value?.DiagramChooseIf);
      SetDiagramChooseElse(openXmlElement, value?.DiagramChooseElse);
      return openXmlElement;
    }
    return default;
  }
}