namespace DocumentModel.Spreadsheet;

/// <summary>
/// Range Set.
/// </summary>
public interface IRangeSet // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Field Item Index Page 1
  /// </summary>
  public UInt32? FieldItemIndexPage1 { get ; set; }
  
  /// <summary>
  /// Field Item Index Page 2
  /// </summary>
  public UInt32? FieldItemIndexPage2 { get ; set; }
  
  /// <summary>
  /// Field Item index Page 3
  /// </summary>
  public UInt32? FieldItemIndexPage3 { get ; set; }
  
  /// <summary>
  /// Field Item Index Page 4
  /// </summary>
  public UInt32? FieldItemIndexPage4 { get ; set; }
  
  /// <summary>
  /// Reference
  /// </summary>
  public String? Reference { get ; set; }
  
  /// <summary>
  /// Named Range
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// Sheet Name
  /// </summary>
  public String? Sheet { get ; set; }
  
  /// <summary>
  /// Relationship Id
  /// </summary>
  public String? Id { get ; set; }
  
}
