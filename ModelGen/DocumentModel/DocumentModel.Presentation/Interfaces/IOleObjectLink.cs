namespace DocumentModel.Presentation;

/// <summary>
/// Defines the OleObjectLink Class.
/// </summary>
public interface IOleObjectLink // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Update Linked OLE Objects Automatically
  /// </summary>
  public Boolean? AutoUpdate { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
