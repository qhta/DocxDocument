namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Columns Class.
/// </summary>
public interface Columns
{
  /// <summary>
  /// Equal Column Widths
  /// </summary>
  public Boolean? EqualWidth { get ; set; }
  
  /// <summary>
  /// Spacing Between Equal Width Columns
  /// </summary>
  public String? Space { get ; set; }
  
  /// <summary>
  /// Number of Equal Width Columns
  /// </summary>
  public Int16? ColumnCount { get ; set; }
  
  /// <summary>
  /// Draw Line Between Columns
  /// </summary>
  public Boolean? Separator { get ; set; }
  
  public Column? Column { get ; set; }
  
}
