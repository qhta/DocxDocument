namespace DocumentModel.Drawings;

/// <summary>
/// Shape.
/// </summary>
public interface Shape2
{
  /// <summary>
  /// Shape Adjust List.
  /// </summary>
  public AdjustList? AdjustList { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList3? ExtensionList { get ; set; }
  
}
