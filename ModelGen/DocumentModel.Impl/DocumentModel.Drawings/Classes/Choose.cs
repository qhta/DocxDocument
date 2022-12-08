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
  
  /// <summary>
  /// Name
  /// </summary>
  public String? Name
  {
    get;
    set;
  }
  
  public Collection<DiagramChooseIf>? DiagramChooseIfs
  {
    get;
    set;
  }
  
  public DiagramChooseElse? DiagramChooseElse
  {
    get;
    set;
  }
  
}
