namespace DocumentModel.Drawings;

/// <summary>
///   Defines the TintEffect interface.
/// </summary>
public interface TintEffect: IModelElement
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