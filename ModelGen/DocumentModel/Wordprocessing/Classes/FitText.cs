namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that the contents of this run shall not be automatically displayed based on the width of its contents, rather its contents shall be resized to fit the width specified by the val attribute. This expansion/contraction shall be performed by equally increasing/decreasing the size of each character in this run's contents when displayed.
/// </summary>
public partial class FitText
{
  
  /// <summary>
  ///   Value
  /// </summary>
  public UInt32? Val { get; set; }
  
  
  /// <summary>
  ///   Fit Text Run ID
  /// </summary>
  public Int32? Id { get; set; }
  
}
