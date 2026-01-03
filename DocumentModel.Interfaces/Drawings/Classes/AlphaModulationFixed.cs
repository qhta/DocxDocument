namespace DocumentModel.Drawings;

/// <summary>
///   Defines the AlphaModulationFixed interface.
/// </summary>
public interface AlphaModulationFixed: IModelElement
{
  /// <summary>
  ///   Amount
  /// </summary>
  public Int32? Amount { get; set; }
}