namespace DocumentModel.Drawings;

/// <summary>
/// Scaling.
/// </summary>
public class ScalingImpl: ModelElementImpl, Scaling
{
  public DocumentFormat.OpenXml.Drawing.Charts.Scaling? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.Scaling?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Logarithmic Base.
  /// </summary>
  public Double? LogBase
  {
    get;
    set;
  }
  
  /// <summary>
  /// Axis Orientation.
  /// </summary>
  public OrientationKind? Orientation
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Orientation>();
        return (OrientationKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Orientation>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Drawing.Charts.OrientationValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Drawing.Charts.Orientation{ Val = (DocumentFormat.OpenXml.Drawing.Charts.OrientationValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Maximum.
  /// </summary>
  public Double? MaxAxisValue
  {
    get;
    set;
  }
  
  /// <summary>
  /// Minimum.
  /// </summary>
  public Double? MinAxisValue
  {
    get;
    set;
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public ExtensionList4? ExtensionList
  {
    get;
    set;
  }
  
}
