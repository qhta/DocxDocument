namespace DocumentModel.Office2019.Drawing.Animation.Model3D;

/// <summary>
/// Defines the PosterFrame Class.
/// </summary>
public class PosterFrame: IPosterFrame
{
  /// <summary>
  /// animId, this property is only available in Office 2019 and later.
  /// </summary>
  public uint? AnimId
  {
    get;
    set;
  }
  
  /// <summary>
  /// frame, this property is only available in Office 2019 and later.
  /// </summary>
  public int? Frame
  {
    get;
    set;
  }
  
}
