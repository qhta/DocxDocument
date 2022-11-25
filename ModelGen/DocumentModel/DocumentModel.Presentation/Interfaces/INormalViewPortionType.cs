namespace DocumentModel.Presentation;

/// <summary>
/// Defines the NormalViewPortionType Class.
/// </summary>
public interface INormalViewPortionType // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Normal View Dimension Size
  /// </summary>
  public System.Int32? Size { get ; set; }
  
  /// <summary>
  /// Auto Adjust Normal View
  /// </summary>
  public System.Boolean? AutoAdjust { get ; set; }
  
}
