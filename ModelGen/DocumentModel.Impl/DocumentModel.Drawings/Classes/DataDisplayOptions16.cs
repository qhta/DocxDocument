namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DataDisplayOptions16 Class.
/// </summary>
public class DataDisplayOptions16Impl: ModelElementImpl, DataDisplayOptions16
{
  public DocumentFormat.OpenXml.Drawing.Charts.DataDisplayOptions16? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.DataDisplayOptions16?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// BooleanFalse.
  /// </summary>
  public Boolean? BooleanFalse
  {
    get;
    set;
  }
  
}
