namespace DocumentModel.Drawings;

/// <summary>
///   Miter Line Join.
/// </summary>
public interface Miter: IModelElement
{
  /// <summary>
  ///   Miter Join Limit
  /// </summary>
  public Int32? Limit { get; set; }
}