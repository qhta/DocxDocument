namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Level Animation.
/// </summary>
public interface IAnimationLevel // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Level Animation Value
  /// </summary>
  public AnimationLevelString? Val { get ; set; }
  
}
