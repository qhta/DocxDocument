namespace DocumentModel.Drawing.Spreadsheet;

/// <summary>
/// Non-Visual Drawing Properties.
/// </summary>
public interface INonVisualDrawingProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// id
  /// </summary>
  public System.UInt32? Id { get ; set; }
  
  /// <summary>
  /// name
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// descr
  /// </summary>
  public System.String? Description { get ; set; }
  
  /// <summary>
  /// hidden
  /// </summary>
  public System.Boolean? Hidden { get ; set; }
  
  /// <summary>
  /// title
  /// </summary>
  public System.String? Title { get ; set; }
  
  /// <summary>
  /// HyperlinkOnClick.
  /// </summary>
  public DocumentModel.Drawing.IHyperlinkOnClick? HyperlinkOnClick { get ; set; }
  
  /// <summary>
  /// HyperlinkOnHover.
  /// </summary>
  public DocumentModel.Drawing.IHyperlinkOnHover? HyperlinkOnHover { get ; set; }
  
  /// <summary>
  /// NonVisualDrawingPropertiesExtensionList.
  /// </summary>
  public DocumentModel.Drawing.INonVisualDrawingPropertiesExtensionList? NonVisualDrawingPropertiesExtensionList { get ; set; }
  
}
