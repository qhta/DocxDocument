namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Rule.
/// </summary>
public partial class Rule
{
  
  /// <summary>
  ///   For Name
  /// </summary>
  public String? ForName { get; set; }
  
  
  /// <summary>
  ///   Value
  /// </summary>
  public Double? Val { get; set; }
  
  
  /// <summary>
  ///   Factor
  /// </summary>
  public Double? Fact { get; set; }
  
  
  /// <summary>
  ///   Max Value
  /// </summary>
  public Double? Max { get; set; }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public DMDD.ExtensionList? ExtensionList { get; set; }
  
}
