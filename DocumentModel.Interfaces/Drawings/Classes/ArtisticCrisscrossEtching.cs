namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ArtisticCrisscrossEtching interface.
/// </summary>
public interface ArtisticCrisscrossEtching: IModelElement
{
  /// <summary>
  ///   trans, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Transparancy { get; set; }
  /// <summary>
  ///   pressure, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Pressure { get; set; }
}