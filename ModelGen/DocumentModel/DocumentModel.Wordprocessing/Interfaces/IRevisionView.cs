namespace DocumentModel.Wordprocessing;

/// <summary>
/// Visibility of Annotation Types.
/// </summary>
public interface IRevisionView // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Display Visual Indicator Of Markup Area
  /// </summary>
  public System.Boolean? Markup { get ; set; }
  
  /// <summary>
  /// Display Comments
  /// </summary>
  public System.Boolean? Comments { get ; set; }
  
  /// <summary>
  /// Display Content Revisions
  /// </summary>
  public System.Boolean? DisplayRevision { get ; set; }
  
  /// <summary>
  /// Display Formatting Revisions
  /// </summary>
  public System.Boolean? Formatting { get ; set; }
  
  /// <summary>
  /// Display Ink Annotations
  /// </summary>
  public System.Boolean? InkAnnotations { get ; set; }
  
}
