namespace DocumentModel.Drawings;

/// <summary>
///   Defines the BiLevel interface.
/// </summary>
public interface BiLevel: IModelElement
{
  /// <summary>
  ///   Threshold
  /// </summary>
  public Int32? Threshold { get; set; }
}