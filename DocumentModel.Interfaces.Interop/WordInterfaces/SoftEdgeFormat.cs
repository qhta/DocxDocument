namespace DocumentModel.Interop;

/// <summary>
/// Represents the soft edge formatting for a shape or range of shapes.
/// </summary>
public interface SoftEdgeFormat : InteropObject
{
  /// <summary>
  /// The type.
  /// </summary>
  //public Core.MsoSoftEdgeType Type { get; set; }
  /// <summary>
  /// The radius.
  /// </summary>
  public float Radius { get; set; }

}
