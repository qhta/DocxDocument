namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document.
/// </summary>
public interface IDocument // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// conformance
  /// </summary>
  public DocumentConformance? Conformance { get ; set; }
  
  /// <summary>
  /// Document Background.
  /// </summary>
  public IDocumentBackground? DocumentBackground { get ; set; }
  
  /// <summary>
  /// Body.
  /// </summary>
  public IBody? Body { get ; set; }
  
}
