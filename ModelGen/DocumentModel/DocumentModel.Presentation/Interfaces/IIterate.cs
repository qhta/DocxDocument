namespace DocumentModel.Presentation;

/// <summary>
/// Defines the Iterate Class.
/// </summary>
public interface IIterate // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Iterate Type
  /// </summary>
  public DocumentModel.Presentation.IterateKind? Type { get ; set; }
  
  /// <summary>
  /// Backwards
  /// </summary>
  public System.Boolean? Backwards { get ; set; }
  
  /// <summary>
  /// Time Absolute.
  /// </summary>
  public System.String? TimeAbsolute { get ; set; }
  
  /// <summary>
  /// Time Percentage.
  /// </summary>
  public System.Int32? TimePercentage { get ; set; }
  
}
