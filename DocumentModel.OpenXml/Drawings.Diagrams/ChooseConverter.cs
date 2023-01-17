namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Choose Element.
/// </summary>
public static class ChooseConverter
{
  /// <summary>
  /// Name
  /// </summary>
  private static String? GetName(DocumentFormat.OpenXml.Drawing.Diagrams.Choose openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  private static void SetName(DocumentFormat.OpenXml.Drawing.Diagrams.Choose openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Name = new StringValue { Value = value };
    else
      openXmlElement.Name = null;
  }
  
  private static DocumentModel.Drawings.Diagrams.DiagramChooseIf? GetDiagramChooseIf(DocumentFormat.OpenXml.Drawing.Diagrams.Choose openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.DiagramChooseIfConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDiagramChooseIf(DocumentFormat.OpenXml.Drawing.Diagrams.Choose openXmlElement, DocumentModel.Drawings.Diagrams.DiagramChooseIf? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Diagrams.DiagramChooseIfConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Diagrams.DiagramChooseElse? GetDiagramChooseElse(DocumentFormat.OpenXml.Drawing.Diagrams.Choose openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseElse>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.DiagramChooseElseConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDiagramChooseElse(DocumentFormat.OpenXml.Drawing.Diagrams.Choose openXmlElement, DocumentModel.Drawings.Diagrams.DiagramChooseElse? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseElse>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Diagrams.DiagramChooseElseConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseElse>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.Choose? CreateModelElement(DocumentFormat.OpenXml.Drawing.Diagrams.Choose? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Diagrams.Choose, new()
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
