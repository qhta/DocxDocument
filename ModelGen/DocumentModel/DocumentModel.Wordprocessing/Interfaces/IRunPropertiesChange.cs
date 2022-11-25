namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the RunPropertiesChange Class.
/// </summary>
public interface IRunPropertiesChange // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// author
  /// </summary>
  public System.String? Author { get ; set; }
  
  /// <summary>
  /// date
  /// </summary>
  public System.DateTime? Date { get ; set; }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// Previous Run Properties.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? PreviousRunProperties { get ; set; }
  
}
