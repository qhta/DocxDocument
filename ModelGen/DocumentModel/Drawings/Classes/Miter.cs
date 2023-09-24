namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies that a line join shall be mitered.
/// </summary>
public partial class Miter
{
  
  /// <summary>
  ///   Specifies the amount by which lines is extended to form a miter join - otherwise miter
  /// </summary>
  public Int32? Limit { get; set; }
  
}
