namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Data Class.
/// </summary>
public class Data1Impl: ModelElementImpl, Data1
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Data? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Data?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// id, this property is only available in Office 2016 and later.
  /// </summary>
  public UInt32? Id
  {
    get;
    set;
  }
  
  public Collection<NumericDimension>? NumericDimensions
  {
    get;
    set;
  }
  
  public Collection<StringDimension>? StringDimensions
  {
    get;
    set;
  }
  
  public ExtensionList2? ExtensionList
  {
    get;
    set;
  }
  
}
