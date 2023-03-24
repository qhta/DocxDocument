namespace DocumentModel.Vml;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the TextPath Class.
/// </summary>
public class TextPath: ModelElement
{
  /// <summary>
  ///   Unique Identifier
  /// </summary>
  public String? Id { get; set; }

  /// <summary>
  ///   Shape Styling Properties
  /// </summary>
  public String? Style { get; set; }

  /// <summary>
  ///   Text Path Toggle
  /// </summary>
  public Boolean? On { get; set; }

  /// <summary>
  ///   Shape Fit Toggle
  /// </summary>
  public Boolean? FitShape { get; set; }

  /// <summary>
  ///   Path Fit Toggle
  /// </summary>
  public Boolean? FitPath { get; set; }

  /// <summary>
  ///   Text Path Trim Toggle
  /// </summary>
  public Boolean? Trim { get; set; }

  /// <summary>
  ///   Text X-Scaling
  /// </summary>
  public Boolean? XScale { get; set; }

  /// <summary>
  ///   Text Path Text
  /// </summary>
  public String? String { get; set; }
}