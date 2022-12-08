namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Saturation Class.
/// </summary>
public class Saturation1Impl: ModelElementImpl, Saturation1
{
  public DocumentFormat.OpenXml.Office2010.Drawing.Saturation? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.Saturation?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// sat, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? SaturationAmount
  {
    get;
    set;
  }
  
}
