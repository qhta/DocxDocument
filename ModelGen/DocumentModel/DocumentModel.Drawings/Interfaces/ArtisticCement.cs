namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ArtisticCement Class.
/// </summary>
public interface ArtisticCement // : System.Boolean
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Transparancy { get ; set; }
  
  /// <summary>
  /// crackSpacing, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? CrackSpacing { get ; set; }
  
}
