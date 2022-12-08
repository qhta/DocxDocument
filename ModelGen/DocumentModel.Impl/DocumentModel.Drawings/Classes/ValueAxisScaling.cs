namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ValueAxisScaling Class.
/// </summary>
public class ValueAxisScalingImpl: ModelElementImpl, ValueAxisScaling
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueAxisScaling? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueAxisScaling?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// max, this property is only available in Office 2016 and later.
  /// </summary>
  public String? Max
  {
    get;
    set;
  }
  
  /// <summary>
  /// min, this property is only available in Office 2016 and later.
  /// </summary>
  public String? Min
  {
    get;
    set;
  }
  
  /// <summary>
  /// majorUnit, this property is only available in Office 2016 and later.
  /// </summary>
  public String? MajorUnit
  {
    get;
    set;
  }
  
  /// <summary>
  /// minorUnit, this property is only available in Office 2016 and later.
  /// </summary>
  public String? MinorUnit
  {
    get;
    set;
  }
  
}
