namespace DocumentModel.Drawing;

/// <summary>
/// Text Line Break.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IRunProperties))]
public interface IBreak // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Text Run Properties.
  /// </summary>
  public DocumentModel.Drawing.IRunProperties? RunProperties { get ; set; }
  
}
