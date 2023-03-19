namespace DocumentModel.Drawings;

/// <summary>
///   Miter Line Join.
/// </summary>
public class Miter: ModelElement
{
  /// <summary>
  ///   Miter Join Limit
  /// </summary>
  public Int32? Limit { get; set; }
}