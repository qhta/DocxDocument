namespace DocumentModel.Drawing;

/// <summary>
/// Normal AutoFit.
/// </summary>
public interface INormalAutoFit // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Font Scale
  /// </summary>
  public System.Int32? FontScale { get ; set; }
  
  /// <summary>
  /// Line Space Reduction
  /// </summary>
  public System.Int32? LineSpaceReduction { get ; set; }
  
}
