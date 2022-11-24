namespace DocumentModel.Office2010.Drawing;

/// <summary>
/// Defines the ArtisticPhotocopy Class.
/// </summary>
public interface IArtisticPhotocopy // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Transparancy { get ; set; }
  
  /// <summary>
  /// detail, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Detail { get ; set; }
  
}
