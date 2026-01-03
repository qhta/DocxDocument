namespace DocumentModel.Drawings;

/// <summary>
///   Defines the SharpenSoften interface.
/// </summary>
public interface SharpenSoften: IModelElement
{
  /// <summary>
  ///   amount, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Amount { get; set; }
}