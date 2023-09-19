namespace DocumentModel.Vml.Office;


/// <summary>
///   Shape Grouping History.
/// </summary>
public partial class RegroupTable
{
  
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  [Nullable((Byte)2)]
  [SchemaAttr("v:ext")]
  public DocumentModel.Vml.ExtensionHandlingBehaviorValues? Extension { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.Vml.Office.Entry>? Items { get; set; }
  
}
