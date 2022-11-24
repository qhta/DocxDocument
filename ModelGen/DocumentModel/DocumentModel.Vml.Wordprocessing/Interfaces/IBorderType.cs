namespace DocumentModel.Vml.Wordprocessing;

/// <summary>
/// Defines the BorderType Class.
/// </summary>
public interface IBorderType // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Border Style
  /// </summary>
  public BorderValues? Type { get ; set; }
  
  /// <summary>
  /// Border Width
  /// </summary>
  public Int32? Width { get ; set; }
  
  /// <summary>
  /// Border shadow
  /// </summary>
  public ITrueFalseValue? Shadow { get ; set; }
  
}
