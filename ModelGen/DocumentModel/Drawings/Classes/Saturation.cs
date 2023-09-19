namespace DocumentModel.Drawings;


/// <summary>
///   Defines the Saturation Class.
/// </summary>
public partial class Saturation
{
  
  /// <summary>
  ///   sat, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("sat")]
  public Int32? SaturationAmount { get; set; }
  
}
