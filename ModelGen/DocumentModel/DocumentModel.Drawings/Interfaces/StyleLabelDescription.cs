namespace DocumentModel.Drawings;

/// <summary>
/// Style Label Description.
/// </summary>
public interface StyleLabelDescription // : System.Boolean
{
  /// <summary>
  /// Natural Language
  /// </summary>
  public String? Language { get ; set; }
  
  /// <summary>
  /// Description Value
  /// </summary>
  public String? Val { get ; set; }
  
}
