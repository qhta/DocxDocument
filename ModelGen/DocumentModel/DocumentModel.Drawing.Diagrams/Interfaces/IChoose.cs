namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Choose Element.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IDiagramChooseElse))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IDiagramChooseIf))]
public interface IChoose // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Name
  /// </summary>
  public string? Name { get ; set; }
  
}
