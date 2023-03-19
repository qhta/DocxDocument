namespace DocumentModel.Drawings;

/// <summary>
///   Linear Gradient Fill.
/// </summary>
public class LinearGradientFill: ModelElement
{
  /// <summary>
  ///   Angle
  /// </summary>
  public Int32? Angle { get; set; }

  /// <summary>
  ///   Scaled
  /// </summary>
  [DefaultValue(false)] 
  public Boolean Scaled { get; set; }
}