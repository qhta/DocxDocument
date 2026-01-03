namespace DocumentModel.Drawings;

/// <summary>
///   Defines the Saturation interface.
/// </summary>
public interface Saturation2: IModelElement
{
  /// <summary>
  ///   sat, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? SaturationAmount { get; set; }
}