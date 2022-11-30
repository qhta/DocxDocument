namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Choose Element.
/// </summary>
public interface IChoose // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Name
  /// </summary>
  public System.String? Name { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Diagrams.IDiagramChooseIf>? DiagramChooseIfs { get ; set; }
  
  public DocumentModel.Drawing.Diagrams.IDiagramChooseElse? DiagramChooseElse { get ; set; }
  
}
