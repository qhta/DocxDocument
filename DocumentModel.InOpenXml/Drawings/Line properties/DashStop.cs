namespace DocumentModel.Drawings;

/// <summary>
///   Represents a stop in a custom dash pattern, defining the length of a dash and the following space.
/// </summary>
public interface DashStop: ICollectionItem
{
  /// <summary>
  ///   Length of the dash segment.
  /// </summary>
  public Int32? DashLength { get; set; }

  /// <summary>
  ///   Length of the space segment following the dash.
  /// </summary>
  public Int32? SpaceLength { get; set; }
}