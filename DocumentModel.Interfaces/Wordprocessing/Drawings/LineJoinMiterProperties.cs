namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the LineJoinMiterProperties Class.
/// </summary>
public interface LineJoinMiterProperties: IModelElement
{
  /// <summary>
  ///   lim
  /// </summary>
  public Int32? Limit { get; set; }
}