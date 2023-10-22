namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Constraint.
/// </summary>
public partial class Constraint
{
  
  /// <summary>
  ///   For Name
  /// </summary>
  public String? ForName { get; set; }
  
  
  /// <summary>
  ///   Reference For Name
  /// </summary>
  public String? ReferenceForName { get; set; }
  
  
  /// <summary>
  ///   Value
  /// </summary>
  public Double? Val { get; set; }
  
  
  /// <summary>
  ///   Factor
  /// </summary>
  public Double? Fact { get; set; }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.Diagrams.ExtensionList? ExtensionList { get; set; }
  
}
