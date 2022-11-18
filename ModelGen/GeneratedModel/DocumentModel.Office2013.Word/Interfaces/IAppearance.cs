namespace DocumentModel.Office2013.Word;

/// <summary>
/// Defines the Appearance Class.
/// </summary>
public interface IAppearance // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// val, this property is only available in Office 2013 and later.
  /// </summary>
  public SdtAppearance? Val { get ; set; }
  
}
