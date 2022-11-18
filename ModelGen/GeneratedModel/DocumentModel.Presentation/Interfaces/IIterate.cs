namespace DocumentModel.Presentation;

/// <summary>
/// Defines the Iterate Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.ITimePercentage))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ITimeAbsolute))]
public interface IIterate // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Iterate Type
  /// </summary>
  public Iterate? Type { get ; set; }
  
  /// <summary>
  /// Backwards
  /// </summary>
  public bool? Backwards { get ; set; }
  
  /// <summary>
  /// Time Absolute.
  /// </summary>
  public ITimeAbsolute? TimeAbsolute { get ; set; }
  
  /// <summary>
  /// Time Percentage.
  /// </summary>
  public ITimePercentage? TimePercentage { get ; set; }
  
}
