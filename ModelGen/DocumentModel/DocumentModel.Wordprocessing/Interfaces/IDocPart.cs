namespace DocumentModel.Wordprocessing;

/// <summary>
/// Glossary Document Entry.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDocPartBody))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDocPartProperties))]
public interface IDocPart // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Glossary Document Entry Properties.
  /// </summary>
  public IDocPartProperties? DocPartProperties { get ; set; }
  
  /// <summary>
  /// Contents of Glossary Document Entry.
  /// </summary>
  public IDocPartBody? DocPartBody { get ; set; }
  
}
