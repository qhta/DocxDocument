namespace DocumentModel.Wordprocessing;

/// <summary>
/// Single Automatic Captioning Setting.
/// </summary>
public interface IAutoCaption // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Identifier of Object to be Automatically Captioned
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// Caption Used for Automatic Captioning
  /// </summary>
  public System.String? Caption { get ; set; }
  
}
