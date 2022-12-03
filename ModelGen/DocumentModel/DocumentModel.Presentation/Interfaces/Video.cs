namespace DocumentModel.Presentation;

/// <summary>
/// Video.
/// </summary>
public interface Video // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Full Screen
  /// </summary>
  public Boolean? FullScreen { get ; set; }
  
  /// <summary>
  /// Common Media Node Properties.
  /// </summary>
  public CommonMediaNode? CommonMediaNode { get ; set; }
  
}
