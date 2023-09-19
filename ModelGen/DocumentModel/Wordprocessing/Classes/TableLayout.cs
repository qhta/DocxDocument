namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the algorithm which shall be used to lay out the contents of this table within the document. When a table is displayed in a document, it can either be displayed using a fixed width or autofit layout algorithm (each discussed in the simple type referenced by the val attribute).
/// </summary>
public partial class TableLayout
{
  
  /// <summary>
  ///   Table Layout Setting
  /// </summary>
  [SchemaAttr("w:type")]
  public DocumentModel.Wordprocessing.TableLayoutValues? Type { get; set; }
  
}
