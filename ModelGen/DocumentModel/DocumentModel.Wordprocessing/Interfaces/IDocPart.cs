namespace DocumentModel.Wordprocessing;

/// <summary>
/// Glossary Document Entry.
/// </summary>
public interface IDocPart // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Glossary Document Entry Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.IDocPartProperties? DocPartProperties { get ; set; }
  
  /// <summary>
  /// Contents of Glossary Document Entry.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? DocPartBody { get ; set; }
  
}
