namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the TickLabels Class.
/// </summary>
public interface TickLabels: IModelElement
{
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}