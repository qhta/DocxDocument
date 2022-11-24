namespace DocumentModel.Office.Drawing.Y2021.ScriptLink;

/// <summary>
/// Defines the ScriptLink Class.
/// </summary>
public interface IScriptLink // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// val, this property is only available in Microsoft365 and later.
  /// </summary>
  public String? Val { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
