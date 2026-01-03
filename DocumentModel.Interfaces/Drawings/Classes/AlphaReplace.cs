namespace DocumentModel.Drawings;

/// <summary>
///   Alpha Replace Effect.
/// </summary>
public interface AlphaReplace: IModelElement
{
  /// <summary>
  ///   Alpha
  /// </summary>
  public Int32? Alpha { get; set; }
}