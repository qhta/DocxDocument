namespace DocumentModel.Drawing;

/// <summary>
/// Choose Element.
/// </summary>
public interface IChoose // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Name
  /// </summary>
  public String? Name { get ; set; }
  
  public Collection<IDiagramChooseIf>? DiagramChooseIfs { get ; set; }
  
  public IDiagramChooseElse? DiagramChooseElse { get ; set; }
  
}
