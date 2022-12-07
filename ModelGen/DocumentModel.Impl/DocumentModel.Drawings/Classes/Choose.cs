namespace DocumentModel.Drawings;

/// <summary>
/// Choose Element.
/// </summary>
public class ChooseImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Diagrams.Choose>, Choose
{
  public DiagramChooseElse? DiagramChooseElse
  {
    get;
    set;
  }
  
}
