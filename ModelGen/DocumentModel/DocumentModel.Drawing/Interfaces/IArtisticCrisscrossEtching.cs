namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ArtisticCrisscrossEtching Class.
/// </summary>
public interface IArtisticCrisscrossEtching // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int32? Transparancy { get ; set; }
  
  /// <summary>
  /// pressure, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int32? Pressure { get ; set; }
  
}
