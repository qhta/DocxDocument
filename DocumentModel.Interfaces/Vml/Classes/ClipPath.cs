namespace DocumentModel.Vml;

/// <summary>
///   Shape Clipping Path.
/// </summary>
public interface ClipPath: IModelElement
{
  /// <summary>
  ///   Path Definition
  /// </summary>
  public string? Value { get; set; }
}