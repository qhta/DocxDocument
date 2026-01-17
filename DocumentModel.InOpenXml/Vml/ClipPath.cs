namespace DocumentModel.Vml;

/// <summary>
///   Shape Clipping Path.
/// </summary>
public class ClipPath: ModelElement<DXVO.ClipPath>
{
  /// <summary>
  ///   Path Definition
  /// </summary>
  public string? Value { get; set; }
}