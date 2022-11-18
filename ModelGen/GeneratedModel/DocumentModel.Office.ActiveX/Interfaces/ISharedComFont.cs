namespace DocumentModel.Office.ActiveX;

/// <summary>
/// Defines the SharedComFont Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office.ActiveX.IActiveXObjectProperty))]
public interface ISharedComFont // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// persistence
  /// </summary>
  public Persistence? Persistence { get ; set; }
  
  /// <summary>
  /// id
  /// </summary>
  public string? Id { get ; set; }
  
}
