namespace DocumentModel.Drawing;

/// <summary>
/// Normal AutoFit.
/// </summary>
public class NormalAutoFit: INormalAutoFit
{
  /// <summary>
  /// Font Scale
  /// </summary>
  public int? FontScale
  {
    get;
    set;
  }
  
  /// <summary>
  /// Line Space Reduction
  /// </summary>
  public int? LineSpaceReduction
  {
    get;
    set;
  }
  
}
