namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document.
/// </summary>
public interface IDocument // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// conformance
  /// </summary>
  public DocumentModel.Wordprocessing.DocumentConformance? Conformance { get ; set; }
  
  /// <summary>
  /// Document Background.
  /// </summary>
  public DocumentModel.Wordprocessing.IDocumentBackground? DocumentBackground { get ; set; }
  
  /// <summary>
  /// Body.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? Body { get ; set; }
  
}
