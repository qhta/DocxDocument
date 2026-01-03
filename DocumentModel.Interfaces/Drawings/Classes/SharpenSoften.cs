namespace DocumentModel.Drawings;

/// <summary>
///   Defines the SharpenSoften interface.
/// </summary>
public interface SharpenSoften: IModelElement
{
  /// <summary>
  ///   amount
  /// </summary>
  public Int32? Amount { get; set; }
}