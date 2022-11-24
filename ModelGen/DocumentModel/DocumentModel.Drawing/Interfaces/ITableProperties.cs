namespace DocumentModel.Drawing;

/// <summary>
/// Table Properties.
/// </summary>
public interface ITableProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Right-to-Left
  /// </summary>
  public Boolean? RightToLeft { get ; set; }
  
  /// <summary>
  /// First Row
  /// </summary>
  public Boolean? FirstRow { get ; set; }
  
  /// <summary>
  /// First Column
  /// </summary>
  public Boolean? FirstColumn { get ; set; }
  
  /// <summary>
  /// Last Row
  /// </summary>
  public Boolean? LastRow { get ; set; }
  
  /// <summary>
  /// Last Column
  /// </summary>
  public Boolean? LastColumn { get ; set; }
  
  /// <summary>
  /// Banded Rows
  /// </summary>
  public Boolean? BandRow { get ; set; }
  
  /// <summary>
  /// Banded Columns
  /// </summary>
  public Boolean? BandColumn { get ; set; }
  
}
