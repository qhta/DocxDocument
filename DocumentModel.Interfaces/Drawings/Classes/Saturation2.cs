namespace DocumentModel.Drawings;

/// <summary>
///   Defines the Saturation interface.
/// </summary>
public interface Saturation2: IModelElement
{
  /// <summary>
  ///   sat
  /// </summary>
  public Int32? SaturationAmount { get; set; }
}