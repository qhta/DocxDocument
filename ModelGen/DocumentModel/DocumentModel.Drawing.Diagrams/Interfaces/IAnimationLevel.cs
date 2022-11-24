namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Level Animation.
/// </summary>
public interface IAnimationLevel // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Level Animation Value
  /// </summary>
  public AnimationLevelStringValues? Val { get ; set; }
  
}
