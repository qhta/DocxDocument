namespace DocumentModel.Wordprocessing;

/// <summary>
/// Single Automatic Captioning Setting.
/// </summary>
public interface IAutoCaption // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Identifier of Object to be Automatically Captioned
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// Caption Used for Automatic Captioning
  /// </summary>
  public String? Caption { get ; set; }
  
}
