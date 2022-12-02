namespace DocumentModel.Presentation;

/// <summary>
/// Defines the Iterate Class.
/// </summary>
public interface IIterate // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Iterate Type
  /// </summary>
  public IterateKind? Type { get ; set; }
  
  /// <summary>
  /// Backwards
  /// </summary>
  public Boolean? Backwards { get ; set; }
  
  /// <summary>
  /// Time Absolute.
  /// </summary>
  public String? TimeAbsolute { get ; set; }
  
  /// <summary>
  /// Time Percentage.
  /// </summary>
  public Int32? TimePercentage { get ; set; }
  
}
