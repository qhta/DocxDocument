namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the TintEffect Class.
/// </summary>
public class TintEffect: ModelElement
{
  /// <summary>
  ///   Hue
  /// </summary>
  public Int32? Hue { get; set; }

  /// <summary>
  ///   Amount
  /// </summary>
  public Int32? Amount { get; set; }
}