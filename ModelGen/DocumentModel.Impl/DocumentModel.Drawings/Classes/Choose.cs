namespace DocumentModel.Drawings;

/// <summary>
/// Choose Element.
/// </summary>
public class ChooseImpl: ModelElementImpl, Choose
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.Choose? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.Choose?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ChooseImpl(): base() {}
  
  public ChooseImpl(DocumentFormat.OpenXml.Drawing.Diagrams.Choose openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Name
  /// </summary>
  public String? Name
  {
    get => (String?)OpenXmlElement?.Name?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Name = (System.String?)value;
    }
  }
  
  public DiagramChooseIf? DiagramChooseIf
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DiagramChooseElse? DiagramChooseElse
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
