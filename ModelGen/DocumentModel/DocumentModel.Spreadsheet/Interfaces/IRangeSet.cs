namespace DocumentModel.Spreadsheet;

/// <summary>
/// Range Set.
/// </summary>
public interface IRangeSet // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Field Item Index Page 1
  /// </summary>
  public System.UInt32? FieldItemIndexPage1 { get ; set; }
  
  /// <summary>
  /// Field Item Index Page 2
  /// </summary>
  public System.UInt32? FieldItemIndexPage2 { get ; set; }
  
  /// <summary>
  /// Field Item index Page 3
  /// </summary>
  public System.UInt32? FieldItemIndexPage3 { get ; set; }
  
  /// <summary>
  /// Field Item Index Page 4
  /// </summary>
  public System.UInt32? FieldItemIndexPage4 { get ; set; }
  
  /// <summary>
  /// Reference
  /// </summary>
  public System.String? Reference { get ; set; }
  
  /// <summary>
  /// Named Range
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// Sheet Name
  /// </summary>
  public System.String? Sheet { get ; set; }
  
  /// <summary>
  /// Relationship Id
  /// </summary>
  public System.String? Id { get ; set; }
  
}
