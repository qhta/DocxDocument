namespace DocumentModel.Drawings;

/// <summary>
/// Number Format.
/// </summary>
public interface NumberingFormat1
{
  /// <summary>
  /// Number Format Code
  /// </summary>
  public String? FormatCode { get ; set; }
  
  /// <summary>
  /// Linked to Source
  /// </summary>
  public Boolean? SourceLinked { get ; set; }
  
}
