namespace DocumentModel.Drawing.Spreadsheet;

/// <summary>
/// Non-Visual Drawing Properties.
/// </summary>
public interface INonVisualDrawingProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// id
  /// </summary>
  public UInt32? Id { get ; set; }
  
  /// <summary>
  /// name
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// descr
  /// </summary>
  public String? Description { get ; set; }
  
  /// <summary>
  /// hidden
  /// </summary>
  public Boolean? Hidden { get ; set; }
  
  /// <summary>
  /// title
  /// </summary>
  public String? Title { get ; set; }
  
  /// <summary>
  /// HyperlinkOnClick.
  /// </summary>
  public IHyperlinkOnClick? HyperlinkOnClick { get ; set; }
  
  /// <summary>
  /// HyperlinkOnHover.
  /// </summary>
  public IHyperlinkOnHover? HyperlinkOnHover { get ; set; }
  
  /// <summary>
  /// NonVisualDrawingPropertiesExtensionList.
  /// </summary>
  public INonVisualDrawingPropertiesExtensionList? NonVisualDrawingPropertiesExtensionList { get ; set; }
  
}
