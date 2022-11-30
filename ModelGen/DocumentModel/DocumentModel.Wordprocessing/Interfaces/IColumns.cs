namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Columns Class.
/// </summary>
public interface IColumns // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Equal Column Widths
  /// </summary>
  public System.Boolean? EqualWidth { get ; set; }
  
  /// <summary>
  /// Spacing Between Equal Width Columns
  /// </summary>
  public System.String? Space { get ; set; }
  
  /// <summary>
  /// Number of Equal Width Columns
  /// </summary>
  public System.Int16? ColumnCount { get ; set; }
  
  /// <summary>
  /// Draw Line Between Columns
  /// </summary>
  public System.Boolean? Separator { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.IColumn>? Columns { get ; set; }
  
}
