namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ScriptLink Class.
/// </summary>
public interface ScriptLink // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// val, this property is only available in Microsoft365 and later.
  /// </summary>
  public String? Val { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
