namespace DocumentModel.Drawing;

/// <summary>
/// Choose Element.
/// </summary>
public interface IChoose // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Name
  /// </summary>
  public System.String? Name { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IDiagramChooseIf>? DiagramChooseIfs { get ; set; }
  
  public DocumentModel.Drawing.IDiagramChooseElse? DiagramChooseElse { get ; set; }
  
}
