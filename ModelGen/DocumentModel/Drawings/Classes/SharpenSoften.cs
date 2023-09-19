namespace DocumentModel.Drawings;


/// <summary>
///   Defines the SharpenSoften Class.
/// </summary>
public partial class SharpenSoften
{
  
  /// <summary>
  ///   amount, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("amount")]
  public Int32? Amount { get; set; }
  
}
