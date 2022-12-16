namespace DocumentModel.Drawings.ChartDrawings;

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
  
  public ValueAxisScalingImpl(): base() {}
  
  public ValueAxisScalingImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueAxisScaling openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// max, this property is only available in Office 2016 and later.
  /// </summary>
  public String? Max
  {
    get => (System.String?)OpenXmlElement?.Max?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Max = (System.String?)value;
    }
  }
  
  /// <summary>
  /// min, this property is only available in Office 2016 and later.
  /// </summary>
  public String? Min
  {
    get => (System.String?)OpenXmlElement?.Min?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Min = (System.String?)value;
    }
  }
  
  /// <summary>
  /// majorUnit, this property is only available in Office 2016 and later.
  /// </summary>
  public String? MajorUnit
  {
    get => (System.String?)OpenXmlElement?.MajorUnit?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.MajorUnit = (System.String?)value;
    }
  }
  
  /// <summary>
  /// minorUnit, this property is only available in Office 2016 and later.
  /// </summary>
  public String? MinorUnit
  {
    get => (System.String?)OpenXmlElement?.MinorUnit?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.MinorUnit = (System.String?)value;
    }
  }
  
}
