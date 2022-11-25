namespace DocumentModel.Drawing;

/// <summary>
/// Table Properties.
/// </summary>
public interface ITableProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Right-to-Left
  /// </summary>
  public System.Boolean? RightToLeft { get ; set; }
  
  /// <summary>
  /// First Row
  /// </summary>
  public System.Boolean? FirstRow { get ; set; }
  
  /// <summary>
  /// First Column
  /// </summary>
  public System.Boolean? FirstColumn { get ; set; }
  
  /// <summary>
  /// Last Row
  /// </summary>
  public System.Boolean? LastRow { get ; set; }
  
  /// <summary>
  /// Last Column
  /// </summary>
  public System.Boolean? LastColumn { get ; set; }
  
  /// <summary>
  /// Banded Rows
  /// </summary>
  public System.Boolean? BandRow { get ; set; }
  
  /// <summary>
  /// Banded Columns
  /// </summary>
  public System.Boolean? BandColumn { get ; set; }
  
}
