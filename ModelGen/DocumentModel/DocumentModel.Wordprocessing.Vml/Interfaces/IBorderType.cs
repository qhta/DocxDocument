namespace DocumentModel.Wordprocessing.Vml;

/// <summary>
/// Defines the BorderType Class.
/// </summary>
public interface IBorderType // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Border Style
  /// </summary>
  public DocumentModel.Wordprocessing.Vml.BorderKind? Type { get ; set; }
  
  /// <summary>
  /// Border Width
  /// </summary>
  public System.Int32? Width { get ; set; }
  
  /// <summary>
  /// Border shadow
  /// </summary>
  public System.Boolean? Shadow { get ; set; }
  
}
